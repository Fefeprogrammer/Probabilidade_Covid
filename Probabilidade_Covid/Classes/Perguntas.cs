using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probabilidade_Covid.Classes
{
    class Perguntas
    {
        public void pergunta()
        {
            List<string> pergunta = new List<string>();

            pergunta.Add("Voce tem febre?");
            pergunta.Add("Voce tem tosse seca?");
            pergunta.Add("Voce se sente cansado?");
            pergunta.Add("Voce sente dores ou desconforto?");
            pergunta.Add("Sua garganta esta inflamada?");
            pergunta.Add("Voce esta com diarreia?");
            pergunta.Add("Olhos vermelhos?");
            pergunta.Add("Voce tem sentido dores de cabeça?");
            pergunta.Add("Perdeu o paladar e/ou oufato?");
            pergunta.Add("Apareceu alguma macha no corpo ou algo do tipo?");
            pergunta.Add("Tem sentido dificuldade para respirar?");
            pergunta.Add("Tem sentido dor ou pressão no peito?");
        }
       
    }
}
