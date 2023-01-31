using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Admin_Interface;

namespace Server
{

    class AdminDAO : MarshalByRefObject, Admin_Interface.Services
    {
        string server = "127.0.0.1";
        string db = "poc_project";
        string user = "root";
        string pass = "";





        /*
         * requets  
         * 
         * https://zetcode.com/csharp/mysql/
         * 
         */

        public string login_sql = "select id from admin where user=@user and pass=@pass;";
        public string add_account_sql = "insert into account (user,pass)values(@user,@pass);";
        public string delete_account_sql = "delete from account where id =@id;";
        public string get_account_list_sql = "select * from account;";
        public string is_access_sql = "select access from access_camera where id=1;";
        public string allow_access_sql = "update access_camera  set access ='true' where id=1;";
        public string deny_access_sql = "update access_camera  set access ='false' where id=1;";
        public string get_door_list_sql = "select * from door order by date_t  DESC  ;";

        public string carbon_is_normal_sql = "select id from carbon where ppm >='1000';";

        public string carbon_list_sql = "select id,sv,rzero,ppm  from carbon order by id  DESC;";

        MySqlConnection conn;




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

        // ajouter account autorisie
        public void add_account(String user, string pass)
        {


            connect_db();
            try
            {
                var cmd = new MySqlCommand(add_account_sql, conn);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(" problem in add_account() because +" + e);
            }
            conn.Close();
        }

        //  supprimer un account
        public void delete_account(int id)
        {

            connect_db();
            try
            {
                var cmd = new MySqlCommand(delete_account_sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(" problem in  delete account () because +" + e);
            }
            conn.Close();

        }

        // list_account _authorized 

        public List<Account> get_account_list()
        {

            List<Account> list_account = new List<Account>();
            Account account;
            connect_db();
            try
            {
                var cmd = new MySqlCommand(get_account_list_sql, conn);
                MySqlDataReader result = cmd.ExecuteReader();

                while (result.Read())
                {
                    account = new Account();
                    account.setId(result.GetInt32(0));
                    account.setUser(result.GetString(1));
                    account.setPass(result.GetString(2));
                    list_account.Add(account);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(" problem in  get_account_list () because +" + e);

            }

            conn.Close();
            return list_account;

        }

        public void turn_on_camera()
        {

            connect_db();
            try
            {
                var cmd = new MySqlCommand(allow_access_sql, conn);
               
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(" problem in allow_access() because +" + e);
            }
            conn.Close();

        }
        public void turn_off()
        {

            connect_db();
            try
            {
                var cmd = new MySqlCommand(deny_access_sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(" problem in deny access() because +" + e);
            }
            conn.Close();
        }
        public string camera_access()
        {
            string access="";
            connect_db();
            try
            {
                var cmd = new MySqlCommand(is_access_sql, conn);
                MySqlDataReader result = cmd.ExecuteReader();
               
                while (result.Read())
                {
                    access= result.GetString(0);

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
         *  list of the all  accesse home 
         * 
         */
     public  List<Door> get_door_list()
        {
            List<Door> list_door = new List<Door>();
            Door door;
            connect_db();
            try
            {
                var cmd = new MySqlCommand(get_door_list_sql, conn);
                MySqlDataReader result = cmd.ExecuteReader();

                while (result.Read())
                {
                    door = new Door();
                    door.setId(result.GetInt32(0));
                    door.setDate(result.GetString(1));
                    door.setTime_t(result.GetTimeSpan(2));
                    list_door.Add(door);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(" problem in  get_door_list () because +" + e);

            }

            conn.Close();
            return list_door;
            
        }


        /*
         * 
         * Loock if the measuer of co2 is normal or not  
         * 
         */
       public  bool carbon_is_normal()
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




      public  List<Carbon> carbon_list()
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
