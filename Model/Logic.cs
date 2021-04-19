using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_exceptions.Model
{
    public class Logic
    {
        public static Exception exceptionLogic() 
        {
            throw new ArgumentOutOfRangeException();
        }
    }
}
