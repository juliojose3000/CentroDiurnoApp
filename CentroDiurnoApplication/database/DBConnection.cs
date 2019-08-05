using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CentroDiurnoApplication
{
    class DBConnection
    {

        //string connectionString = string.Format("Server=localhost; database=centro_diurno_cachi; UID=root; password=12345Julio!", "");

        string connectionString = string.Format("Server=sql247.main-hosting.eu.; database=u872613053_cdc; UID=u872613053_admin; password=12345Julio!", "");

        MySqlConnection connection;

        public MySqlDataReader executeQueryCommand(string command)
        {

            MySqlDataReader reader = null;

            try { 
                connection = new MySqlConnection(connectionString);
                MySqlCommand cmd = new MySqlCommand(command, connection);
                connection.Open();
                reader = cmd.ExecuteReader();
                
            }
            catch (MySqlException)
            {
                //Alert message
            }

            return reader;
        }

        public int executeNonQueryCommand(string command)
        {

            int resultNonQuery = 0;

            try
            {
                connection = new MySqlConnection(connectionString);
                MySqlCommand cmd = new MySqlCommand(command, connection);
                connection.Open();
                resultNonQuery = cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.Write(e);
                if(e.Message == "Unable to connect to any of the specified MySQL hosts.")
                {
                    //No hay conexion a internet.
                }
            }

            return resultNonQuery;
        }


        public void closeConnection()
        {
            connection.Close();
        }


    }
}
