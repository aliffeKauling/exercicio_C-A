using System;

namespace Exercicio_C_A
{
    
    public class Media
    {
        //Atributos
        double n1;
        double n2;
        double n3;
        public double media;
        double mediaExame;
        public string resultado;


                      
        //Métodos    
        public string calculoMedia(){
            
            Console.WriteLine("Digite a primeira nota");
            n1 = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Digite a segunda nota");
            n2 = Convert.ToDouble(Console.ReadLine());   
            Console.WriteLine("Digite a terceira nota");
            n3 = Convert.ToDouble(Console.ReadLine());  
            media = (n1 + n2 + n3)/3;

            if(media >= 7){
             resultado = "Aprovado";
            }else{
                Console.WriteLine("Insira a nota do exame");
                mediaExame = (Convert.ToDouble(Console.ReadLine()) + media)/2;
                    if(mediaExame >= 5){
                        resultado = "Aprovado em exame";
                    }else{
                        resultado = "Reprovado";
                    }
            } 
            return resultado;
        }
                        

                        

    }
    
}