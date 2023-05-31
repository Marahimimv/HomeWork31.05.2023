using System.Threading.Channels;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 34;
            string b = "ads";
            string c = "1sgag11jd";
            Console.WriteLine(Extensions.IsOdd(a));
            Console.WriteLine(Extensions.IsEven(a));
            Console.WriteLine(Extensions.IsContains(b));
            Console.WriteLine(Extensions.GetValueIndexes(c,'1'));

        }



    }
}


