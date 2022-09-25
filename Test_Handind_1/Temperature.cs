using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Handind_1
{
    public static class Temperature
    {
        public static void Main()
        {
            Console.WriteLine("To convert Celsius to Fahrenheit press 1 followed by 'enter' \n to convert Fahrenheit to Celcius press 2 followed by 'enter'");
            string choice = Console.ReadLine();



            switch (choice)
            {
                case "1":
                    Console.WriteLine("enter the Celcius value you want converted:");
                    float cel = float.Parse(Console.ReadLine());
                    Console.WriteLine("converted val: " + cToF(cel));


                    break;

                case "2":
                    Console.WriteLine("enter the fahrenheit value you want converted:");
                    float fahr = float.Parse(Console.ReadLine());
                    Console.WriteLine("converted val: " + fToC(fahr));
                    break;
            }


        }



        public static float fToC(float f)
        {


            return (f - 32f) * 0.5556f;

        }


        public static float cToF(float c)
        {
            return (c * 1.8f) + 32f;


        }
    }
}
