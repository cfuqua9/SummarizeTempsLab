using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename;
            Console.WriteLine("Enter the filename");
            int threshold;
            int sumtemps = 0;
            int numabove = 0;
            int numbelow = 0;
            //Write out prompt to the console
            
            //prompt user for the filename from console

            //Test whether file exists
            if (true)
            {

            }
            else
            {

            }
            //If the file exists...
            if (File.Exists(filename))
            { Console.WriteLine("File exists");
                Console.WriteLine("")

            }
            else
            {
                Console.WriteLine("File does not exist");

            }
            //ask the user to enter the temperature threshold

            //Open the file and create StreamReader
            int temp;
            //Read a line into a string variable
            using (StreamReader sr = File.OpenText(filename))
            {
                string line;

                while (line !=null)
                {





                    line = StreamReader.ReadLine

                }



            }int average= sumtemps

            //While the line is not null

            //if the current temperature value >= threshold
            if (temp >= threshold) ;

            //Increment the above counter by 1

            //Else (temperature is below)

            //Increment the below counter by 1
        }
    }
}
