using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace nAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int nAge;
            int tLahir;
            int tLahir1;
            Console.WriteLine("Program UMUR ehehe");
            Console.Write("Masukan Umur Anda: ");
            nAge = Convert.ToInt32(Console.ReadLine());

            tLahir = 2020 - nAge;
            tLahir1 = 2021 - nAge;


            if ((nAge >= 5) && (nAge <= 12))
            {
                Console.WriteLine("Anda di masa anak-anak");
                Console.WriteLine("Tahun Kelahiran " + tLahir + "/" + tLahir1);
            }
            else if ((nAge >=13) && (nAge <= 19))
            {
                Console.WriteLine("Anda di masa remaja");
                Console.WriteLine("Tahun Kelahiran " + tLahir + "/" + tLahir1);
            }
            else if ((nAge >= 20) && (nAge <= 35))
            {
                Console.WriteLine("Anda mulai dewasa");
                Console.WriteLine("Tahun Kelahiran " + tLahir + "/" + tLahir1);
            }
            else if ((nAge >= 36) && (nAge <= 45))
            {
                Console.WriteLine("Anda sudah dewasa");
                Console.WriteLine("Tahun Kelahiran " + tLahir + "/" + tLahir1);
            }
            else if ((nAge >= 46) && (nAge <= 55))
            {
                Console.WriteLine("Anda mulai tua");
                Console.WriteLine("Tahun Kelahiran " + tLahir + "/" + tLahir1);
            }
            else if (nAge >= 56)
            {
                Console.WriteLine("Anda Sepuh");
                Console.WriteLine("Tahun Kelahiran " + tLahir + "/" + tLahir1);
            }
            Console.ReadLine();
        }
    }
}
