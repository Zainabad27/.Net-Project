using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zainProject
{
    public static class CommonOutputText
    {
        private static string MainHeading
        {
            get {
                string MainHeading = "Cyclic Club";
                return $"{MainHeading}\n{new string('-',MainHeading.Length)}";
            }
        }
        private static string RegisterHeading
        {
            get {
                string MainHeading = "Cyclic Club Registeration";
                return $"{MainHeading}\n{new string('-',MainHeading.Length)}";
            }
        }
        private static string LoginHeading
        {
            get {
                string MainHeading = "Cyclic Club Login";
                return $"{MainHeading}\n{new string('-',MainHeading.Length)}";
            }
        }


         public static void WriteMainHeading()
        {
            Console.Clear();
            Console.WriteLine(MainHeading);
            Console.WriteLine();
            Console.WriteLine();

        }
         public static void WriteRegisterHeading()
        {
            Console.Clear();
            Console.WriteLine(RegisterHeading);
            Console.WriteLine();
            Console.WriteLine();

        }
         public static void WriteLoginHeading()
        {
            Console.Clear();
            Console.WriteLine(LoginHeading);
            Console.WriteLine();
            Console.WriteLine();

        }

    }
}
