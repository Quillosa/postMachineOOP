using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMachine
{
    internal class productName
    {
        List<string> name = new List<string>();
        public void setName(string productName)
        {
            name.Add(productName);
        }

        public string getName(int index)
        {
            string names =name[index];
            return names;
        }

    }
}
