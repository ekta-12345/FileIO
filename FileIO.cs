using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_IOStream
{
    class FileIO
    {
        public static void CreateFile() //Create Method To Create File
        {
            string path = @"D:\C#\FileIO-IOStream\FileIO-IOStream\Files Operation\Ekta.txt"; //Set path to create file

            try
            {
                using (FileStream filestream = File.Create(path)) // Create the file or overwrite if the file exists
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("My Name is Ekta"); // Adding information to the created file.

                    filestream.Write(info, 0, info.Length);
                }
                Console.WriteLine($"File Successfully Created This Location\n{path}"); //rint msg
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        public static void CheckIfFileExists()
        {/* 2:- The File exists method is used to check if a particular file exists. 
                
          */
            string path = @"D:\C#\FileIO-IOStream\FileIO-IOStream\Files Operation\Ekta.txt"; //Set file Location/ Path
            try
            {
                if (File.Exists(path)) //Check file exist or not using Exists method
                {
                    Console.WriteLine("File Exists"); //print
                }
                else
                {
                    Console.WriteLine("File does not exist"); //print
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        /* 3:- The method is used to read all the lines one by one in a file. 
               The lines are then stored in a string array variable
        */
        public static void ReadFileLines()
        {
            try
            {
                string path = @"D:\C#\FileIO-IOStream\FileIO-IOStream\Files Operation\Ekta.txt"; //Set file Location/ Path  
                if (File.Exists(path))
                {
                    using (StreamReader sr = File.OpenText(path)) //method reads a line of characters from the current stream and returns the data as a string. 
                    {
                        string s = "";
                        String line;
                        if ((s = sr.ReadLine()) != null)
                        {
                            line = File.ReadAllText(path);

                            Console.WriteLine(line);
                        }
                        else
                        {
                            Console.WriteLine("Content Not Found");
                        }
                    }

                    //string[] Content = File.ReadAllLines(path);

                    //foreach (string line in Content) //iterate content
                    //{
                    //    Console.WriteLine(line); //print content

                    //}
                }
                else
                {
                    Console.WriteLine("File Not Exist");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }


        /* 4:- The method is used to make a copy of an existing file.
        */
        public static void CopyDataFile() //Create copyDtaFile method to use copy file one file to another
        {
            try
            {
                string Source = @"D:\C#\FileIO-IOStream\FileIO-IOStream\Files Operation\Ekta.txt"; //Set file Location/ Path    
                string Destination = @"D:\C#\FileIO-IOStream\FileIO-IOStream\Files Operation\CopyEkta.txt"; //Set file Location/ Path  
                if (File.Exists(Source)) //Check file exixt or not
                {
                    File.Copy(Source, Destination); //Copy file using Copy method
                    Console.WriteLine("File Successfully Copy");
                }
                else
                {
                    Console.WriteLine("File Not Exist");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        /* 5:- The method is used to delete an existing file.
         */
        public static void DeleteFile()
        {
            try
            {
                string Destination = @"D:\C#\FileIO-IOStream\FileIO-IOStream\Files Operation\CopyEkta.txt"; //Set file Location/ Path  
                if (File.Exists(Destination)) //Check file exists or not
                {
                    File.Delete(Destination); //Delete file using Copy method
                    Console.WriteLine("File Successfully Deleted");
                }
                else
                {
                    Console.WriteLine("File does not Exist");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
        /* 6:- The stream writer is used to write data to a file using streams. 
                   The data from the application is first written into the stream. 
                   After that the stream writes the data to the file.
             */

        public static void StreamWriter() // Create Stream Writer Method
        {
            try
            {
                string path = @"D:\C#\FileIO-IOStream\FileIO-IOStream\Files Operation\Ekta.txt"; //Set file Location/ Path  
                using (StreamWriter sr = File.AppendText(path)) //create object of StreamWriter class
                {
                    sr.WriteLine("\nI am from Pune"); //Write file content
                    sr.Close(); //Close method close file


                }
                Console.WriteLine($"File Successfully Created at this Location and written the Content of File\n{path}"); //Print msg
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /* 7:- The stream reader is used to read data from a file using streams. 
               The data from the file is first read into the stream. 
               Thereafter the application reads the data from the stream.
        */

        public static void StreamReader()
        {
            try
            {
                string path = @"D:\C#\FileIO-IOStream\FileIO-IOStream\Files Operation\Ekta.txt";//Set file Location/ Path  
                if (File.Exists(path))
                {
                    using (StreamReader sr = File.OpenText(path)) //method reads a line of characters from the current stream and returns the data as a string. 
                    {
                        string s = "";
                        String line;
                        if ((s = sr.ReadLine()) != null)
                        {
                            line = File.ReadAllText(path);

                            Console.WriteLine(line);
                        }
                        else
                        {
                            Console.WriteLine("Content Not Found"); //print content not foun
                        }
                    }
                }
                else
                {
                    Console.WriteLine("File Not Exist"); //print
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }




    }
}

