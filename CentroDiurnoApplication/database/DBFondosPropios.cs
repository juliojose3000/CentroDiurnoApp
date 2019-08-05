using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDiurnoApplication.database
{
    class DBFondosPropios
    {

        DBConnection dBConnection = new DBConnection();

        public List<FPayment> read(string month, int year)
        {

            List<FPayment> listPayments = new List<FPayment>();

            //string command = "select* from fondos_propios;";
            string command = "select* from fondos_propios where month='"+month+ "' and year = "+year+";";

            var reader = dBConnection.executeQueryCommand(command);

                FPayment payment;

            if (reader == null) { return listPayments; }

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string description = reader.GetString(1);
                    float amount_conapan = reader.GetFloat(4);


                    payment = new FPayment(id, description,month, year, amount_conapan);

                    listPayments.Add(payment);

                }

            dBConnection.closeConnection();

            return listPayments;
        }

        public int maxId()
        {

            int id = -1;

            string command = "select max(id) from fondos_propios;";

            var reader = dBConnection.executeQueryCommand(command);

            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }

            dBConnection.closeConnection();

            return id;
        }

        public Boolean insert(string description,string month,int year, float amount)
        {

            string command = "insert into fondos_propios (description,month,year,amount_payment) " + "values ('" + description + "','"+ month + "'," + year +","+ amount + ");";

            if (dBConnection.executeNonQueryCommand(command) == 0)
            {
                return false;
            }

            dBConnection.closeConnection();

            return true;

        }

        public Boolean delete(int id)
        {

            string command = "delete from fondos_propios where id=" + id + ";";

            if (dBConnection.executeNonQueryCommand(command) == 0)
            {
                return false;
            }

            dBConnection.closeConnection();

            return true;


        }

        public Boolean update(int id, string description, float amount)
        {

            string command = "update fondos_propios set description = '" + description + "', amount_payment = " + amount + " where id = " + id + ";";

            if (dBConnection.executeNonQueryCommand(command) == 0)
            {
                return false;
            }

            dBConnection.closeConnection();

            return true;

        }

        private Boolean resultQuery(int result)
        {
            if (result == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
