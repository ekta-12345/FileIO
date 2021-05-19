using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileIO_IOStream
{
    class XMLOperation
    {
        public static void XMLSerialization()
        {
            try
            {
                string path = @"D:\C#\FileIO-IOStream\FileIO-IOStream\Files Operation\XMLSerialization.xml"; //Set path to create file
                FileStream fstream = new FileStream(path, FileMode.OpenOrCreate); //FileStream class create object and pass Path or create and open file
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Content)); //Create object XmlSerializer Class default class
                Content content = new Content();//Create object of Content Class
                xmlSerializer.Serialize(fstream, content); //Serialize data using Serialize method
                Console.WriteLine($"File Successfully Created XMLSerialization.xml And Serialize Content"); //Print msg

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }


        public static void XMLDeserialization()
        {
            try
            {
                string path = @"D:\C#\FileIO-IOStream\FileIO-IOStream\Files Operation\XMLSerialization.xml";  //Set path to create file
                
                FileStream fstream = new FileStream(path, FileMode.Open); //FileStream class create object and pass Path or create and open file
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Content)); //Create object XmlSerializer Class default class
                Content store = (Content)xmlSerializer.Deserialize(fstream); // DeserializeObject of Details
                Console.WriteLine($"File Successfully Deserialization"); //Print msg
                
                Console.WriteLine($"FirstName:- {store.FirstName}\nLastName:- {store.LastName}\nAddress:- {store.Address}\nCity:- {store.City}\nPin:- {store.Pin}\nNumber:- {store.Number}"); //Print data
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
    public class Content
    {
        public string FirstName { get; set; } = "Ekta";
        public string LastName { get; set; } = "Kumbhare";
        public string Address { get; set; } = "Pune";
        public string City { get; set; } = "Pune";
        public string Pin { get; set; } = "411008";
        public string Number { get; set; } = "7709283363";
    }
}
