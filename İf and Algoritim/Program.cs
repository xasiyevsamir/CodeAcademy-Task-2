using System.Security.Cryptography;

namespace İf_and_Algoritim;

class Program
{
    static void Main(string[] args)
    {

        //Verilmish ededin menfi ve ya musbet oldugunu tapan algorithm

        //int number = 78;

        //if (number > 0)
        //    Console.WriteLine($"Musbet eded: {number}");
        //else
        //    Console.WriteLine($"Menfi eded: {number}");










        //Verilmish ededin hem 3-e hem de 7-e tam bolunub bolunmediyini tapan algorithm

        //int data1 = 21;

        //if (data1 % 3 == 0 && data1 % 7 == 0)
        // Console.WriteLine($"Eded 3 ve 7 tam bolunur.");       
        //else
        // Console.WriteLine("Eded 3 ve 7 tam bolunmur.");






        //Verilmish 2 mertebeli ededin en boyuk reqemini tapan algorithm misal: input 25, output 5

        int data = 98, temp = 0, num;

        while (data > 0)
        {
            num = data % 10;

            if (num > temp)
                temp = num;
            data /= 10;
        }
        Console.WriteLine(temp);
    }
}
