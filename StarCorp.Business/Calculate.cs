using System.Collections.Generic;
using System.Text;
using System;

namespace StarCorp.Business
{
    public class Calculate
    {
        public string Calculation(int entryNumber)
        {
            string result = "Type indefined";

            if (entryNumber.IsNumberValid())
            {
                if (entryNumber.IsMultiple(3) && !entryNumber.IsMultiple(5))
                    result = "StarCorp";

                else if (entryNumber.IsMultiple(5) && !entryNumber.IsMultiple(3))
                    result = "IT";

                else if (entryNumber.IsMultiple(new int[] { 3, 5 }))
                    result = "StarCorpianos";
            }

            return result;
        }
    }
    // Irei deixar as classes juntas por conta da regra ser simples e para facilitar a validação
    public static class MultipleExtensions
    {
        public static bool IsMultiple(this int multiple, int number) => multiple % number == 0 ? true : false;
        public static bool IsNumberValid(this int number) => !(number == 0) && !(number < 0) ? true : false;
        public static bool IsMultiple(this int multiple, int[] number)
        {
            foreach (var x in number)
            {
                if (!multiple.IsMultiple(x))
                    return false;
            }

            return true; 
        }
        
    }
}
