using System;

namespace Exception_objectOfObject
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int x = 10;
                int y = 0;

                int result = x / y;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
