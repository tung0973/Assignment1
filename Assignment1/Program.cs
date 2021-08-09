using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username :");
            string userName = Console.ReadLine();
            
            Console.WriteLine("Username is : " + userName);

            
            Console.WriteLine("Choose What To Do : ");
            Console.WriteLine("1. Adminitrative changes");
            Console.WriteLine("2. List Of Branches ");

            int ten;
            ten = Int32.Parse(Console.ReadLine());

            switch (ten)
            {
                case 1:
                    Console.WriteLine("At the start of the 2002-2003 school year, co-principals Boaz Kita'in and Diana Shaloufi-Rizek were replaced by new principals after a careful selection process made during the previous school year and preparation made during the summer.");
                    break;
                case 2:
                    Console.WriteLine("APAX LEADERS - Luong Yen Tang 3, Sun Grand Ancora City, 3 Lương Yên · In Sun Grand City Ancora Residence · 1900 636056Closed ⋅ Opens 10AM Tue");
                    Console.WriteLine("PoPoDoo Vietnam Education JSCNo reviews · Language school --- 468 Thụy Khuê · 024 6251 4444");
                    break;
            }
        }
    }
}
