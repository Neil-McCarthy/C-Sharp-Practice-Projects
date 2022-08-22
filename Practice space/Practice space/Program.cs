using System;
//REQUIRED FOR DECLARING ARRAYLIST
using System.Collections;
using System.Collections.Generic;

namespace Practice_space
{
    class Program
    {
        static void Main(string[] args)
        {

            //NON-GENERIC COLLECTIONS
            int num1 = 5;
            float num2 = 3.14f;
            string name = "Name";
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(num1);
            myArrayList.Add(num2);
            myArrayList.Add(name);
            
            foreach (object index in myArrayList)
            {
                Console.Write(index + " ");
                Console.WriteLine(index.GetType());
            }
            myArrayList.RemoveAt(0);
            foreach (object index in myArrayList)
            {
                Console.Write(index + " ");
                Console.WriteLine(index.GetType());
            }
            myArrayList.Remove("Name");
            foreach (object index in myArrayList)
            {
                Console.Write(index + " ");
                Console.WriteLine(index.GetType());
            }

            //GENERIC COLLECTION
            var numbers = new List<int>();
            for (int index = 100; index < 171; index += 2)
            {
                numbers.Add(index);
            }
            foreach (int index2 in numbers)
            {
                Console.WriteLine(index2);
            }
            Console.ReadLine();
        }
    }
}