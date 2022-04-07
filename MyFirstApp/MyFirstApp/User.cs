using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class User
    {
        public string name { get; set; }
        public int age { get; set; }

        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public User()
        {

        }

        public void getDetails()
        {
            Console.WriteLine($"My name is {this.name} and my age is {this.age}");
        }

        public void getAction()
        {
            Console.WriteLine($"{this.name} is Runnig");
        }
    }
}
