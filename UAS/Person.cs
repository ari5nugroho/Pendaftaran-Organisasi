using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS
{
    // Kelas abstrak Person sebagai dasar untuk kelas Student dan PartTimeStudent
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Method abstrak untuk menampilkan informasi
        public abstract void DisplayInfo();
    }
}
