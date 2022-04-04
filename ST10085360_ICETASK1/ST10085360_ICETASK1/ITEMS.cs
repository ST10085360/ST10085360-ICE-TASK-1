using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10085360_ICETASK1
{
    internal class ITEMS 
    {
        public string itemName { get; set; }
        public double PRICE { get; set; }

        public ITEMS(){}                                                //ITEMS CLASS PROVIDES GETTER AND SETTER
        public ITEMS(string name, double price)                         //FOR THE ITEMS NAME AND PRICE SO THAT
        {                                                               // THE CART CLASS CAN ADD THE ENTRIES
            itemName = name;
            PRICE = price;
        }


    
    }
}
