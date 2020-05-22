using System;

namespace SegundoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem Steve = new Personagem();
            Steve.nome = "Steve Rogers";
            Steve.nomedeHeroi = "Nome de heroi: Capitão América";
            Steve.idade = 37;
            Steve.dano = "O dano foi de:";
            Steve.total = "A vida total de Steve é:";
            
            Console.WriteLine(Steve.nome);
            Console.WriteLine(Steve.nomedeHeroi);
            Console.WriteLine(Steve.defender());
            Console.WriteLine(Steve.dano);
            Console.WriteLine(Steve.Atacar(35f, 200f));
            Console.WriteLine(Steve.total);
            Console.WriteLine(Steve.VidaTotal(50f, 1000));
        }
    }
}
