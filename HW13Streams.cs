using System;

using System.IO;

namespace HW13Streams

{

    class HW13Streams

    {

        static void Main()

        {

            string readPath = @"C:\Users\Drewr\Desktop\in.txt";

            string writePath = @"C:\Users\Drewr\Desktop\out.txt";

            try

            {

                string[] lines = File.ReadAllLines(readPath);

                using (StreamWriter sw = File.AppendText(writePath))

                {

                    foreach (string line in lines)

                    {

                        sw.WriteLine(line.ToUpper());

                    }

                }

            }

            catch (IOException e)

            {

                Console.WriteLine("An error occurred");

                Console.WriteLine(e.Message);

            }

        }

    }

}
