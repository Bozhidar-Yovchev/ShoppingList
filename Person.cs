using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    class Person
    {
        private string name;
        private int money;
        

        public string Name
        {
            get { return name; }
            private set
            {
                if (value.ToLower() == string.Empty)
                {
                    throw new ArgumentException("There is not a person without a name");
                }
                name = value;
            }
        }
        public int Money
        {
            get { return money; }
            private set
            {
                if ( value <=0 )
                {
                    throw new ArgumentException("The price of the product can't be negative");
                }
                money = value;
            }
        }
        public Person()
        {

        }
        public Person(string name,int money)
        {
            this.Name = name;
            this.Money = money;
        }

        public override string ToString()
        {
            return Name + Money;
        }
    }
}
