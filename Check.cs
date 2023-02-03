using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDLibrary
{
    public class Check
    {
        public static bool IsIn<T>(T ele, List<T> values)
        {
            foreach (T value in values)
            {
                if (ele.Equals(value)) return true;
            }
            return false;
        }
    }
}
