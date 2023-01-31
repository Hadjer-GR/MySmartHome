using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Interface
{
    [Serializable]
    public  class Door
    {
      private  int id;
       private  string date;
       private TimeSpan time;

        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }
        public void setDate(string date)
        {
            this.date = date;
        }
        public string getDate()
        {
            return this.date;
        }
        public void setTime_t(TimeSpan time)
        {
            this.time = time;
        }
        public TimeSpan getTime_t()
        {
            return this.time;
        }

       
    }
}
