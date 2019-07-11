using System;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("42*47=1?74", 9);
            Test("4?*47=1974", 2);
            Test("42*?7=1974", 4);
            Test("42*?47=1974", -1);
            Test("2*12?=247", -1);
            Console.ReadKey(true);
        }

        private static void Test(string args, int expected)
        {
            var result = FindDigit(args).Equals(expected) ? "PASS" : "FAIL";
            Console.WriteLine($"{args} : {result}");
        }
        public static string get_division(string number,string result)
        {
          float num=float.Parse(result)/float.Parse(number);
          string Num=num.ToString();
          return Num;
        }
        public static int get_digit(string Num,string ExpectedNum)
        { int FinalResult=-1;
          if(Num.Length==ExpectedNum.Length)
          { char[] result=Num.ToCharArray();
               char[] problem=ExpectedNum.ToCharArray();
               for(int i=0;i<Num.Length;i++)
               { if(problem[i]=='?')
                 {FinalResult=int.Parse(result[i].ToString());
                 continue;}
                 if(result[i]!=problem[i])
                 { FinalResult=-1;
                   break;
                 }
               }
          }
              return FinalResult;
        }
        public static string get_product(string A,string B)
        { float product=float.Parse(A)*float.Parse(B);
          return product.ToString();

        }

          


        

        public static int FindDigit(string equation)
        {
            // Add your code here.
            int indexOfAsterik=equation.IndexOf('*');
            int indexOfEquals=equation.IndexOf('=');
            string a=equation.Substring(0,indexOfAsterik);
            string b=equation.Substring(indexOfAsterik+1,indexOfEquals-indexOfAsterik-1);
            string c=equation.Substring(indexOfEquals+1);
            int Missing_Digit=-1;
            if(a.Contains('?'))
            { 
              string Num=get_division(b,c);
              Missing_Digit=get_digit(Num,a);
            }
            else if(b.Contains('?'))
            { string Num=get_division(a,c);
              Missing_Digit=get_digit(Num,b);
             
             }
             else
             { string Res=get_product(a,b);
               Missing_Digit=get_digit(Res,c);
             
             }
             return Missing_Digit;
            throw new NotImplementedException();
        }
    }
}
