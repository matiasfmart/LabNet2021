using Ejercicio3.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.EF.Logic
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

        public void Update(int toUpDate) //Se modifican los datos
        {
            var territoryUpDate = context.Territories.Find(toUpDate);

            Console.WriteLine("Ingresa la nueva descripcion:");
            territoryUpDate.TerritoryDescription = Console.ReadLine();

            Console.WriteLine("¿Desea cambiar el ID de la region? S/N"); //Relizo una confirmacion ya que es un dato muy relevante a otra tabla
            string regionChange = Console.ReadLine();
            if (regionChange == "S")
            {
                Console.Write("Ingrese el nuevo ID de region: ");
                territoryUpDate.RegionID = int.Parse(Console.ReadLine());
            }

            context.SaveChanges();
        }
    }
}
