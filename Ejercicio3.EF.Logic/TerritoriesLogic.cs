using Ejercicio6.MVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6.MVC.Logic
{
    public class TerritoriesLogic : BaseLogic, ABMInterface<Territories>
    {
        public void Add(Territories toAdd) //Se agrega un nuevo elemento
        {
            context.Territories.Add(toAdd);
            context.SaveChanges();
        }

        public void Delete(int toDelete) //Mediante el ID, se elimina el territorio seleccionado
        {
            var territoryDelete = context.Territories.Find(toDelete);
            context.Territories.Remove(territoryDelete);
            context.SaveChanges();
        }

        public List<Territories> GetAll()
        {
            return context.Territories.ToList(); //Traigo todos los datos
        }

        public void Update(Territories toUpDate) //Se modifican los datos
        {
            var territoryUpDate = context.Territories.Find(toUpDate);

            territoryUpDate.TerritoryDescription = toUpDate.TerritoryDescription;

            context.SaveChanges();
        }
    }
}
