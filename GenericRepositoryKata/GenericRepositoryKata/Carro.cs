using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryKata
{
    public sealed class Carro
    {
        public Carro(int id, string model)
        {
            Id = id;
            Model = model;
        }

        public int Id { get; private set; }
        public string Model { get; private set; }
    }
}
