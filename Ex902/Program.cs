using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex902
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarujemy dwa streamy
            StreamReader sr1 = null;
            StreamWriter sw1 = null;

            try
            {
                System.Console.WriteLine("Blok try");

                //Open files
                sr1 = new StreamReader(File.Open("Tekst1.txt",
                System.IO.FileMode.Open));
                sw1 = new StreamWriter(File.Open("Tekst2.txt",
                System.IO.FileMode.Append,
                FileAccess.Write));

                while (sr1.Peek() != -1)  //kopiujemy linijki kodu
                {
                    sw1.WriteLine(sr1.ReadLine());
                }

                
            }
            catch (Exception e)
            {
                Console.WriteLine("Blok cacth");
                Console.WriteLine(String.Concat(e.Message,
                e.StackTrace));
            }

            finally
            {
                Console.WriteLine("Block finally");
                //zwolnienie zasobów na stremay
                if (sr1 != null)
                {
                    sr1.Close();
                }

                if (sw1 != null)
                {
                    sw1.Close();
                }
            }
            Console.ReadKey();
        }
    }
}
