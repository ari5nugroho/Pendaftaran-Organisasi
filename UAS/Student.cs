using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS
{
    // Kelas Student yang mewarisi dari Person
    public class Student : Person
    {
        public string StudentID { get; set; }
        public List<string> courses = new List<string>();

        // Properti untuk mengakses daftar Organisasi
        public List<string> Courses
        {
            get { return courses; }
        }

        // Method untuk mendaftarkan Organisasi
        public void EnrollCourse(string course)
        {
            courses.Add(course);
        }

        // Method untuk menampilkan informasi mahasiswa
        public override void DisplayInfo()
        {
            Console.WriteLine($"Nama: {Name}, Umur: {Age}, ID Mahasiswa: {StudentID}");
            Console.WriteLine("Organisasi Terdaftar: " + string.Join(", ", Courses));
        }
    }
}
