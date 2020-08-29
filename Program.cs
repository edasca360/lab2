using System;
using System.Xml.Schema;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is the description of the item");
            string name = Console.ReadLine();
            Console.WriteLine("what is the price of the item");
            double price = Double.Parse(Console.ReadLine());
            Console.WriteLine("what is the quantity of the item");
            int quantity = Int32.Parse(Console.ReadLine());
            StockItem myItem = new StockItem(name, price, quantity);
            Console.WriteLine(myItem.ToString());
            Console.WriteLine();
            StockItem item2 = new StockItem("beans", 2.50, 5);
            Console.WriteLine("description: " + item2.GetDescription());
            Console.WriteLine("price: " + item2.GetPrice());
            Console.WriteLine("quantity: " + item2.GetQuantity());
            Console.WriteLine("ID: " + item2.GetID());
            item2.SetPrice(1.75);
            Console.WriteLine("new Price: " + item2.GetPrice());
            item2.RemoveQuantity(2);
            Console.WriteLine("new quantity: " + item2.GetQuantity());
            item2.AddQuantity(7);
            Console.WriteLine("new Quantity: " + item2.GetQuantity());
            Console.ReadKey();
        }
        
    }

    class StockItem
    {
        private string description;
        private static int variableID = 0;
        private double variablePrice;
        private int variableQuantity;
        
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int VariableId
        {
            get { return variableID; }
        }
        public double VariablePrice
        {
            get { return variablePrice; }
            set { variablePrice = value; }
        }
        public int VariableQuantity
        {
            get { return variableQuantity; }
            set { variableQuantity = value; }

        }
        public static int NextID()
        {
            variableID++;
            return variableID;
        }
        
         public StockItem()
        {
            description = "";
            variableID = NextID();
            variablePrice = 0.00;
            variableQuantity = 0;
        }

         public StockItem(string d, double p, int q)
        {
            description = d;
            variablePrice = Math.Round(p,2);
            variableQuantity = q;
            variableID = NextID();
        }
        public string GetDescription()
        {
            return description;
        }
        public int GetID()
        {
            return variableID;
        }
        public string GetPrice()
        {
            return String.Format("{0:.00}", variablePrice);
        }
        public int GetQuantity()
        {
            return variableQuantity;
        }

        public void SetPrice(double price)
        {
            variablePrice = Math.Round(price,2);
        }
        public override string ToString()
        {
            return "Item description: " + description + "\n" +
                "Item variableID: " + variableID + "\n" +
                "Item Price: $" + String.Format("{0:.00}",variablePrice) + "\n" +
                "Amount in stock: " + variableQuantity;
        }
        public void RemoveQuantity(int remove)
        {
            if (variableQuantity - remove >= 0)
                variableQuantity -= remove;
            else
                Console.WriteLine("there is " + variableQuantity + " you cannot remove that many");
        }
        public void AddQuantity(int add)
        {
            variableQuantity += add;
        }
    }
}
