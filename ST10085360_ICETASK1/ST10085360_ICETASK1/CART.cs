using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10085360_ICETASK1
{
    internal class CART : ITEMS
    {
        String Reciept;

        double GrandTotal, VATperc;

        public double TotalPrice { get; set; }

        public double vat { get; set; }

        public CART(double V, double T)
        {
            vat = V;
            TotalPrice = T;
        }

        //CALCULATION CLASS FOR TOTALS AND VAT------------------
        public void CALCULATIONS()                                                          //THE VAT VALUE IS CALCULATED WITH THIS METHOD
        {                                                                                   //AS WELL AS THE GRAND TOTAL
            this.VATperc = this.TotalPrice * 0.14;  
            this.GrandTotal = this.TotalPrice + this.VATperc;
        }
        //-------------------------------------------------------

        //PRINT RECIEPT CLASS PROVIDES OVERVIEW OF THE PRICES AND VAT------
        public string PrintReciept(string itemEntry)
        {
            this.Reciept = "\nYOUR CUSTOMER RECIEPT:"                                          //THIS METHOD PROVIDES A RECIEPT STRING INCLUDING THE                    
        + "\n********************************************"                                   //TOTAL PRICE EXCLUDING VAT, VAT VALUE AND GRANDTOTAL               
        + "\nTotal: R" + this.TotalPrice.ToString("F")
        + "\nVAT: R" + this.VATperc.ToString("F")
        + "\n*********************************************"
        + "\nGrand Total: R" + this.GrandTotal.ToString("F")
        + "\n*********************************************";
            return Reciept;
        }
        //-----------------------------------------------------------------
    }
}
