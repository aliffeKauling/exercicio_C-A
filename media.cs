using System;

namespace Exercicio_C_A
{
    public class Media
    {
        //Atributos
        public double media;
        double mediaExame;
        public string resultado;



        //Métodos    
        public string calculoMedia(double n1, double n2, double n3){
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