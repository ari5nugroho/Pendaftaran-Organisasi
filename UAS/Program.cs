using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UAS
{
    public class Program
    {
        // Daftar untuk menyimpan siswa
        static List<Student> students = new List<Student>();

        // Fungsi utama untuk menjalankan program
        static void Main(string[] args)
        {
            bool keluar = false;
            while (!keluar)
            {
                Console.WriteLine("=== Sistem Manajemen Mahasiswa ===");
                Console.WriteLine("1. Tambah Mahasiswa");
                Console.WriteLine("2. Tampilkan Semua Mahasiswa");
                Console.WriteLine("3. Daftarkan Organisasi");
                Console.WriteLine("4. Keluar");
                Console.WriteLine("==================================");
                Console.Write("Pilih opsi: ");
                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        TambahMahasiswa();
                        break;
                    case "2":
                        TampilkanSemuaMahasiswa();
                        break;
                    case "3":
                        DaftarkanOrganisasi();
                        break;
                    case "4":
                        keluar = true;
                        break;
                    default:
                        Console.WriteLine("Opsi tidak valid. Silakan coba lagi.");
                        break;
                }
            }
            Console.ReadKey();
        }

        // Fungsi untuk menambah mahasiswa baru
        static void TambahMahasiswa()
        {
            Console.WriteLine();
            Console.Write("Masukkan Nama Mahasiswa: ");
            string nama = Console.ReadLine();
            Console.Write("Masukkan Umur Mahasiswa: ");
            int umur = int.Parse(Console.ReadLine());
            Console.Write("Masukkan ID Mahasiswa: ");
            string studentID = Console.ReadLine();
            Console.Write("Apakah ini mahasiswa paruh waktu? (ya/tidak): ");
            string isPartTime = Console.ReadLine().ToLower();

            if (isPartTime == "ya")
            {
                PartTimeStudent mahasiswaParuhWaktu = new PartTimeStudent();
                mahasiswaParuhWaktu.Name = nama;
                mahasiswaParuhWaktu.Age = umur;
                mahasiswaParuhWaktu.StudentID = studentID;
                Console.Write("Hari PartTime: ");
                mahasiswaParuhWaktu.Hari = Console.ReadLine();
                Console.Write("Masukkan Jam Kerja (mm.hh): ");
                mahasiswaParuhWaktu.WorkingHours = Console.ReadLine();
                Console.Write("Sampai Jam (mm.hh): ");
                mahasiswaParuhWaktu.EndWorkingHours = Console.ReadLine();
                students.Add(mahasiswaParuhWaktu);
            }
            else
            {
                Student mahasiswa = new Student();
                mahasiswa.Name = nama;
                mahasiswa.Age = umur;
                mahasiswa.StudentID = studentID;
                students.Add(mahasiswa);
            }
            Console.WriteLine("Mahasiswa berhasil ditambahkan!");
            Console.WriteLine();
        }

        // Fungsi untuk menampilkan semua mahasiswa
        static void TampilkanSemuaMahasiswa()
        {
            foreach (var student in students)
            {
                Console.WriteLine();
                student.DisplayInfo();
                Console.WriteLine();

            }
        }

        // Fungsi untuk mendaftarkan Organisasi untuk seorang mahasiswa
        static void DaftarkanOrganisasi()
        {
            Console.WriteLine();
            Console.Write("Masukkan ID Mahasiswa: ");
            string studentID = Console.ReadLine();
            Student mahasiswa = students.Find(s => s.StudentID == studentID);
            if (mahasiswa != null)
            {
                Console.Write("Masukkan Nama Organisasi: ");
                string kursus = Console.ReadLine();
                mahasiswa.EnrollCourse(kursus);
                Console.WriteLine("Organisasi berhasil didaftarkan!");
            }
            else
            {
                Console.WriteLine("Mahasiswa tidak ditemukan.");
            }
            Console.WriteLine();
        }
    }
}
