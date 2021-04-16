using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_poo.Model
{
    public class Avion : Transporte
    {

        public override string Avanzar()
        {
            return String.Format("Vuela en el aire");
        }

        public override string Detenerse()
        {
            return String.Format("Se detiene unicamente aterrizando sobre el suelo");
        }
    }
}
