using System;

namespace AddingColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a 3 digit number");
            string input1 = Console.ReadLine();
            Console.WriteLine("please enter a second 3 digit number");
            string input2 = Console.ReadLine();

            //User Input Validation
            bool tryAgain = true;
            while (tryAgain == true)
            {
                tryAgain = false;
                while (input1.Length != 3)
                {
                    Console.WriteLine("Your first number is not three digits long, please re-enter your first number");
                    input1 = Console.ReadLine();
                    tryAgain = true;
                }
                while (input2.Length != 3)
                {
                    Console.WriteLine("Your second number is not three digits long, please re-enter your second number");
                    input2 = Console.ReadLine();
                    tryAgain = true;
                }
                int i = 0;
                bool canConvert1 = Int32.TryParse(input1, out i);
                while (canConvert1 == false)
                {
                    Console.WriteLine("Your first input was not a number, please re-enter your first number");
                    input1 = Console.ReadLine();
                    canConvert1 = Int32.TryParse(input1, out i);
                    tryAgain = true;
                }
                bool canConvert2 = Int32.TryParse(input2, out i);
                while (canConvert2 == false)
                {
                    Console.WriteLine("Your Second input was not a number, please re-enter your second number");
                    input2 = Console.ReadLine();
                    canConvert2 = Int32.TryParse(input2, out i);
                    tryAgain = true;
                }
            }
            

            //CONVERTING TO ARRAYS
            Console.WriteLine("Do your number columns add to the same amount?");
            var inputArr1 = input1.ToCharArray();
            var inputArr2 = input2.ToCharArray();
            int[] intInputArr1 = Array.ConvertAll(inputArr1, c => (int)Char.GetNumericValue(c));
            int[] intInputArr2 = Array.ConvertAll(inputArr2, c => (int)Char.GetNumericValue(c));
            Console.WriteLine(inputArr1[0] + inputArr2[0] == inputArr1[1] + inputArr2[1] && inputArr1[1] + inputArr2[1] == inputArr1[2] + inputArr2[2]);
            Console.ReadLine();




            //Console.WriteLine(inputArr1);
            //for (int i=0; i>inputArr1.Length; i++)
            //{

            //}
            //return X1 + Y1 == X2 + Y2 == X3 + Y3;
            //Console.ReadLine();
        }
    }
}

//TryParse(input1, Int32);
//do while loops. while they are in error, tell them what is wrong, and have them re-enter the data.
//class myClass
//{
//    private bool verifyNums(string input1, string input2)
//    {
//        return input1.Length == input2.Length;
//    }

//}


//ask for user input twice
//confirm they are the same length with string.length.
//if false give error message
//if true...
//convert input string tochararray
//[x1,x2,x3]
//convert to ints
//return((x1 + y1) == (x2 + y2)
