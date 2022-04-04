using System;

namespace ST10085360_ICETASK1
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ITEMS[] ITEM = new ITEMS[5];
                double totalPrice = 0.0;
                string itemEntry = "";

                Console.WriteLine("WELCOME TO TAKE 5");
                Console.WriteLine("PLEASE ENTER 5 ITEMS AND THEIR PRICES TO PROCEED TO CHECKOUT");
                Console.WriteLine("************************************************************");
                Console.WriteLine("");

                try
                {
                    //FOR LOOP FOR GETTING VALUES AND NAMES-----------------
                    for (int i = 0; i < ITEM.Length; i++)                                           //FOR LOOP RUNS UP UNTIL THE MAX LENGTH OF THE ITEMS ARRAY(5)
                    {                                                                               //IN OTHER WORDS, YOU CAN ONLY ENTER VALUES UNTIL YOU REACH THE 5TH INTERVAL   
                        Console.WriteLine("\nEnter the name of the item:");                           //THE NAME AND PRICE OF EACH ITEM GETS ADDED TO THE ITEMS CLASS THROUGH THE ITEM OBJECT
                        String NAME = Console.ReadLine();                                           //DUE TO THE GET AND SET METHODS THAT GET THE ENTRIES
                        Console.WriteLine("\nEnter the price of the item:");                          
                        double PRICE = Convert.ToDouble(Console.ReadLine());

                        totalPrice += PRICE;
                        ITEM[i] = new ITEMS(NAME, PRICE);
                    }
                    //-------------------------------------------------------

                    //A CART OBJECT IS THEN CREATED TO MAKE CALCULATIONS AND WORKOUT/ADD THE VAT PERCENTAGE
                    CART obj = new CART(0.14, totalPrice);                                          
                    obj.CALCULATIONS();
                    //-------------------------------------------------------------------------------------

                    //FOR LOOP FOR DISPLAYING EACH RECORDED ITEM AND ITS PRICES AS WELL AS PRINTING THE RECIEPT------------------
                    for (int i = 0; i < ITEM.Length; i++)
                    {                                                                                                                   //THIS FOR LOOP IS DISPLAYING EACH ITEM ENTRY RECORDED
                        itemEntry += "\nItem name: " + ITEM[i].itemName + "\tItem Price: R " + ITEM[i].PRICE.ToString("F");                 //RECORDED BY THE PROGRAM FOR THE USER TO SEE IN THE OUTPUT    
                        
                    }
                    Console.WriteLine(itemEntry);
                    Console.WriteLine(obj.PrintReciept(itemEntry));         
                    //-----------------------------------------------------------------------------------------------------------

                    //SWITCH STATEMENT FOR TO ASK USER IF THEY WISH TO EXIT THE PROGRAM------------------------------------------
                    Console.WriteLine("\nIF YOU WISH TO EXIT THE PROGRAM, PLEASE ENTER (e)\n ENTER ANY OTHER KEY TO CONTINUE ->");        //THIS METHOD PROMPTS THE USER FOR AN EXIT KEY 
                    String exitKey = Console.ReadLine();
                    switch (exitKey)
                    {
                        case "e":  exit();
                        break;

                        default:
                        break;
                    }
                }
                    //-----------------------------------------------------------------------------------------------------------

                catch (FormatException)
                {
                    //ERROR MESSAGE DISPLAYED WHEN INCORRECT FORMATS ARE ENTERED
                    Console.WriteLine("Incorrect format provided. Please try again");
                }
            }
        }

        private static void exit()          //EXIT APPLICATION METHOD
        {
            Environment.Exit(0);
        }
    }
}
