using System.Collections;
using System.ComponentModel.Design;

class Program {
    static void Main(String[] args) {

        // Ficha();
        MenuDeEscolha();

    }


    //Escolha com Switch
    public static void MenuDeEscolha() {

        Console.WriteLine("Bem vindo ao APP !!!");
        Console.WriteLine(" ");
        Console.WriteLine("Você Prefere: ");
        Console.WriteLine("1 Criar Ficha com ajuda do APP ");
        Console.WriteLine("2 Criar Personagem digtando ");
        Console.WriteLine("3 Sair ");
        Console.WriteLine("");

        string opcoes = Console.ReadLine();

        switch (opcoes) { 
            case "1":
                // CRIAR METODO COM SWITCH
                break; 

            case "2":
                Ficha();
                break;

            case "3":
                Console.WriteLine("Saindo... Até a proxima ");
                break;
            default:
                Console.WriteLine("Opção Invalida");
                break;
        
        }
    }






    public static void Ficha()
    {
        string nome = Nome();
        int NivelPersonagem = Nivel();
        string RacaPersonagem = Raca();
        string ClassePersonagem = Classe();
        var (VidaMaxima, VidaAtual) = Vida();
        int CA = ClasseDeArmadura();
        var (Forca, Destreza, Constituicao, Inteligencia, Sabedoria, Carisma) = Status();

        Console.WriteLine("");
        Console.WriteLine("-------------------------------------------------------------------------------");
        Console.WriteLine($"| Nome do Personagem: {nome} || Nível {NivelPersonagem} ||" );    
        Console.WriteLine("                                                                             -");
        Console.WriteLine($"| Vida: {VidaAtual} / {VidaMaxima} || CA: {CA} ||");
        Console.WriteLine("                                                                             -");
        Console.WriteLine($"| Classe: {ClassePersonagem} || Raça: {RacaPersonagem}");
        Console.WriteLine("                                                                             -");
        Console.WriteLine($"| Força: {Forca} || Destreza: {Destreza} || Constituição: {Constituicao} || ");
        Console.WriteLine("                                                                             -");
        Console.WriteLine($"| Inteligência: {Inteligencia} || Sabedoria: {Sabedoria} || Crisma {Carisma} ||");
        Console.WriteLine("                                                                             -");
        Console.WriteLine("-------------------------------------------------------------------------------");

        
    }

    //Entrada do Nome
    static string Nome() {

        Console.WriteLine(" ");
        Console.WriteLine("Qual o nome do perosnagem??? ");
        string nome = Console.ReadLine();
        return nome!;


    }

    static int Nivel() {
        Console.WriteLine("");
        Console.WriteLine("Qual nivel do personagem: ");
        int NivelPersonagem = int.Parse(Console.ReadLine());
        return NivelPersonagem;
    
    
    }
    // Raça
    static string Raca() {

        Console.WriteLine(" ");
        Console.WriteLine("Qual a Raça do personagem? ");
        string RacaPersonagem = Console.ReadLine();
        return RacaPersonagem;
    }

    //Classe
    static string Classe() {
        Console.WriteLine(" ");
        Console.WriteLine("Qual a Sua Classe? ");
        string ClassePersonagem = Console.ReadLine();
        return ClassePersonagem;
    
    }


    //Entrada da Classe de Armadura (CA)
    static int ClasseDeArmadura() {

        Console.WriteLine(" ");
        Console.WriteLine("Qual sua Classe de Armadura (CA) ??? ");
        int CA = int.Parse(Console.ReadLine());
        return CA;

    }

    //Entrada da Vida | Retornando em Tupla
    public static (int VidaMaxima, int VidaAtual)   Vida() {

        Console.WriteLine(" ");
        Console.WriteLine("Qual é sua vida maxima? ");
        int VidaMaxima = int.Parse(Console.ReadLine());


        Console.WriteLine(" ");
        Console.WriteLine("Qual é sua vida atual? ");
        int VidaAtual = int.Parse(Console.ReadLine());

        return (VidaMaxima, VidaAtual);
    }

    //Entrada dos Status | Retornando em Tupla
    static (int Foraca, int Destreza, int Constituicao, int Inteligencia, int Sabedoria, int Carisma) Status() {

        Console.WriteLine(" ");
        Console.WriteLine("Digite em ordem qual são os valores dos seus status !!!");

        Console.WriteLine(" ");
        //Força
        Console.WriteLine("Força: ");
        int Forca = int.Parse(Console.ReadLine());

        Console.WriteLine(" ");
        //Destreza
        Console.WriteLine("Destreza: ");
        int Destreza = int.Parse(Console.ReadLine());

        Console.WriteLine(" ");
        //Constituição
        Console.WriteLine("Constituição: ");
        int Constituicao = int.Parse(Console.ReadLine());

        Console.WriteLine(" ");
        //Inteligência
        Console.WriteLine("Inteligência: ");
        int Inteligencia = int.Parse(Console.ReadLine());

        Console.WriteLine(" ");
        //Sabedoria
        Console.WriteLine("Sabedoria: ");
        int Sabedoria = int.Parse(Console.ReadLine());

        Console.WriteLine(" ");
        //Carisma
        Console.WriteLine("Carisma: ");
        int Carisma = int.Parse(Console.ReadLine());

        return (Forca, Destreza, Constituicao, Inteligencia, Sabedoria, Carisma);
    }





}