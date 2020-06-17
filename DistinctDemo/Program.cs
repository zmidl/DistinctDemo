using System;
using System.Collections.Generic;
using System.Linq;

namespace DistinctDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AA> aa = new List<AA> { new AA(0, "0"), new AA(11, "1"), new AA(2, "2") };
            List<AA> bb = new List<AA> { new AA(0, "0"), new AA(11, "1"), new AA(2, "22") };
            aa.AddRange(bb);

            Console.WriteLine("总共有-----");
            foreach (AA item in aa) Console.WriteLine($"{item.A1}--{item.A2}");
            Console.WriteLine("去重后有----");
            foreach (AA item in aa.Distinct()) Console.WriteLine($"{item.A1}--{item.A2}");
            
            Console.ReadLine();
        }
    }

    public class AA : IEquatable<AA>
    {
        public int A1 { get; set; }

        public string A2 { get; set; }

        public AA(int a1, string a2)
        {
            this.A1 = a1;
            this.A2 = a2;
        }

        public bool Equals(AA other)
        {
            return this.A1 == other.A1 && this.A2 == other.A2;
        }

        public override int GetHashCode()
        {
            return this.A1.GetHashCode() ^ this.A2.GetHashCode();
        }
    }
}
