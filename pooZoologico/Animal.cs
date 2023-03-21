using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooZoologico
{
    public class Animal
    {
        public Animal()
        {
            this.Especie = "";
            this.Peso = 0;
        }
        public Animal(String especie, double peso)
        {
            this.Especie = especie;
            this.Peso = peso;
        }
        private String especie;

        public String Especie
        {
            get { return especie; }
            set { especie = value.ToUpper(); }
        }

        private double peso;

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }


    }
}
