using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    class Product
    {
        private string productName;
        private int price;
        public static List<Product> products = new List<Product>();


     
        public string ProductName
        {
            get { return productName; }
            set
            {
                if (value.ToLower() == string.Empty )
                {
                    throw new ArgumentException("Трябва да въведете валидно име");
                   
                }
                productName = value;
            } 
        }
        public int Price
        {
            get { return price; }
            set {price = value;}
        }


        public Product(string productName,int price)
        {
            this.ProductName = productName;
            this.Price = price;
            products.Add(this);
        }

        public static int Differences(Person person) 
        {
            int sum = 0;
            foreach (Product item in products)
            {
                sum += item.Price;
            }

            return person.Money - sum; 
        }

        public override string ToString()
        {
            return productName + price;
        }

        
    }
}
