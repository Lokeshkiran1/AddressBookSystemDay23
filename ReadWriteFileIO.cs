using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManagemenrtSystemDay28
{
    internal class ReadWriteFileIO
    {
        static string file = @"C:\Users\HP\Desktop\csharp\AddressBookManagemenrtSystemDay28\AddressBook.txt";

        public void WriteToFile(Dictionary<string, AddressBookBuilder> addressBookDictionary)
        {
            StreamWriter writer = new StreamWriter(file, true);
            foreach (AddressBookBuilder item in addressBookDictionary.Values)
            {
                foreach (Contacts contact in item.addressBook.Values)
                {
                    writer.WriteLine(contact.ToString());
                }
            }
            Console.WriteLine("\nSuccessfully added to Text file.");
            writer.Close();
        }
        public void ReadFromFile()
        {
            Console.WriteLine(File.ReadAllText(file));
        }
    }
}
