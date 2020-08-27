using System;
using System.ComponentModel;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class StockItem
    {
        private string description;
        private static int variableID = 0;
        private double myPrice;
        private static int myQuantity;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int VariableId
        {
            get { return variableID; }
        }
        public double MyPrice
        {
            get { return myPrice; }
            set { myPrice = value; }
        }
        public int MyQuantity
        {
            get { return myQuantity; }

        }

        public void stockItem()
        {
            description = "";
            variableID = ++variableID;
            myPrice = 0;
            myQuantity = myQuantity--;
        }

        public void stockItem(string d, double p, int q)
        {
            description = d;
            myPrice = p;
            myQuantity = q;
            variableID = ++variableID;
        }
        public double setPrice(double price)
        {
            
        }
        public override string ToString()
        {
            return "Item description: " + description + "\n" +
                "Item variableID: " + variableID + "\n" +
                "Item Price" + myPrice + "\n" +
                "Amount in stock" + myQuantity;
        }
    }
}
