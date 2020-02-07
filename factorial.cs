using System;
class Factorial
{
    public static int factorial(int num)
    {
        if(num==0)
            return 1;
        return factorial(num-1)*num;
    }
    static void Main()
    {
        int num = Convert.ToInt32(System.Console.ReadLine());
        int fac = Factorial..factorial(num);
        System.Console.writeLine(fac);
        System.ReadKey(true);
    }
}