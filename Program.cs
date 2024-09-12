using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string command = Console.ReadLine();
                Person person = new Person();
                bool flag = true;

                while (command.ToLower() != "end")
                { 
                    if (flag)
                    {
                        string[] people = command.Split(' ').ToArray();
                        person = new Person(people[0], int.Parse(people[1]));
                        flag = false;
                    }
                    else
                    {
                        string[] productCommand = command.Split(' ').ToArray();
                        Product product = new Product(productCommand[0], int.Parse(productCommand[1]));
                    }
                    command = Console.ReadLine();
                }


                if (Product.Differences(person)>=0)
                {
                    Console.WriteLine("After the purchase of these products you will have {0} dolars",Product.Differences(person));
                }
                else
                {
                    Console.WriteLine("You need {0} dolars more to purchase these products",Math.Abs(Product.Differences(person)));
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
