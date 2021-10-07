using System;
using System.IO;

namespace Part41InnerException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter First No:");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Second No:");
                    int b = int.Parse(Console.ReadLine());
                    int c = a / b;
                    Console.WriteLine("Division is={0}",c);

                }
                catch (Exception ex)

                {
                    string filepath = "E:\\New folder\\Data.txt";
                    if (File.Exists(filepath))
                    {
                        StreamWriter writer = new StreamWriter(filepath);
                        writer.Write(ex.GetType().Name);
                        writer.WriteLine();
                        writer.Write(ex.Message);
                        writer.Close();
                        Console.WriteLine("There is a Problem Try Again Later");
                    }
                    else
                    {
                        throw new Exception(filepath + " not found " + ex);

                    }



                }
            }
            catch(Exception exception)
            {
                Console.WriteLine("Current Exception ={0}", exception.GetType().Name);
                Console.WriteLine("Previous Exception ={0}", exception.InnerException);
            }

        }
    }
}
