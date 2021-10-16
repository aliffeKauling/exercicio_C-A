using System;

namespace Exercicio_C_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double funcionario;
            double minimo;
            double raio;
            float A;
            float P;
            double n1;
            double n2;
            double n3;
            bool validacao = true;
            Program program = new Program();


            Console.WriteLine("Bem Vinde Multifuncional_Soft");

            do
            {
                
                Console.WriteLine("Qual a operação desejada?");
                Console.WriteLine("(1) Calcular IMC");
                Console.WriteLine("(2) Calcular salários mínimos");
                Console.WriteLine("(3) Calcular volume da esfera");
                Console.WriteLine("(4) Calcular média");
                Console.WriteLine("(5) Identificar pets");
                Console.WriteLine("(6) Sair");


                Console.WriteLine("Digite sua opção");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Imc imc = new Imc();

                        Console.WriteLine("Digite seu peso");
                        P = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite sua altura");
                        A = float.Parse(Console.ReadLine());

                        imc.imcC(A, P);
                        Console.WriteLine("Seu IMC é: {0}", imc.imc);
                       
                        break;
                    case 2:

                    Salario salario = new Salario();
                
                        Console.WriteLine("Digite o salário do funcionário");
                        funcionario = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o salário mínimo");
                        minimo = Convert.ToDouble(Console.ReadLine());
                        salario.salarioM(funcionario, minimo);
                        Console.WriteLine("A quantidade de salários do funcionário é: {0}", salario.getQtsalarios());

                        break;
                    case 3:
                    Volume volume = new Volume();
                        Console.WriteLine("Digite o valor do raio");
                        raio = Convert.ToDouble(Console.ReadLine()); 
                        volume.volumeE(raio);                   
                        Console.WriteLine("O volume da esfera é {0} ", volume.resultado);

                        
                        break;
                    case 4:
                    Media media = new Media();
                
                        Console.WriteLine("Digite a primeira nota");
                        n1 = Convert.ToDouble(Console.ReadLine()); 
                        Console.WriteLine("Digite a segunda nota");
                        n2 = Convert.ToDouble(Console.ReadLine());   
                        Console.WriteLine("Digite a terceira nota");
                        n3 = Convert.ToDouble(Console.ReadLine());  
                        media.calculoMedia(n1, n2, n3);

                        Console.WriteLine("Média {0}", media.media);
                        Console.WriteLine("Resultado {0}", media.resultado);

                        break;
                    case 5:



                        break;
                    case 6:
                        validacao = false;
                        break;
                    default:
                        Console.WriteLine("Opção invalida. Escolha uma das 4 operações");
                        break;
                }
                Console.WriteLine("Deseja realizar alguma operação? Se sim, aperte ENTER");
                Console.ReadLine();
                Console.Clear();
            } while (validacao);
        }

        

    }
}


// Criar um programa que leia o valor de três notas escolares de um aluno. Calcular a média aritmética e apresentar na tela a mensagem “Aprovado” se 
//a média obtida for maior ou igual a 7; 
//caso contrário, o programa deve solicitar a nota de exame do aluno e calcular uma nova média aritmética entre a nota do exame e a primeira média aritmética. 
//Se o valor da nova média for maior ou igual a 5, apresentar na tela a mensagem “Aprovado em exame”; caso contrário, apresentar a mensagem “Reprovado”. 
//Informar junto com cada mensagem o valor da média obtida.

//Crie um algoritmo/programa no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
//O programa deverá exibir na tela para o usuário quantos cachorros, gatos e peixes foram informados.
//Regras que deverão ser seguidas para a implementação do algoritmo:
//Os únicos tipos de animais válidos são cachorro, gato e peixe.
//Caso seja informado um tipo diferente, o programa deverá definir o tipo do animal como peixe.
//É obrigatório criar uma classe para representar o animal.
//A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
//A classe deverá possuir métodos de acesso para permitir que o usuário armazene/leia os dados dos dois dados privados (propriedades).
