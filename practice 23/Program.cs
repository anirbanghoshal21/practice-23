using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double geo, eng, bio, total;
            double per;
            string div;

            Console.Write("\n\n");
            Console.Write("Calculate the total, percentage and division to take marks of three subjects:\n");
            Console.Write("-------------------------------------------------------------------------------");
            Console.Write("\n\n");



            Console.Write("Input  the marks of Geography : ");
            geo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of  English : ");
            eng = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of Biology : ");
            bio = Convert.ToInt32(Console.ReadLine());

            total = geo + eng + bio;
            per = total / 3.0;
            if (per >= 60)
                div = "First";
            else
                if (per < 60 && per >= 45)
                div = "Second";
            else
                    if (per < 45 && per >= 35)
                div = "Pass";
            else
                div = "Fail";

            Console.Write("Marks in Geography : {0}\nMarks in English : {1}\nMarks in Biology : {2}\n", geo, eng, bio);
            Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n", total, per, div);

            Console.ReadLine();
        }
    }
}
