using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_space
{
    class Human
    {
        //member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        //constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}. My eyes are {2} and I am {3} years old.", firstName, lastName, eyeColor, age);
        }
    }
}
