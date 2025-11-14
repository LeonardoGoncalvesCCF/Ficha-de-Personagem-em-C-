using System.Collections;
using System.ComponentModel.Design;
using FichaDePersonagemEmC_;



class Program {
    
    static void Main(String[] args) {

        //MenuDeEscolha();

        MotherSheet Teste = new MotherSheet("name", 0, 0, 0, 0, 0, 0, 0);

        string nome1;
        nome1 = Teste.GetCharacterName();

        Teste._CharacterArmorClass = 10;
       

        Console.WriteLine(nome1);
        
        Teste.SetCharacterName("Jorge");

        nome1 = Teste.GetCharacterName();

        Console.WriteLine(nome1);   





    }

    public bool ehValido = false;

    //MENU
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

                FichaEmSwitch();
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


    static void FichaEmSwitch() {

        string nome = Nome();
        int NivelPersonagem = Nivel();
        string OpcaoRaca = RacaEscolha();
        string OpcaoClasse = ClasseEscolha();
        var (VidaMaxima, VidaAtual) = Vida();
        int CA = ClasseDeArmadura();
        var (Forca, Destreza, Constituicao, Inteligencia, Sabedoria, Carisma) = Status();

     
        Console.WriteLine("");
        Console.WriteLine("-------------------------------------------------------------------------------");
        Console.WriteLine($"| Nome do Personagem: {nome} || Nível {NivelPersonagem} ||");
        Console.WriteLine("                                                                             -");
        Console.WriteLine($"| Vida: {VidaAtual} / {VidaMaxima} || CA: {CA} ||");
        Console.WriteLine("                                                                             -");
        Console.WriteLine($"| Classe: {OpcaoClasse} || Raça: {OpcaoRaca}");
        Console.WriteLine("                                                                             -");
        Console.WriteLine($"| Força: {Forca} || Destreza: {Destreza} || Constituição: {Constituicao} || ");
        Console.WriteLine("                                                                             -");
        Console.WriteLine($"| Inteligência: {Inteligencia} || Sabedoria: {Sabedoria} || Crisma {Carisma} ||");
        Console.WriteLine("                                                                             -");
        Console.WriteLine("-------------------------------------------------------------------------------");

       // return "FichaEmSwitch";
    }

    //Ficha pelo APP
    static void APPCriaFicha() {

        RacaEscolha();
        ClasseEscolha();
    }
    // Escolhendo Raça com Switch
    static string RacaEscolha() {
        Console.WriteLine("");
        Console.WriteLine("Escolha Sua Raça: ");
        Console.WriteLine("");
        Console.WriteLine("1 Goblin \n" +
                          "2 Anão \n" +
                          "3 Warfrorged \n" +
                          "4 Aasimar \n" +
                          "5 Elfo \n" +
                          "6 Orc ");
        Console.WriteLine("  ");

        int OpcaoRaca = int.Parse(Console.ReadLine());

        // devolvendo a escolha com SWITCH EXPRESSION
        // nova versão do Switch Case 
        return OpcaoRaca switch
        {

            1 => "Goblin",
            2 => "Anão",
            3 => "Waforged",
            4 => "Aasimar",
            5 => "Elfo",
            6 => "Orc",
            _ => "Humano"
        };
    }

    // Escolhendo Classe com Switch
    static string ClasseEscolha() {
        Console.WriteLine("");
        Console.WriteLine("Escolha Sua Classe: ");
        Console.WriteLine("");
        Console.WriteLine("1 Paladino \n" +
                          "2 Clérigo \n" +
                          "3 Bárbaro \n" +
                          "4 Bardo \n" +
                          "5 Druida \n" +
                          "6 Feiticeiro \n" +
                          "7 Guerreiro \n" +
                          "8 Ladino \n" +
                          "9 Mago \n" +
                          "10 Monge \n" +
                          "11 Patrulheiro ");
        Console.WriteLine("  ");
        int OpcaoClasse = int.Parse(Console.ReadLine());

        return OpcaoClasse switch
        {
            1 => "Paladino",
            2 => "Clérigo",
            3 => "Bárbaro",
            4 => "Bardo",
            5 => "Druida",
            6 => "Feiticeiro",
            7 => "Guerreiro",
            8 => "Ladino",
            9 => "Mago",
            10 => "Monge",
            11 => "Patrulheiro"
        };
    
    
    }

    // --------------------------------------------------------------------------------------------------------------------\\
    
    // Ficha
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
        Console.WriteLine("Qual sua Classe de Armadura (CA) ??? Digite um numero");
        int CA=0;
        try
        {
            CA = int.Parse(Console.ReadLine());
        return CA;
        }
        catch (Exception e){
            Console.WriteLine("Você não digitou um número");
            Console.WriteLine("Quer informar o CA? Digite 1 para sim e 2 para não.");
            int resposta = int.Parse(Console.ReadLine());
            if (resposta == 1)
            {
                return ClasseDeArmadura();
            }
            else
            {
               CA = 0;
                return CA;
            }
                  
        }

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

}// Final Main