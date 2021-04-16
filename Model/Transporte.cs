using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_poo.Model
{
    public abstract class Transporte
    {
        private int pasajeros;
        public int Pasajeros
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
