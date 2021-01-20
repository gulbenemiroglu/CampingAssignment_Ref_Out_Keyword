using System;

namespace AssignmentDay3
{
    class Program
    {
        static void Main(string[] args)
        {
            // REF KEYWORD
            int number1 = 20; 
            int number2 = 100;
            
            var resultForRef = AddForRef(ref number1, number2);


            Console.WriteLine(resultForRef);   // result=130
            //Console.WriteLine(number1);  // ref kullanmasaydık number1=20 olurdu ancak ref kullandığımızda number1=30 olur.


            //OUT KEYWORD

            int number3;
            int number4 = 50;

            var resultForOut = AddForOut(out number3, number4);

            Console.WriteLine(resultForOut);   // result=150
        }

        static int AddForRef (ref int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int AddForOut(out int number3, int number4)
        {
            number3 = 100;
            return number3 + number4;
        }
    }
}
