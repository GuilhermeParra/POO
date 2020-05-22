namespace SegundoPOO
{
    public class Personagem
    {
        public string nome;

        public string nomedeHeroi;

        public int idade;

        public string dano;

        public string total;

        public string defender(){
            return "O Capitão atacou!";
        }

        public float VidaTotal(float vidaAntesdoSoro, int vidaDepoisdoSoro ){
            return vidaAntesdoSoro + vidaDepoisdoSoro;
        }

        public float Atacar(float força, float potencia){
            return força*2*potencia;
        }




    }
}