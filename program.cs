using System;
using System.Collections.Generic;

namespace whatever
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating obj of class customer
            customer customer1 = new customer()
            {   //setting the properties
                ID = 1,
                name = "Rohan",
                age = 24,
                salary = 23000,
            };

            customer customer2 = new customer();
                 //setting properties in another way
                customer2.ID = 2;
                customer2.name = "Sadiq";
                customer2.age = 26;
                customer2.salary = 46000;
                

            customer customer3 = new customer();
            customer3.ID = 23;
            customer3.name = "Wasey";
            customer3.age = 29;
            customer3.salary = 16000;

            List<customer> listOfCustomers = new List<customer>();
            listOfCustomers.Add(customer1);
            listOfCustomers.Add(customer2);
            listOfCustomers.Add(customer3);

            Console.WriteLine("Before Sorting");
            foreach(customer c in listOfCustomers)
            {
                Console.WriteLine("ID: {0}\nName: {1}\nAge: {2}\nSalary:{3}",c.ID,c.name,c.age,c.salary);
                Console.WriteLine("  ");
                Console.WriteLine("----------------");
            }


            listOfCustomers.Sort();

            Console.WriteLine("After Sorting");
            foreach (customer c in listOfCustomers)
            {
                Console.WriteLine("ID: {0}\nName: {1}\nAge: {2}\nSalary:{3}", c.ID, c.name, c.age, c.salary);
                Console.WriteLine("  ");
                Console.WriteLine("----------------");
            }

            Console.ReadKey();
        }
    }

    class customer : IComparable<customer>
    {           //class customer has these 4 properties.
        public int ID
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }

        public int salary
        {
            get;
            set;
        }

        public int age
        {
            get;
            set;
        }

        public int CompareTo(customer other)
        {
            return this.salary.CompareTo(other.salary);
        }
     
    }
}
