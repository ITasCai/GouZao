using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GouZao
{
    class Student
    {
        private string name;
        private int age;
        private string sex;

        public Student(string name,int age,string sex) {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public override string ToString()
        {
            return "姓名;" + name + ",年龄：" + age + ",性别：" + sex;
        }
    }
}
