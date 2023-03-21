using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooZoologico
{
    public class AnimalPlus:Animal
    {
        public AnimalPlus() : base()
        {
            this.tipoAlimentacao = "";
        }

        public AnimalPlus(string especie, double peso, string tipoAlimentacao) : base(especie, peso)
        {
            this.TipoAlimentacao = tipoAlimentacao;
        }
        private string tipoAlimentacao;

        public string TipoAlimentacao
        {
            get { return tipoAlimentacao; }
            set { tipoAlimentacao = value; }
        }

    }
}
