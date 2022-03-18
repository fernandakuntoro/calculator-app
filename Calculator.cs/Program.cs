using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calkulator";

        menu:
            Console.WriteLine("=====SELAMAT DATANG===== ");
            Console.WriteLine("1.Penambahan");
            Console.WriteLine("2.Pengurangan");
            Console.WriteLine("3.Perkalian");
            Console.WriteLine("4.Pembagian");
            Console.WriteLine("5.Exit");
            Console.WriteLine("========================");

            Console.Write("Masukan Angka Pilihan Anda = ");
            float pilihan = float.Parse(Console.ReadLine());
            Console.ReadKey();
            Console.Clear();

            if (pilihan == 1)
            {
                Console.WriteLine();
                Console.Write("Masukan Nilai Pertama = ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Masukan Nilai Kedua = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));

                Console.WriteLine("\nTekan Sembarang key untuk keluar");
                Console.ReadKey();
                Console.Clear();
                goto menu;
            }
            else if (pilihan == 2)
            {
                Console.WriteLine();
                Console.Write("Masukan Nilai Pertama = ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Masukan Nilai Kedua = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));

                Console.WriteLine("\nTekan Sembarang key untuk keluar");
                Console.ReadKey();
                Console.Clear();
                goto menu;
            }
            else if (pilihan == 3)
            {
                Console.WriteLine();
                Console.Write("Masukan Nilai Pertama = ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Masukan Nilai Kedua = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));

                Console.WriteLine("\nTekan Sembarang key untuk keluar");
                Console.ReadKey();
                Console.Clear();
                goto menu;
            }
            else if (pilihan == 4)
            {
                Console.WriteLine();
                Console.Write("Masukan Nilai Pertama = ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Masukan Nilai Kedua = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));

                Console.WriteLine("\nTekan Sembarang key untuk keluar");
                Console.ReadKey();
                Console.Clear();
                goto menu;
            }
            else if (pilihan == 5)
            {
                Console.WriteLine();
                Console.WriteLine("\tTHANKS YOU");
                Console.WriteLine("==========================");
                Console.WriteLine("\n Tekan sembarang untuk keluar!!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\n Pilihan Anda Tidak Tersedia Tekan Sembarang Untuk kembali");
                Console.ReadKey();
                Console.Clear();
                goto menu;

            }
        }
    }
}