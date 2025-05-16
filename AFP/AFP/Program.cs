using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AFP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> Users = new List<Person>();
            while (true)
            {
                Console.WriteLine("Please enter your user Id");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter your user Name");
                string Name = Console.ReadLine();
                Console.WriteLine("Please enter your user Age");
                int Age = Convert.ToInt32(Console.ReadLine());

                Users.Add(new Person
                {
                    Id = Id,
                    Name = Name,
                    Age = Age
                }
                );
                Console.WriteLine("Do you want to continue y/n");
                char move = Convert.ToChar(Console.ReadLine());
                if (move == 'n') { break; }
                else { continue; }


            }
            int i = 1;
            foreach (Person item in Users)
            {
                Console.WriteLine("user" + $"{i}");
                Console.WriteLine($"Id : {item.Id} \nName : {item.Name} \nAge : {item.Age}");
                Console.WriteLine();
                i++;
            }
            Console.WriteLine("Do you want to update a user or to remove it?");
            string Mainresponce = Console.ReadLine();
            if (Mainresponce == "update")
            {
                Console.WriteLine(" Enter your Id :");
                int UserId = Convert.ToInt32(Console.ReadLine());
                var UserIdFounded = Users.Find(x => x.Id == UserId);
                Console.WriteLine($"Id : {UserIdFounded.Id} \nName : {UserIdFounded.Name} \nAge : {UserIdFounded.Age}");
                Console.WriteLine("What do you want to change? Age or Name");
                string Response = Console.ReadLine();
                if (Response == "Age")
                {
                    Console.WriteLine("New age :");
                    int NewAge = Convert.ToInt32(Console.ReadLine());
                    UserIdFounded.Age = NewAge;
                    Console.WriteLine($"Id : {UserIdFounded.Id} \nName : {UserIdFounded.Name} \nAge : {UserIdFounded.Age}");
                }
                else
                {
                    Console.WriteLine("New name :");
                    string NewName = Console.ReadLine();
                    UserIdFounded.Name = NewName;
                    Console.WriteLine($"Id : {UserIdFounded.Id} \nName : {UserIdFounded.Name} \nAge : {UserIdFounded.Age}");


                }

            }
            else
            {
                while (true)
                {
                    Console.WriteLine(" enter your Id :");
                    int UserByID = Convert.ToInt32(Console.ReadLine());
                    var UserFoundById = Users.Find(x => x.Id == UserByID);

                    if (UserFoundById != null)
                    {
                        Users.Remove(UserFoundById);
                        Console.WriteLine("user removed");
                    }
                    else
                    {
                        Console.WriteLine("user not found");
                    }
                }

            }
        }
    }
}
