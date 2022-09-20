using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace ekzKD
{
    //критический путь это наибольшая продолжительность
    //значения i, j, dayij, maxday (ответ)
    
    internal class Program
    {
        class Znach
        {
            
        }


        public static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int day = 0;
            string[] file_name = File.ReadAllLines("krit_puti.txt");
                for (int t = 0; t < file_name.Length; t++)
                {
                    if (t == 0)
                    {
                        iz = Convert.ToInt32(file_name[0]);
                    }
                    if (t == 1)
                    {
                        jz = Convert.ToInt32(file_name[t]);
                    }
                    if (t == 2)
                    {
                        dayz = Convert.ToInt32(file_name[t]);
                    }
                }

            Console.WriteLine(i);
            Console.ReadLine();

            int[] I = new int[i.ToString().Length];
            for (int t = 0; t < I.Length; t++)
            {
                I[t] = i % 10;
                i /= 10;
            }
            Array.Reverse(I);

            int maxJ = 0;
            int[] J = new int[j.ToString().Length];
            for (int t = 0; t < J.Length; t++)
            {
                J[t] = j % 10;
                j /= 10;
                if (maxJ < J[t])
                {
                    maxJ = J[t];
                }
            }
            Array.Reverse(J);
            //Console.WriteLine(maxJ);

            int[] Day = new int[day.ToString().Length];
            for (int t = 0; t < Day.Length; t++)
            {
                Day[t] = day % 10;
                day /= 10;
            }
            Array.Reverse(Day);
            //for (int t = 0; t < I.Length; t++)
            //{
            //    Console.WriteLine(I[t]);
            //}


            Console.ReadKey();
        }
        
    }
}
