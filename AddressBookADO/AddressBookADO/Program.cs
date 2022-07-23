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
            Console.WriteLine("Select option\n1)Create AddrssBookServiceDatabase\n2)Create AddressBookTable");
            int op = Convert.ToInt16(Console.ReadLine());
            AddressBookRepo addressBookRepo = new AddressBookRepo();

            switch (op)
            {
                case 1:
                    addressBookRepo.Create_Database();
                    break;
                case 2:
                    addressBookRepo.CreateTables();
                    break;

            }
        }
    }
}
