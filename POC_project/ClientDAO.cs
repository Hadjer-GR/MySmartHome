using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client_Interface;

namespace Server
{
    class ClientDAO : MarshalByRefObject, Client_Interface.Services
    {


        string server = "127.0.0.1";
        string db = "poc_project";
        string user = "root";
        string pass = "";

        MySqlConnection conn;


        /*
         *  Query 
         * 
         */

        public string login_sql = "select id from account where user=@user and pass=@pass;";
        public string is_access_sql = "select access from access_camera where id=1;";
        public string carbon_is_normal_sql = "select id from carbon where ppm >='1000';";
        public string carbon_list_sql = "select id,sv,rzero,ppm  from carbon order by id  DESC;";



        /*
         *  Connect database  
         */

        public void connect_db()
        {
            string connstring = @"server=" + server + ";database=" + db + ";userid=" + user + ";password=" + pass + ";";

            try
            {
                conn = new MySqlConnection(connstring);
                conn.Open();
                Console.Write(" sucsussful connection ..");
                Console.Write("\n");
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: {0}", e.ToString());

            }

        }


        // Login admin user=admin && pass=0660 
        public bool login(string username, string pass)
        {
            connect_db();
            long id = 0;
            bool is_account = false;

            var cmd = new MySqlCommand(login_sql, conn);
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", pass);

            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                id = rdr.GetInt64(0);
            }
            if (id != 0)
            {
                is_account = true;
            }
            conn.Close();
            return is_account;
        }


        public string camera_access()
        {
            string access = "";
            connect_db();
            try
            {
                var cmd = new MySqlCommand(is_access_sql, conn);
                MySqlDataReader result = cmd.ExecuteReader();

                while (result.Read())
                {
                    access = result.GetString(0);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" problem in  access_camera () because +" + e);

            }

            return access;
            conn.Close();
        }


        /*
        * 
        * Loock if the measuer of co2 is normal or not  
        * 
        */
        public bool carbon_is_normal()
        {
            List<Carbon> list_carbon = new List<Carbon>();
            Carbon carbon;
            connect_db();
            bool is_normal = true;
            try
            {

                var cmd = new MySqlCommand(carbon_is_normal_sql, conn);
                MySqlDataReader result = cmd.ExecuteReader();

                while (result.Read())
                {
                    carbon = new Carbon();
                    carbon.setId(result.GetInt32(0));

                    list_carbon.Add(carbon);

                }
                if (list_carbon.Count() != 0)
                {
                    is_normal = false;
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(" problem in  get_door_list () because +" + e);

            }

            conn.Close();
            return is_normal;

        }




        public List<Carbon> carbon_list()
        {

            List<Carbon> list_carbon = new List<Carbon>();
            Carbon carbon;
            connect_db();
            try
            {
                var cmd = new MySqlCommand(carbon_list_sql, conn);
                MySqlDataReader result = cmd.ExecuteReader();

                while (result.Read())
                {
                    carbon = new Carbon();
                    carbon.setId(result.GetInt32(0));
                    carbon.setSv(result.GetFloat(1));
                    carbon.setRzero(result.GetFloat(2));
                    carbon.setPpm(result.GetFloat(3));
                    list_carbon.Add(carbon);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(" problem in  get_door_list () because +" + e);

            }

            conn.Close();
            return list_carbon;

        }






    }
}
