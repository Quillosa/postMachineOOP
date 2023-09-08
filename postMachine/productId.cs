using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMachine
{
    internal class productId
    {
        List<int> id = new List<int>();

        

        public void setproduct(int productId)
        {
           
            id.Add(productId);
           
        }
        public int getId(int index) {

            int idMo = id[index];
            return idMo;
            
        }
        public int getindex(int productd)
        {
            if (id.Contains(productd))
            {
                int index = id.IndexOf(productd);
                return index;
            }
            else
            {
                return -1;
            }
        }
        

    }
}
