using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_poo.Model
{
    public class Automovil : Transporte
    {

        public override string Avanzar()
        {
            return String.Format("Se desliza con ruedas sobre el suelo");
        }

        public override string Detenerse()
        {
            return String.Format("Se detiene frenando las ruedas");
        }
    }
}
