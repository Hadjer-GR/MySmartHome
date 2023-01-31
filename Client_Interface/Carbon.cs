using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Interface
{
    [Serializable]
    public  class Carbon
    {
        private  int id;
        private   float sv;
        private float rzero;
        private float ppm;


        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }
        public void setSv(float sv)
        {
            this.sv = sv;
        }
        public float getSv()
        {
            return this.sv;
        }
        public void setRzero(float rzero)
        {
            this.rzero = rzero;
        }
        public float getRzero()
        {
            return this.rzero;
        }
        public void setPpm(float ppm)
        {
            this.ppm = ppm;
        }
        public float getPpm()
        {
            return this.ppm;
        }



    }
}
