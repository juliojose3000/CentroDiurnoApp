using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDiurnoApplication.database
{
    class DBFondosExternos
    {

        DBConnection dBConnection = new DBConnection();

        public List<Payment> read(string month, int year)
        {

            List<Payment> listPayments = new List<Payment>();

            //string command = "select* from payment where month='Julio';";
            string command = "select* from payment where month='"+month+"'and year = "+year+";";

            var reader = dBConnection.executeQueryCommand(command);

            if (reader == null) { return listPayments; }

            Payment payment;
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string description = reader.GetString(1);
                string currentMonth = reader.GetString(2);
                int currentYear = reader.GetInt32(3);
                float amount_conapan = reader.GetFloat(4);
                float amount_fodesaf = reader.GetFloat(5);
                float amount_jps = reader.GetFloat(6);
                float total = reader.GetFloat(7);

                payment = new Payment(id, description, currentMonth,currentYear, amount_conapan, amount_fodesaf, amount_jps, total);

                listPayments.Add(payment);

            }

            dBConnection.closeConnection();

            return listPayments;
        }

        public int maxId()
        {

            int id = -1;

            string command = "select max(id) from payment;";

            var reader = dBConnection.executeQueryCommand(command);

            if (reader.FieldCount == 0) { return 0; }

            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }

            dBConnection.closeConnection();

            return id;
        }

        public Boolean insert(string description, string month,int year, float conapan, float fodesaf, float jps, float total)
        {

            string command = "insert into payment (description,month,year,amount_conapan,amount_fodesaf,amount_jps,total) " +
                "values ('" + description + "','" + month + "'," + year +","+ conapan + "," + fodesaf + "," + jps + "," + total + ");";

            if (dBConnection.executeNonQueryCommand(command)==0)
            {
                return false;
            }

            dBConnection.closeConnection();

            return true;
        }

        public Boolean delete(int id)
        {

            string command = "delete from payment where id=" + id + ";";

            if (dBConnection.executeNonQueryCommand(command) == 0)
            {
                return false;
            }

            dBConnection.closeConnection();

            return true;

        }

        public Boolean update(int id, string description, float conapan, float fodesaf, float jps, float total)
        {

            string command = "update payment set description = '" + description + "', amount_conapan = " + conapan + ", amount_fodesaf = " + fodesaf + ", amount_jps = " + jps + ", total = " + total + " where id = " + id + ";";

            var reader = dBConnection.executeNonQueryCommand(command);

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

        public void readDataCurrentMonth(string month)
        {

        }


    }
}
