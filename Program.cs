using System;
using System.Collections.Generic;


namespace libraryManagement
{
    class program
    {
        static List<string> judulBuku = new List<string>();
        static List<string> penulisBuku = new List<string>();
        static List<int> tahunTerbit = new List<int>();
        static List<string> jenisBuku = new List<string>();
        static List<bool> statusPinjam = new List<bool>();
        static List<string> bukuDipinjam = new List<string>();

        static void Main()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("==== Welcome to Library ===");
                Console.WriteLine("1. Tambah buku");
                Console.WriteLine("2. Ubah data buku");
                Console.WriteLine("3. Melihat semua buku");
                Console.WriteLine("4. Pinjam buku");
                Console.WriteLine("5. Kembalikan buku");
                Console.WriteLine("6. Lihat buku yang dipinjam");
                Console.WriteLine("7. Exit");
                Console.Write("MAsukan pilihan: ");

                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        tambahBuku();
                        break;
                    case "2":
                        ubahData();
                        break;
                    case "3":
                        melihatAllBuku();
                        break;
                    case "4":
                        pinjamBuku();
                        break;
                    case "5":
                        kembalikanBuku();
                        break;
                    case "6":
                        lihatBukudiPinjam();
                        break;
                    case "7":
                        running = false;
                        Console.WriteLine("\nTerima Kasih");
                        break;
                }
                if (running)
                {
                    Console.WriteLine("\nTekan Enter...");
                    Console.ReadLine();
                }
            }
        }
    }
}