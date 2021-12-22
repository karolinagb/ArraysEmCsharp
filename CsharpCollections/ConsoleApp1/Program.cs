using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a classe aula";
            string aulaSets = "Trabalhando com conjuntos";

            //Criando array com valores definidos
            //string[] aulas = new string[]
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            //Criando array com tamanho definido
            string[] aulas = new string[3];
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            Imprimir(aulas);

            //Primeiro elemento do array:
            Console.WriteLine(aulas[0]);
            Console.WriteLine(aulas[aulas.Length - 1]);

            aulas[0] = "Trabalhando com arrays";

            Imprimir(aulas);

            //Propriedade IndexOf do Array procura a ocorrencia do objeto passado dentro do array informado
            Console.WriteLine("Aula modelando está no índice " + Array.IndexOf(aulas, aulaModelando));

            //Verifica ultima ocorrencia do elemento passado
            Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));

            //Inverte a ordem do array (1 fica em ultimos e ultimo em 1)
            //Para voltar a ordem normal é só reverter de novo
            Array.Reverse(aulas);
            Imprimir(aulas);

            //Alterar o tamanho do array
            //O metodo Resize faz uma copia interna do nosso array
            Array.Resize(ref aulas, 2);
            Imprimir(aulas);

            Array.Resize(ref aulas, 3);
            Imprimir(aulas);

            //Adicionando valor ao ultimo elemento do array
            aulas[aulas.Length - 1] = "Conclusão";
            Imprimir(aulas);

            //Ordenando em ordem alfabetica:
            //Metodo Sort nao é indepotente, ou seja, não consigo voltar ao estado inicial
            Array.Sort(aulas);
            Imprimir(aulas);

            //Copiar elementos especificos de um array para outro array
            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2); //array origem, a partir de que indice do array
                                               //origem, array destino, indice array destino
                                               //e quantos elementos serão copiados

            Imprimir(copia);

            //Copiar todos os elementos de um array para outro:
            string[] clone = aulas.Clone() as string[];
            Imprimir(clone);

            //Limpar elementos do array
            Array.Clear(clone, 1, 2); //Arra, a partir de que indice, limpar 2 elementos
            Imprimir(clone);

            string[] copia2 = new string[2];
            Array.Copy(aulas, aulas.Length - 2, copia, 0, 2);
            Console.WriteLine();
            Imprimir(copia2);
        }

        private static void Imprimir(string[] aulas)
        {
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            for (int i = 0; i< aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }
    }
}
