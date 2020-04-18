using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace aspnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var p = new Program();
            p.Test();
            string full = p.FullName("art", "lemus");
            Console.WriteLine(full);
            p.Exc1();
            p.oddNumbers();

        }


        void oddNumbers()
        {

            int i = 0;

            int[] numbers = new int[11];
            
            System.Console.WriteLine("numbers in the array: ");

            for (i = 1; i < numbers.Length; i++)
            {
                Console.WriteLine(i);

            }

            Console.WriteLine("the odd numbers are: ");
            for (i = 1; i < numbers.Length; i++)
            {


                if (i % 2 != 0)

                    Console.Write(i);

            }








        }



        void Exc1()
        {
            // var numbers = new List<int>();
            // //10 20 .. 1000
            // for (int i = 1; i < 101;i++){
            //     numbers.Add(i * 100);



            // }
            // Console.WriteLine(numbers);

            // var sum = 0;
            // foreach(int num in numbers){
            //     if (num > 40)
            //     {


            //         sum += num;
            //     }
            // }

            // // for (int j = 0; j < numbers.Count;j++){
            // //     sum += numbers[j];
            // // }
            // System.Console.WriteLine("total: " +sum);






            NoReturns();



        }

        void NoReturns()
        {
            System.Console.WriteLine("test");

            // types of variables
            string name = "art";
            int age = 99;
            bool found = false;
            float f = 123.123f;
            decimal d = 123.123m;
            // parse string into int
            string n = "98";
            int res = int.Parse(n);

            string[] names = new string[100];
            names[0] = "art";
            names[1] = "123123";
            names[6] = "asdkaj";

            //string[][] cube = new string[99] [];
            List<string> list = new List<string>();
            list.Add("artartart");
            System.Console.WriteLine("from array: " + name[0]);
            System.Console.WriteLine("from list: " + list[0]);

        }

        string FullName(string first, string last)
        {
            return first + " " + last;
        }

        int Test()
        {
            Console.WriteLine("first method");
            return 1;
        }
    }
}
