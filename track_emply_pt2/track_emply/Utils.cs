using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace track_emply
{
    public static class Utils 
    {
        public static void Pay(Employ[] newArray)
        {
        
                for (int i = 0; i < newArray.Length; i++)
                {
                    Console.WriteLine(newArray[i].FirstN + " " + newArray[i].LastN + " got paid");
                }
            }
        }
    }


