using FirstApi.itrefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.Models
{
    public class Car : ICar
    {
        public string Name { get; set; }
        public double Volume { get; set; }
    }
}
