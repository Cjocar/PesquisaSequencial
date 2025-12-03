namespace PesquisaSequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pesquisa sequencial

            //Cadastrar 5 nomes em uma matriz unidimensional
            //Var
            string[] nomes;
            int i;
            string resposta; //É a variável que guardará o nome a ser pesquisado
            bool acha;

            nomes = new string[5];
            //Pedir os nomes (entrada)
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine($"Escreva o {i + 1} º nome: ");
                nomes[i] = Console.ReadLine();
            }

            //Pesquisa sequencial (Processamento)
            Console.WriteLine("Qual nome você quer pesquisar? ");
            resposta = Console.ReadLine();
            acha = false;
            i = 0;
            while (i < 5 && acha == false)
            {
                if (resposta == nomes[i])
                {
                    acha = true;
                }
                else
                {
                    i++;
                }
            }
            //Mostrar a pesquisa (Saída)
            if (acha == true)
            {
                Console.WriteLine($"{resposta} foi encontrado");
                Console.WriteLine(nomes[i]);
            }
            else
            {
                Console.WriteLine($"{resposta} não foi localizada");

            }
        }
    }
}