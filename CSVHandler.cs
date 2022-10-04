using CsvHelper;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManagemenrtSystemDay28
{
    public class CSVHandler
    {
        string importFilePath = @"C:\Users\HP\Desktop\csharp\AddressBookManagemenrtSystemDay28\Addresses.csv";

        public void WriteToCsv(Dictionary<string, AddressBookBuilder> addressbookDictionary)
        {
            using (StreamWriter writer = new StreamWriter(importFilePath))
            {
                using (CsvWriter csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    foreach (AddressBookBuilder item in addressbookDictionary.Values)
                    {
                        List<Contacts> contactRecord = item.addressBook.Values.ToList();
                        csv.WriteRecords(contactRecord);
                    }
                }
            }
        }
        public void ReadFromCSV()
        {
            using (StreamReader reader = new StreamReader(importFilePath))
            {
                using (CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    Console.WriteLine("Below are Contents of CSV File");
                    List<Contacts> contactRecord = csv.GetRecords<Contacts>().ToList();
                    foreach (Contacts contact in contactRecord)
                    {
                        Console.WriteLine(contact.ToString());
                    }
                }
            }
        }
    }
}
