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

        static void tambahBuku()
        {
            Console.Clear();
            Console.WriteLine("=== Tambah Buku ===");

            Console.Write("Judul: ");
            string judul = Console.ReadLine();

            Console.Write("Penulis: ");
            string penulis = Console.ReadLine();

            Console.Write("Tahun terbit: ");
            int tahun = int.Parse(Console.ReadLine());

            Console.WriteLine("\nJenis buku");
            Console.WriteLine("1. Fiksi");
            Console.WriteLine("2. Non-Fiksi");
            Console.WriteLine("3. Majalah");
            Console.Write("Masukan pilihan: ");
            string jenisPilihan = Console.ReadLine();

            string pilihan = "";
            if (jenisPilihan == "1")
                pilihan = "Fiksi";
            else if (jenisPilihan == "2")
                pilihan = "Non-Fiksi";
            else if (jenisPilihan == "3")
                pilihan = "Majalah";
            else
                pilihan = "Lain-lain";

            judulBuku.Add(judul);
            penulisBuku.Add(penulis);
            tahunTerbit.Add(tahun);
            jenisBuku.Add(pilihan);

            Console.WriteLine("\nBuku berhasil ditambahkan!!");
        }

        static void ubahData()
        {
            Console.Clear();
            Console.WriteLine("=== Ubah Data Buku ===");

            if (judulBuku.Count == 0)
            {
                Console.WriteLine("Belum ada buku yang terdaftar!");
                return;
            }

            for (int i = 0; i < judulBuku.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {judulBuku[i]}");
            }

            Console.Write("\nPilih Nomer");
            int index = int.Parse(Console.ReadLine()) - 1;
        }
    }
}