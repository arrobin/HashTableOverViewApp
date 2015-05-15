using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableOverViewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myHashtable = new Hashtable();

            myHashtable.Add("Key", "Value");
            myHashtable.Add("Bitm", 10001);
            myHashtable.Add(10, 201);

            myHashtable[1010] = 1;
            Console.WriteLine(myHashtable[1010]);
            myHashtable[1010] = 2;

            Console.WriteLine(myHashtable[1010]);
            Console.WriteLine(myHashtable.Count);
            Console.WriteLine(myHashtable.Contains("Key"));

            Console.ReadKey();
        }
    }
}
