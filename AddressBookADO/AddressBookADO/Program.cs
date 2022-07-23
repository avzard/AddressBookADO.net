using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AddressBookADO.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook ADO.NET!");
            Console.WriteLine("Select option\n1)Create AddrssBookServiceDatabase\n2)Create AddressBookTable\n3)Inserting Details to DataBasen" +
                "\n4)retrieve Details From dataBase");
            int op = Convert.ToInt16(Console.ReadLine());
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            AddressBookModel addressbook = new AddressBookModel();

            switch (op)
            {
                case 1:
                    addressBookRepo.Create_Database();
                    break;
                case 2:
                    addressBookRepo.CreateTables();
                    break;
                case 3:
                    addressbook.FirstName = "Abhishek";
                    addressbook.LastName = "Jadhav";
                    addressbook.Address = "Khojgaon ";
                    addressbook.City = "Ambarnath";
                    addressbook.State = "M";
                    addressbook.Zip = "421501";
                    addressbook.PhoneNumber = "9657726141";
                    addressbook.Email = "4shivaraj@gmail.com";
                    addressBookRepo.AddContact(addressbook);
                    Console.WriteLine("Record Inserted successfully");
                    break;
                case 4:
                    addressBookRepo.GetAllContact();
                    break;

            }
        }
    }
}
