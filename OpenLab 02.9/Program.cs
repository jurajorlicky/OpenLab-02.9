using System;

namespace OpenLab_02._9
{
    class Program
    {
        public static string menopriezvisko(string firstname, string lastname)
        {
            return (lastname + " , " + firstname);
        }
        static void Main(string[] args)
        {
            string firstname = "Juraj";
            string lastname = "Orlický";
            Console.WriteLine(menopriezvisko(firstname, lastname));
        }
    }
}
