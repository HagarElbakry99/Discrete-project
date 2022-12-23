using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter start number = ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end number = ");
            int end = int.Parse(Console.ReadLine());
            for(int i=start;i<=end;i++)
            {
                int j;
                for(j=2;j<=i;j++)
                {
                    if (i % j == 0)
                        break;
                }
                if (j == i)
                    Console.WriteLine(i +" Prime number ");
            }
        }
    }
}
