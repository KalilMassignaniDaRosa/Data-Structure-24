using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_Class
{
    public class Person
    {
        public string _location = string.Empty;

        public string Name { get; set; }
        public int Age { get; set; }

        // Metodo Construtor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person()
        {
            Name = "-----";
        }

        // Metodo para realocar a pessoa
        public void Realocate(String loc)
        {
            if (!string.IsNullOrEmpty(loc))
            {
                _location = loc;
            }
        }

        public float GetDistance(string loc)
        {
            return 0;
        }
    }
}