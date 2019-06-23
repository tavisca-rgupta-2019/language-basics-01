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

        public static int FindDigit(string equation)
        {
            // Add your code here.
            int i1=equation.IndexOf('*');
            int i2=equation.IndexOf('=');
            string a=equation.Substring(0,i1);
            string b=equation.Substring(i1+1,i2-i1-1);
            string c=equation.Substring(i2+1);
            if(a.Contains('?'))
            { float f2=float.Parse(b);
              float f3=float.Parse(c);
              float f1=f3/f2;
              string s1=f1.ToString();
              int l1=s1.Length;
              int l2=a.Length;
              int r=-1;
              if(l1==l2)
              {char[] result=s1.ToCharArray();
               char[] prob=a.ToCharArray();
               for(int i=0;i<l1;i++)
               { if(prob[i]=='?')
                 {r=int.Parse(result[i].ToString());
                 continue;}
                 if(result[i]!=prob[i])
                 { r=-1;
                   break;
                 }
               }
              }
              return r;
            }

            else if(b.Contains('?'))
            {float f1=float.Parse(a);
              float f3=float.Parse(c);
              float f2=f3/f1;
              string s2=f2.ToString();
              int l1=s2.Length;
              int l2=b.Length;
              int r=-1;
              if(l1==l2)
              {char[] result=s2.ToCharArray();
               char[] prob=b.ToCharArray();
               for(int i=0;i<l1;i++)
               { if(prob[i]=='?')
                 {r=int.Parse(result[i].ToString());
                 continue;}
                 if(result[i]!=prob[i])
                 { r=-1;
                   break;
                 }
               }
              }
              return r;

             }
             else
             {float f1=float.Parse(a);
              float f2=float.Parse(b);
              float f3=f1*f2;
              string s3=f3.ToString();
              int l1=s3.Length;
              int l2=c.Length;
              int r=-1;
              if(l1==l2)
              {char[] result=s3.ToCharArray();
               char[] prob=c.ToCharArray();
               for(int i=0;i<l1;i++)
               { if(prob[i]=='?')
                 {r=int.Parse(result[i].ToString());
                 continue;}
                 if(result[i]!=prob[i])
                 { r=-1;
                   break;
                 }
               }
              }
              return r;

             }
            throw new NotImplementedException();
        }
    }
}
