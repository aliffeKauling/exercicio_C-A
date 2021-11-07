using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_C_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
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
                        imc.imcC();
                        Console.WriteLine("Seu IMC é: {0}", imc.imc);
                        Console.WriteLine("Sua classificação é: {0}", imc.classificacao);                       
                        break;
                    case 2:
                    Salario salario = new Salario();               
                        salario.salarioM();
                        Console.WriteLine("A quantidade de salários do funcionário é: {0}", salario.getQtsalarios());
                        break;
                    case 3:
                    Volume volume = new Volume();                        
                        volume.volumeE();                   
                        Console.WriteLine("O volume da esfera é {0} ", volume.resultado);                       
                        break;
                    case 4:
                    Media media = new Media();
                    media.calculoMedia();
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
                            n[i] = Console.ReadLine().ToLower(); 
                            Console.WriteLine("Tipo do pet {0}", i+1);
                            t[i] = Console.ReadLine().ToLower(); 
                            

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
                            Console.WriteLine("Tipo:{0}", animal.getTipo());  
                        }
                            
                        Console.WriteLine("\nVocê digitou:\n");                        
                        Console.WriteLine("{0} cachorros;\n{1} gatos;\n{2} peixes.", cachorro, gato, peixe);
                        

                        break;
                    case 6:
                        validacao = false;
                        break;
                    default:
                        Console.WriteLine("Opção invalida. Escolha uma das 6 operações");
                        break;
                }
                Console.WriteLine("Deseja realizar alguma operação? Se sim, aperte ENTER.");
                Console.ReadLine();
                Console.Clear();
            } while (validacao);
        }       
    }
}
