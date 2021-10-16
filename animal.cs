using System;

namespace Exercicio_C_A
{
    public class Animal
    {

        //Atributos
        private string nome;
        private string tipo;


        //Método Construtor
        public Animal(string nome, string tipo){
            this.setNome(nome);
            adicionarTipo(tipo);
        }

        //Função validadora
        public void adicionarTipo(string tipo){
            if (tipo != "cachorro" || tipo != "gato" || tipo != "peixe"){
                this.setTipo("peixe");            
            }else{
                this.setTipo(tipo);
            }
        }

        //Getters e Setters
        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getTipo()
        {
            return this.tipo;
        }
        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }



    }
}