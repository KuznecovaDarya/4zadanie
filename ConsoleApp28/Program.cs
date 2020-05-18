using System;
using static System.Convert;
using static System.Console;
using System.Collections;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add('y');
            list.Add(-3);
            list.Add('H');
            list.Add(55);
            list.Add(-44);
            list.Add('E');
            list.Add(-2);
            list.Add(11);
            list.Add('h');
            list.Add(7);
            list.Add(-6);
            list.Add('L');
            list.Add(-13);
            list.Add('P');

            ArrayList list2 = new ArrayList();
            WriteLine("Числа: ");
            for (int i = 0; i < list.Count; i++)
            {
                int g = 0;
                string s = list[i]+"";
                bool rez = int.TryParse(s, out g); ;

                if (rez == false)
                {
                    if (s==s.ToUpper())
                    {
                        list2.Add(list[i]);
                        list.RemoveAt(i);
                    }
                    else list.RemoveAt(i);
                }
            }
            foreach (object o in list)
            {
                WriteLine(o);
            }
            WriteLine("Заглавные буквы: ");
            foreach (object o in list2)
            {
                WriteLine(o);
            }
            ReadLine();
        }
    }
}
