using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Teacher
    {
        public string Name { get; set; } = "";  // FIXED WARNING

        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English.");
        }

        public void SalaryInfo()
        {
            Console.WriteLine("Teacher salary depends on experience.");
        }
    }
}
