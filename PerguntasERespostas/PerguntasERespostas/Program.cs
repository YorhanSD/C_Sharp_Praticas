using System;

namespace PerguntasERespostas
{
    class PerguntasERespostas
    {
        static void Main(string[] args)
        {
            String[] resposta = new string[6];
            String nome;
            String tesouro;

            Console.WriteLine("$$$$$$ Show Dos Milhões $$$$$$\n");

            Console.WriteLine("Bem vindo ao Show Dos Milhões\n");

            Console.WriteLine("Por favor informe seu nome: ");

            nome = Console.ReadLine();

            Console.WriteLine("Olá " + nome + "\n");

            Console.WriteLine("Pressione uma tecla para começar as perguntas...");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("\nVamos a primeira pergunta: \n");

            Console.WriteLine("Valendo R$ : 100.000 Perguta na tela: \n");

            Console.WriteLine("Qual a Capital da Espanha? \n");

            Console.WriteLine("A - Catalunã \n");

            Console.WriteLine("B - México \n");

            Console.WriteLine("C - Madrid \n");

            Console.WriteLine("Por favor digite a letra referente a alternativa correta: \n");

            resposta[0] = Console.ReadLine();

            if(resposta[0] == "C" || resposta[0] == "c")
            {
                Console.Clear();
                Console.WriteLine("Parabéns " + nome +" a resposta está correta!");
                tesouro = "100.000";
                Console.WriteLine("Você ganhou " + tesouro + " reais\n");
                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Resposta Incorreta");
                Console.WriteLine("Obrigado por jogar " + nome);
                Environment.Exit(0);

            }

            

            Console.WriteLine("\nVamos a segunda pergunta: \n");

            Console.WriteLine("Valendo R$ : 250.000 Perguta na tela: \n");

            Console.WriteLine("Qual o maior Mamífero do Mundo ? \n");

            Console.WriteLine("A - Baleia-Cachalote \n");

            Console.WriteLine("B - Megalodon \n");

            Console.WriteLine("C - Tubarão-Baleia \n");

            Console.WriteLine("D - Baleia-Azul \n");

            Console.WriteLine("Por favor digite a letra referente a alternativa correta: \n");

            resposta[1] = Console.ReadLine();

            if (resposta[1] == "D" || resposta[1] == "d")
            {
                Console.Clear();
                Console.WriteLine("Parabéns " + nome + " a resposta está correta!");
                tesouro = "250.000";
                Console.WriteLine("Você ganhou " + tesouro + " reais\n");
                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Resposta Incorreta");
                Console.WriteLine("Obrigado por jogar " + nome);
                Environment.Exit(0);
            }

            Console.WriteLine("\nVamos a terceira pergunta: \n");

            Console.WriteLine("Valendo R$ : 500.000 Perguta na tela: \n");

            Console.WriteLine("Quem fundou a escola Pitagórica ? \n");

            Console.WriteLine("A - Tales de Mileto \n");

            Console.WriteLine("B - Pitágoras \n");

            Console.WriteLine("C - Heráclito de Éfeso \n");

            Console.WriteLine("D - Sócrates \n");

            Console.WriteLine("Por favor digite a letra referente a alternativa correta: \n");

            resposta[2] = Console.ReadLine();

            if (resposta[2] == "B" || resposta[2] == "b")
            {
                Console.Clear();
                Console.WriteLine("Parabéns " + nome + " a resposta está correta!");
                tesouro = "500.000";
                Console.WriteLine("Você ganhou " + tesouro + " reais\n");
                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Resposta Incorreta");
                Console.WriteLine("Obrigado por jogar " + nome);
                Environment.Exit(0);
            }

            Console.WriteLine("\nVamos a quarta pergunta: \n");

            Console.WriteLine("Valendo R$ : 1.000.000 Perguta na tela: \n");

            Console.WriteLine("Qual foi o lugar de desembarque, das tropas aliadas no famoso Dia D em 1944, na Segunda Guerra Mundial? \n");

            Console.WriteLine("A - Normandia \n");

            Console.WriteLine("B - Manchester \n");

            Console.WriteLine("C - Lucerna \n");

            Console.WriteLine("D - Salzburgo \n");

            Console.WriteLine("E - Londres \n");

            Console.WriteLine("Por favor digite a letra referente a alternativa correta: \n");

            resposta[3] = Console.ReadLine();

            if (resposta[3] == "A" || resposta[3] == "a")
            {
                Console.Clear();
                Console.WriteLine("Parabéns " + nome + " a resposta está correta!");
                tesouro = "1.000.000";
                Console.WriteLine("Você ganhou " + tesouro + " reais\n");
                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Resposta Incorreta");
                Console.WriteLine("Obrigado por jogar " + nome);
                Environment.Exit(0);

            }

            Console.WriteLine("\nVamos a quinta pergunta: \n");

            Console.WriteLine("Valendo R$ : 1.500.000 Perguta na tela: \n");

            Console.WriteLine("Qual pais possui a maior reserva de petrolio do planeta?\n");

            Console.WriteLine("A - Estados Unidos\n");

            Console.WriteLine("B - Venezuela\n");

            Console.WriteLine("C - Egito\n");

            Console.WriteLine("D - China\n");

            Console.WriteLine("E - Arábia Saudita\n");

            Console.WriteLine("Por favor digite a letra referente a alternativa correta: \n");

            resposta[4] = Console.ReadLine();

            if (resposta[4] == "B" || resposta[4] == "b")
            {
                Console.Clear();
                Console.WriteLine("Parabéns " + nome + " a resposta está correta!");
                tesouro = "1.500.000";
                Console.WriteLine("Você ganhou " + tesouro + " reais\n");
                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Resposta Incorreta");
                Console.WriteLine("Obrigado por jogar " + nome);
                Environment.Exit(0);

            }

            Console.WriteLine("\nVamos a sexta e ultima pergunta: \n");

            Console.WriteLine("Valendo a incrível quantia de R$ : 2.000.000 Perguta na tela: \n");

            Console.WriteLine("Quem Descobriu o processo de  Pasteurização e a Vacina Contra a Raiva?\n");

            Console.WriteLine("A - Antoine Lavoisier\n");

            Console.WriteLine("B - Blaise Pascal\n");

            Console.WriteLine("C - Marie Curie\n");

            Console.WriteLine("D - Nikola Tesla\n");

            Console.WriteLine("E - Louis Pasteur\n");

            Console.WriteLine("Por favor digite a letra referente a alternativa correta: \n");

            resposta[5] = Console.ReadLine();

            if (resposta[5] == "E" || resposta[5] == "e")
            {
                Console.Clear();
                Console.WriteLine("Parabéns " + nome + " a resposta está correta!");
                tesouro = "2.000.000";
                Console.WriteLine("Você ganhou " + tesouro + " reais\n");
                Console.WriteLine("$$$ Parabéns " + nome + " você é o mais novo Milionário Da Cidade!!! $$$");
                Console.WriteLine("$$$ E Faturou Incríveis " + tesouro + " de reais!!! $$$");
                Console.WriteLine("Obrigado por jogar!");
                Console.WriteLine("Pressione uma tecla para sair...");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Resposta Incorreta");
                Console.WriteLine("Obrigado por jogar " + nome);
                Environment.Exit(1);

            }

            
        }
    }
}
