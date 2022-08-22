using System;
//REQUIRED FOR DECLARING ARRAYLIST
using System.Collections;

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

            Console.ReadLine();
        }
    }
}