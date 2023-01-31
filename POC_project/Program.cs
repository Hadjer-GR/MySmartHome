using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting;
using Admin_Interface;
using System.Collections;

namespace Server

{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            // 1)Creation d'un canal Tcp sur le port 65000
            //enregistre ce canal dans le domaine d'application courant.
            TcpChannel canal = new TcpChannel(6500);
            ChannelServices.RegisterChannel(canal, false);
            // 2) Ce domaine d'application presente un objet de type
            //AdminDAO  associe au point terminal 'Transaction'.
            RemotingConfiguration.RegisterWellKnownServiceType(
            typeof(Server.AdminDAO),
            "obj",
            WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(
           typeof(Server.ClientDAO),
               "obj_client",
           WellKnownObjectMode.Singleton);
            // 3) Maintient du processus courant.
            Console.Write("Le serveur est prêt.....");
            Console.Read();
           
          
           
           /* 
            AdminDAO admin = new AdminDAO();

            List<Carbon> list_carbon = new List<Carbon>();
            list_carbon = admin.carbon_list();

            Console.WriteLine(admin.carbon_is_normal());
            Console.WriteLine(list_carbon.Count());

            Console.ReadLine();
           */

        }
    }
}
