using System.Security.Cryptography;

namespace İf_and_Algoritim;

class Program
{
    static void Main(string[] args)
    {


        //A(20);
        //B(21);
        C(46498567);

    }


    static void A(int number)
    {
        //Verilmish ededin menfi ve ya musbet oldugunu tapan algorithm

        if (number > 0)
            Console.WriteLine($"Musbet eded: {number}");
        else
            Console.WriteLine($"Menfi eded: {number}");
    }





    static void B(int number)
    {
        //Verilmish ededin hem 3-e hem de 7-e tam bolunub bolunmediyini tapan algorithm

        if (number % 3 == 0 && number % 7 == 0)
            Console.WriteLine($"{number} ededi 3 ve 7 tam bolunur.");
        else
            Console.WriteLine($"{number} ededi 3 ve 7 tam bolunmur.");
    }



    static void C(int number)
    {
        //Verilmish 2 mertebeli ededin en boyuk reqemini tapan algorithm misal: input 25, output 5

        int temp = 0, residue, data = number;

    l1: if (number > 0)
        {
            residue = number % 10;
            number /= 10;
            if (residue > temp)
                temp = residue;
            goto l1;
        }
        Console.WriteLine($"{data} ededinin en boyuk reqemi:{temp}");
    }

}
