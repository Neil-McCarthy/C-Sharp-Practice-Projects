using System;

namespace Practice_space
{
    class Program
    {
        static void Main(string[] args)
        {

            //PARAMS

            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "The Lord of the Rings";
            ParamsMethod("this", "here", "is", "for sure", "a", "big", "long", "damn", "useless", "monkey", "string");
            ParamsMethod2(price, pi, at, book);
            ParamsMethod2("Hello", 5.3, '%');
            Console.ReadLine();
        }

        public static void ParamsMethod(params string[] sentence)
        {
            for (int index = 0; index < sentence.Length; index++)
            {
                Console.Write(sentence[index] + " ");
            }
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            foreach (object obj in stuff)
            {
                Console.Write(obj + " ");
            }
        }
    }
}