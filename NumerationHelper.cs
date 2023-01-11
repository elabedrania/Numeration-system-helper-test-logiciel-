using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerationSystemHelper
{
    public class NumerationHelper : InumerationHelper
    {
        Dictionary<int, string> Numbers1 = new Dictionary<int, string>()
        {
            {1,"I" },
            {5,"V" },
            {10,"X" },
            {50,"L" },
            {100,"C" },
            {500,"D" },
            {1000,"M" }
            
        };

        public string ArabicToRomanConverter(int Value)
        {
            List<int> Numbers = new List<int>();
            int x = 1;
            int j ;
            String ch = "";
            for(int i = 0; true; i++)
            {
                if((Value/x)>0)
                {
                    x=x * 10;
                }
                else
                {
                    j = i ;
                    break;
                }
            }
            x=x/10;
            int Value1 = Value;
            int x1 = x;
            for(int i = 0; i < j; i++)
            {
                int A = Value1 / x1;
                int B = Value1 % x1;

                if (A * x1 == 0)
                {
                    break;
                }
                else
                {
                    Numbers.Add(A * x1);
                    Value1 = B;
                    x1 = x1 / 10;
                }


            }
           int x2 = x;
            for(int i=0; i < Numbers.Count; i++)
            {
                int A1 = Numbers[i] / x2;
                int A2 = Numbers[i];
                for (int i2=0;i2< Numbers1.Count; i2++)
                {
                    if (Numbers1.ElementAt(i2).Key * A1 == A2) 
                    {
                        if( i2 + 1 < Numbers1.Count && Numbers1.ElementAt(i2+1).Key-x2== A2 )
                        {
                            ch += Numbers1.ElementAt(i2).Value+""+ Numbers1.ElementAt(i2+1).Value;

                        }
                        else if (i2 + 2 < Numbers1.Count && Numbers1.ElementAt(i2 + 2).Key - x2 == A2)
                        {
                            ch += Numbers1.ElementAt(i2).Value + "" + Numbers1.ElementAt(i2 + 2).Value;

                        }
                        else if (i2 + 1 < Numbers1.Count &&A2 >= Numbers1.ElementAt(i2+1).Key)
                        {
                            ch += Numbers1.ElementAt(i2+1).Value;
                            A2 = A2 - Numbers1.ElementAt(i2 + 1).Key;
                            if (A2 > 0)
                            {
                                ch += ArabicToRomanConverter(A2);
                            }
                           
                        }
                        else
                        {
                            for(int i3 = 0; i3 < A1; i3++)
                            {
                                ch += Numbers1.ElementAt(i2).Value;
                            }
                        }

                    }
                }
                x2=x2 / 10;


            }


            


            return ch;

        }




       /* public string ArabicToRomanConverter(int Value)
        {
            //  if (Value.ToString().Length == 1)
            //   {


            switch (Value)
            {
                case 1: return "I";
                case 2: return "II";
                case 3: return "III";
                case 4: return "IV";
                case 5: return "V";
                case 6: return "VI";
                case 7: return "VII";
                case 8: return "VIII";
                case 9: return "IX";
                default:
                    return "";
            }
            //    }


        }*/

        public int ArabicToRomanConverter(string Value)
        {
            throw new NotImplementedException();
        }
    }
}
