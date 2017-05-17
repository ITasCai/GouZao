using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GouZao
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("张三",20,"男");
            Console.WriteLine(student.ToString()); 

            Console.ReadLine();
        }
    }
}
