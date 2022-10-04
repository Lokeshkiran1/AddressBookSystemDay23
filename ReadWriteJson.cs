using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManagemenrtSystemDay28
{
    internal class ReadWriteJson
    {
        string filePath = @"C:\Users\HP\Desktop\csharp\AddressBookManagemenrtSystemDay28\AddressRecord.json";
        public void WriteToFile(Dictionary<string, AddressBookBuilder> addressBookDictionary)
        {
            foreach (AddressBookBuilder obj in addressBookDictionary.Values)
            {
                foreach (Contacts contact in obj.addressBook.Values)
                {
                    string json = JsonConvert.SerializeObject(contact);
                    File.WriteAllText(filePath, json);
                }
            }
            Console.WriteLine("\nSuccessfully added to JSON file.");
        }
        public void ReadFromFile()
        {
            Contacts contact = JsonConvert.DeserializeObject<Contacts>(File.ReadAllText(filePath));
            Console.WriteLine(contact.ToString());
        }
    }
}
