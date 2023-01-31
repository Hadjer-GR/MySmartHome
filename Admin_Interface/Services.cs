using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Interface
{
  public interface Services
    {
        bool login(string username, string pass);
        void add_account(String user, string pass);
        void delete_account(int id);
        List<Account> get_account_list();
        
        void turn_on_camera();
        void turn_off();
        string camera_access();

        List<Door> get_door_list();
        bool carbon_is_normal();

        List<Carbon> carbon_list();




    }
}
