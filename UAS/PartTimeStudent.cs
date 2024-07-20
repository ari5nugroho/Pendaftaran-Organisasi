using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS
{
    // Kelas PartTimeStudent yang mewarisi dari Student
    public class PartTimeStudent : Student
    {
        public string WorkingHours { get; set; }
        public string EndWorkingHours { get; set; }
        public string Hari { get; set; }

        // Method untuk menampilkan informasi mahasiswa paruh waktu
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Jam Kerja: {WorkingHours} - {EndWorkingHours}");
            Console.WriteLine($"Hari PartTime: {Hari}");
        }
    }
}
