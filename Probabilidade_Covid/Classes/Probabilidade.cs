using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probabilidade_Covid.Classes
{
    class Probabilidade
    {
        private float favoraveis;
        private float possibilidades = 11;
        public float resultado;

        public float Favoraveis { get => favoraveis; set => favoraveis = value; }
        public float Possibilidades { get => possibilidades; set => possibilidades = value; }

        public float Calcular()
        {
            float probabilidade = (favoraveis / possibilidades) * 100;
            return probabilidade;

            //this.resultado = probabilidade;
        }
    }
}
