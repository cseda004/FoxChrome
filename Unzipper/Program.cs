using System;
using System.IO;
using System.Collections;

namespace unzipper
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arguments = Environment.GetCommandLineArgs();


            string function = "";
            string zipPath = "";  // Path of zipped file
            string unzipped = "";  // Path of unzipped file


            try
            {
                function = arguments[1];            
                zipPath = arguments[2];  // Path of zipped file
                unzipped = arguments[3];  // Path of unzipped file
            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.WriteLine("Error: Missing parameters");
                Environment.Exit(1);
            }
            catch (System.IO.IOException ee)
            {
                // Console.WriteLine(ee);
                Environment.Exit(1);
            }
           





            if (function.ToLower().Trim() == "c" || function.ToLower().Trim() == "compress")
            {


                try
                {
                    System.IO.Compression.ZipFile.CreateFromDirectory(zipPath, unzipped); // Add references System.IO.Compression and System.IO.Compression.FileSystem
                }
                catch (System.IO.FileNotFoundException e)
                {
                    Console.WriteLine("File not found!");
                }
                catch (System.IO.IOException ee)
                {
                    Console.WriteLine(ee);
                }



            }
            else if (function.ToLower().Trim() == "e" || function.ToLower().Trim() == "extract")
            {

                try
                {
                    System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, unzipped); // Add references System.IO.Compression and System.IO.Compression.FileSystem
                }
                catch (System.IO.FileNotFoundException e)
                {
                    Console.WriteLine("File not found!");
                }
                catch (System.IO.IOException ee)
                {
                    Console.WriteLine(ee);
                }


            }
            else {
                Console.WriteLine("Invalid function!");
            }
            

        

        }
    }
}