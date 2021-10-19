using System;
using System.Collections.Generic;

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
                        Console.WriteLine("Sua classificação é: {0}", imc.classificacao);
                       
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
                        int cachorro = 0, gato = 0, peixe = 0;
                        string[] n = new string[5];
                        string[] t = new string[5]; 
                        List<Animal> animais = new List<Animal>();
                       
                        for(int i=0; i<5; i++){
                            Console.WriteLine("Nome do pet {0}", i+1);
                            n[i] = Console.ReadLine(); 
                            Console.WriteLine("Tipo do pet {0}", i+1);
                            t[i] = Console.ReadLine(); 
                            

                            if(t[i] == "cachorro"){
                                cachorro = cachorro+1;
                            }else if (t[i] == "gato"){
                                gato = gato +1;
                            }else{
                                peixe = peixe +1;
                            }
                            Animal animalia = new Animal(n[i], t[i]);
                            animais.Add(animalia);


                        }
                        Console.WriteLine("Animais:\n");  
                        foreach (var animal in animais)
                        {
                            Console.WriteLine("Nome:{0}", animal.getNome());
                            Console.WriteLine("Nome:{0}", animal.getTipo());  
                        }    
                        Console.WriteLine("Você digitou:\n");                        
                        Console.WriteLine("{0} cachorros;\n{1} gatos;\n{2} peixes.", cachorro, gato, peixe);
                        

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
