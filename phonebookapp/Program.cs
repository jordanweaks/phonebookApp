using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebookapp
{
   
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> contactList = new List<Person>();
            Person contact = new Person();
            Address address = new Address();
            int selectOption = 0;
            while (selectOption != 8)
            {
                Console.WriteLine("1: Add a new contact");
                Console.WriteLine("2: Search contact by first name");
                Console.WriteLine("3: Search contact by last name");
                Console.WriteLine("4: Search contact by city");
                Console.WriteLine("5: Delete a contact by first name");
                Console.WriteLine("6: Order list by contact’s first name");
                Console.WriteLine("7: exit");
                Console.WriteLine("Choice: ");
                selectOption = int.Parse(Console.ReadLine());
                switch (selectOption)
                {
                    case 1:
                        Console.WriteLine("Enter first name: ");
                        contact.firstName = Console.ReadLine();
                        Console.WriteLine("Enter last name: ");
                        contact.lastName = Console.ReadLine();
                        Console.WriteLine("Enter phone number: ");
                        contact.phoneNumber = Console.ReadLine();
                        Console.WriteLine("Enter first street address: ");
                        address.street = Console.ReadLine();
                        Console.WriteLine("Enter first city: ");
                        address.city = Console.ReadLine();
                        Console.WriteLine("Enter first zip: ");
                        address.zip = int.Parse(Console.ReadLine());
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Search contact by first name");
                        string name = Console.ReadLine();

                        if (contact.firstName.Equals(name))
                        {
                            Console.WriteLine(contact.firstName+" "+contact.lastName+" "+ contact.phoneNumber + " " + address.street + " " + address.city + " " + address.zip);
                        }
                        
                        break;
                    case 3:
                        Console.WriteLine("Search contact by last name");
                        string name2 = Console.ReadLine();
                        foreach (var person in contactList)
                        {
                            if (person.lastName.Equals(name2))
                            {
                                Console.WriteLine(person.firstName, person.lastName, person.phoneNumber, address.street, address.city, address.zip);
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Search contact by city");
                        string city = Console.ReadLine();
                        foreach (var person in contactList)
                        {
                            if (address.city.Equals(city))
                            {
                                Console.WriteLine(person.firstName, person.lastName, person.phoneNumber, address.street, address.city, address.zip);
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("By which first name would you like to delete?: ");
                        string deleteContact = Console.ReadLine();
                        foreach (var person in contactList)
                        {
                            if (person.firstName.Equals(deleteContact))
                            {
                                contactList.Remove(person);
                            }
                        }
                        break;
                    case 6:
                        var peopleInOrder = contactList.OrderBy(person => person.firstName);
                        break;
                }
            }

            Console.ReadLine();
        }   
    }
}
