using System.Collections;

class Program {
    static void Main(String[] args) {

        Ficha();

    }
    public static void Ficha()
    {
        string nome = Nome();
        string RacaPersonagem = Raca();
        string ClassePersonagem = Classe();
        var (VidaMaxima, VidaAtual) = Vida();
        int CA = ClasseDeArmadura();
        var (Forca, Destreza, Constituicao, Inteligencia, Sabedoria, Carisma) = Status();

        Console.WriteLine("");
        Console.WriteLine("-------------------------------------------------------------------------------");
        Console.WriteLine("| Nome do Personagem:  " + nome + " ||");
        Console.WriteLine("| Vida: " + VidaAtual + "/" + VidaMaxima + " ||" + " CA: " + CA + " ||");
        Console.WriteLine("| Classe:  " + ClassePersonagem + " ||" + " Raça:  " + RacaPersonagem + " ||");
        Console.WriteLine("| Força: " + Forca + " ||" + " Destreza: " + Destreza + " ||"+ " Constituição: " + Constituicao + " ||");
        Console.WriteLine("| Inteligencia: " + Inteligencia + " ||" + " Sabedoria: " + Sabedoria + " ||" + " Carisma:" + Carisma + " ||");
        Console.WriteLine("");
        Console.WriteLine("-------------------------------------------------------------------------------");

        
    }

    //Entrada do Nome
    static string Nome() {

        Console.WriteLine("Qual o nome do perosnagem??? ");
        string nome = Console.ReadLine();
        return nome!;


    }
    // Raça
    static string Raca() {

        Console.WriteLine("Qual a Raça do personagem? ");
        string RacaPersonagem = Console.ReadLine();
        return RacaPersonagem;
    }

    //Classe
    static string Classe() { 
        
        Console.WriteLine("Qual a Sua Classe? ");
        string ClassePersonagem = Console.ReadLine();
        return ClassePersonagem;
    
    }


    //Entrada da Classe de Armadura (CA)
    static int ClasseDeArmadura() { 
    
        Console.WriteLine("Qual sua Classe de Armadura (CA) ??? ");
        int CA = int.Parse(Console.ReadLine());
        return CA;

    }

    //Entrada da Vida | Retornando em Tupla
    public static (int VidaMaxima, int VidaAtual)   Vida() {

        Console.WriteLine("Qual é sua vida maxima? ");
        int VidaMaxima = int.Parse(Console.ReadLine());


        Console.WriteLine("Qual é sua vida atual? ");
        int VidaAtual = int.Parse(Console.ReadLine());

        return (VidaMaxima, VidaAtual);
    }

    //Entrada dos Status | Retornando em Tupla
    static (int Foraca, int Destreza, int Constituicao, int Inteligencia, int Sabedoria, int Carisma) Status() {

        Console.WriteLine(" Digite em ordem qual são os valores dos seus status !!!");

        //Força
        Console.WriteLine("Força: ");
        int Forca = int.Parse(Console.ReadLine());

        //Destreza
        Console.WriteLine("Destreza: ");
        int Destreza = int.Parse(Console.ReadLine());

        //Constituição
        Console.WriteLine("Constituição: ");
        int Constituicao = int.Parse(Console.ReadLine());

        //Inteligência
        Console.WriteLine("Inteligência: ");
        int Inteligencia = int.Parse(Console.ReadLine());

        //Sabedoria
        Console.WriteLine("Sabedoria: ");
        int Sabedoria = int.Parse(Console.ReadLine());

        //Carisma
        Console.WriteLine("Carisma: ");
        int Carisma = int.Parse(Console.ReadLine());

        return (Forca, Destreza, Constituicao, Inteligencia, Sabedoria, Carisma);
    }



}