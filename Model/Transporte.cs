using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_poo.Model
{
    public abstract class Transporte
    {
        private int pasajeros; //variable privada
        
        public int Pasajeros    //propiedad publica para acceder a los datos
        {
            get
            {
                return pasajeros;
            }
            set
            {
                pasajeros = value;
            }
        }

        public abstract string Avanzar();

        public abstract string Detenerse();

    }
}
