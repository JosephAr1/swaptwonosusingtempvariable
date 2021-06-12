using System;

namespace swaptwonosusingtempvariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            
            Console.WriteLine("Enter the number for num1:" );
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number for num2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swapping num1 = {0} and num2 = {1}",num1,num2);

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After Swapping num1 = {0} and num2 = {1}", num1, num2);
            Console.WriteLine("Press any Key to exit");
            Console.ReadKey();

        }
    }
}
