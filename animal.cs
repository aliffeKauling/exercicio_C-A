namespace Exercicio_C_A
{
    public class Animal
    {
        private string nome;
        private string tipo;

        public void adicionarTipo(string tipo){
            if (tipo != "cachorro"){
                if(tipo != "gato"){
                }if(tipo != "peixe"){
                    setTipo("peixe");
                }
            }
        }

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