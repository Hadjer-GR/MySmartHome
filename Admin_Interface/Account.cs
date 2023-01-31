using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Interface
{
    [Serializable]

    public class Account
    {
          private int id;
        private string username;
        private string password;

        public void  setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
           return this.id ;
        }
        public void setUser(string user)
        {
            this.username = user;
        }
        public string getUser()
        {
            return this.username;
        }
        public void setPass(string pass)
        {
            this.password = pass;
        }
        public string getPass()
        {
            return this.password;
        }

    }
}
