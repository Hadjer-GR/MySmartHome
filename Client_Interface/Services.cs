using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Interface
{
     public interface Services
    {
        bool login(string username, string pass);
        string camera_access();
        //   string get_carbon();

        bool carbon_is_normal();

        List<Carbon> carbon_list();


    }
}
