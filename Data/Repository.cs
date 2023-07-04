using FirstApi.itrefaces;
using FirstApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.Data
{
    public static class Repository
    {
        private static readonly List<ICar> cars;
        static Repository()
        {
            cars = new List<ICar>()
            {
                new Car(){ Name = "Audi A8", Volume = 6.1 },
                new Car(){ Name = "BMW X7", Volume = 6.0}, 
                new Car(){ Name = "Mercedes Mclaren", Volume = 8.4}
            };
        }
        public static IEnumerable<ICar> GetCars()
        {
            return cars;
        }
    }
}
