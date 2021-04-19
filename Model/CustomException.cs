using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_exceptions.Model
{
    public class CustomException : Exception
    {
        private string mensaje;
        public CustomException(string message)
        {
            this.mensaje = message;
        }
        public override string Message => this.mensaje + ", " + base.Message;
    }
}
