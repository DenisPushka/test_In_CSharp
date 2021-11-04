using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

class Program
{
    public static void Main()
    {
        Kata.FindShort("bitcoin take over the world maybe who knows perhaps");
        Kata.FindShort("turns out random test cases are easier than writing out basic ones");
        Kata.FindShort("Let's travel abroad shall we");
    }
    public class Kata
    {
        public static int FindShort(string str)
        {
            return str.Split().Min(x => x.Length);
        }

    }

}