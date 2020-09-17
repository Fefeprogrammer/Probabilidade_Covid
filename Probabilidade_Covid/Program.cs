using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Probabilidade_Covid.Classes;

namespace Probabilidade_Covid
{
    class Program
    {
        static void Main(string[] args)
        {
            Perguntas perguntas = new Perguntas();
            Probabilidade probabilidade = new Probabilidade();
            int cont = 0;
            string resposta;

            Console.WriteLine("ATENÇÃO: Este aplicativo console serve apenas para um teste e para mostrar para as pessoas alguns dos sintomas de covid. Ao apresentar algum sintoma procure um médico imediatamente");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Responda as seguintes questão com sim ou não");
            Console.ReadLine();
            Console.Clear();
            

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

            do
            {
                Console.WriteLine(pergunta[cont]);
                resposta = Console.ReadLine();
                if(resposta == "sim" || resposta == "Sim" || resposta == "SIM")
                {
                    probabilidade.Favoraveis++;
                    Console.Clear();
                }else if(resposta == "nao" || resposta == "Nao" || resposta == "NAO")
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("VALOR INVALIDO!");
                    Console.WriteLine("Pressione qualquer tecla para sair...");
                    Console.ReadLine();
                }
                cont++;
            } while (cont < pergunta.Count);

            

            Console.WriteLine("A possibilidade de voce estar com covid é de ", probabilidade.Calcular().ToString(), "%");

            Console.ReadLine();
        }
    }
}
