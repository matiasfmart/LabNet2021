using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6.MVC.Logic
{
    interface ABMInterface<T>
    {
        List<T> GetAll();
        void Add(T toAdd);
        void Delete(int toDelete);
        void Update(T toUpDate);
    }
}
