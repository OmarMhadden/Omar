using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainShit3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program PRGM = new Program();
            Console.WriteLine(PRGM.LikeStartLikeEnd(""));
            Console.WriteLine(PRGM.ToUpperCase(""));
            Program.Pyramid();
            Console.ReadKey();
        }
        public bool LikeStartLikeEnd(string s)
        {
            bool q = false;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = s.Length - i - 1 ; j > 0; j--)
                {
                    if (s[i].ToString().Equals(s[j].ToString()))
                    {
                        q = true;
                        break;
                    }
                    else 
                    {
                        q = false;
                        break;
                    }

                }
                if(q == false)
                {
                    break;
                }
            }
            return q;
        }
        public string ToUpperCase(string s)
        {
            string TheReturnedS = "";
            string a = "a";
            string e = "e";
            string u = "u";
            string i = "i";
            string o = "o";

            for (int q = 0; q < s.Length; q++)
            {
                if (s[q].ToString().Contains(a) || s[q].ToString().Contains(e) || s[q].ToString().Contains(u) || s[q].ToString().Contains(i) || s[q].ToString().Contains(o))

                {
                    TheReturnedS += s[q].ToString().ToUpper();
                }
                else
                {
                    TheReturnedS += s[q].ToString();
                }
            }

            return TheReturnedS;
        }

        static void Pyramid()
        {
            string Sharp = "#";
            //Sharp = "5";  ** Fives are cool beleive me ~
            //Sharp = "~";  ** ~s are smooth ~
            //Sharp = "01";
           int Length = int.Parse(Console.ReadLine());


            for (int i = 0; i < Length ; i++)
            {
                for (int k = i; k < Length - 1 ; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(Sharp);
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(Sharp);
                }
                for (int k = i; k < Length - 1; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
            for (int i = Length; i > 0; i--)
            {                
                for (int k = Length; k > i  ; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(Sharp);
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(Sharp);
                }
                for (int k = Length; k > i; k--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
           

        }
        
    }
}
