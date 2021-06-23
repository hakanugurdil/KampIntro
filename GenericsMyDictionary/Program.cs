using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> MyDictionary1 = new MyDictionary<int, string>();
            MyDictionary1.Add(22, "Hakan");
            MyDictionary1.Add(01, "Adana");
            MyDictionary1.Add(33, "Mersin");
            Console.WriteLine(MyDictionary1.Count);
            Console.ReadLine();
        }
    }
}
