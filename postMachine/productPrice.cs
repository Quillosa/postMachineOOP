using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMachine
{
    internal class productPrice
    {
        List<double> price = new List<double>();
        public void setPrice(double productPrice)
        {
            price.Add(productPrice);
        }
        public double getPrice(int index)
        {
            /*for (int i = 0; i < price.Count; i++)
            {
                if (price[i] == index)
                {
                    index = i;
                    break;

                }
            }*/
            double presyo = price[index];
            return presyo;
        }



    }
}
