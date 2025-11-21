using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaDePersonagemEmC_
{


    //Classe
    internal class MotherSheet
    {
        private string CharacterName;
        private int CharacterArmorClass;

        private int CharacterStrength;
        private int CharacterDexterity;
        private int CharacterConstitution;
        private int CharacterIntelligence;
        private int CharacterWisdom;
        private int CharacterCharisma;

        private int Modfiers;

        private int StrengthModfiers;
        private int DexterityModfiers;
        private int ConstitutionModfiers;
        private int IntelligenceModfiers;
        private int WisdomModfiers;
        private int CharismaModfiers;

        //Construtor
        public MotherSheet(string Name, int ArmorClass, int Strength, int Dexterity, int Constitution, int Intelligence, int Wisdom, int Charisma, int modfiers, int ModStrength, int ModDexterity, int ModConstitution, int ModIntelligence, int ModWisdom, int ModCharisma)
        {
            this.CharacterName = Name;
            this.CharacterArmorClass = ArmorClass;

            this.CharacterStrength = Strength;
            this.CharacterDexterity = Dexterity;
            this.CharacterConstitution = Constitution;
            this.CharacterIntelligence = Intelligence;
            this.CharacterWisdom = Wisdom;
            this.CharacterCharisma = Charisma;

            this.Modfiers = modfiers;

            this.StrengthModfiers = ModStrength;
            this.DexterityModfiers = ModDexterity;
            this.ConstitutionModfiers = ModConstitution;
            this.IntelligenceModfiers = ModIntelligence;
            this.WisdomModfiers = ModWisdom;
            this.CharismaModfiers = ModCharisma;
        }


        // GET e SET nome e Classe de armadura 

        public string _CharacterName { get; set; }
        public int _CharacterArmorClass { get; set; }

        //GET e SET de atributos do perosnagem
        public int _CharacterStrength { get; set; }
        public int _CharacterDexterity {  get; set; }
        public int _CharacterConstitution { get; set; }
        public int _CharacterIntelligence { get; set; }
        public int _CharacterWisdom { get; set; }
        public int _CharacterCharisma { get; set; }
        public int _Modifiers { get; set; }


        //GET e SET de Modificadores

        public int _StrengthModfiers { get; set; }
        public int _DexterityModfiers { get; set; }
        public int _ConstitutionModfiers { get; set; }
        public int _IntelligenceModfiers { get; set; }
        public int _WisdomModfiers { get; set; }
        public int _CharismaModfiers { get; set; }



        //---------- Metodos para Gravar os Modificadores

        // Gravando Modificador de Força
        public int GravarStrengthModfiers(int value) 
        {
            int ModificadorStr = value;

            int CalculoModificadorStr = CalcModfiers(ModificadorStr);

            StrengthModfiers = CalculoModificadorStr;

            return CalculoModificadorStr;

        }

        // Gravando Modificador de Destreza
        public int GravarDexterityModfiers(int value)
        {
            int ModificadorDex = value;

            int CalculoModificadorDex = CalcModfiers(ModificadorDex);

            DexterityModfiers = CalculoModificadorDex;

            return CalculoModificadorDex;
        }
        // Gravando Modificador de Constituição
        public int GravarConstitutionModfiers(int value) 
        {
            int ModificadorConst = value;

            int ClaculoModificadorConst = CalcModfiers(ModificadorConst);

            ConstitutionModfiers = ClaculoModificadorConst;

            return ClaculoModificadorConst;
        
        }

        // Gravando Modificador de Inteligencia 
        public int GravarIntelligenceModfiers(int value)
        {
            int ModficadorIntell = value;

            int ClaculoIntell = CalcModfiers(ModficadorIntell);

            return ClaculoIntell;

        }

        // Gravando Modificador de Wisdom (Sabedoria)
        public int GravarWisdomModfiers(int value) 
        {
            int MoficadorWisd = value;

            int ClaculoWisd = CalcModfiers(MoficadorWisd);

            return ClaculoWisd;
        
        }

        // Gravando Modificador de Charisma
        public int GravarCharismaModfiers(int value)
        {
            int ModificadorChar = value;

            int CalculoChar = CalcModfiers(ModificadorChar);
        
            return CalculoChar;
        
        }


        // Metodo para Caucluar os modificadores.
        public int CalcModfiers(int value)
        {

            int Status = value;

            int CharacterModifiers = 0;

            if(Status == 1)
            {

                CharacterModifiers = -5;

                return CharacterModifiers;
            }
            if(Status == 2 || Status == 3 )
            { 
                CharacterModifiers = -4;

                return CharacterModifiers;
            
            }
            if(Status == 4 || Status == 5) 
            {
                CharacterModifiers = -3;
                
                return CharacterModifiers;

            }
            if(Status == 6 || Status == 7)
            {
                CharacterModifiers = -2;

                return CharacterModifiers;

            }
            if(Status == 8 || Status == 9)
            {
                CharacterModifiers = -1;

                return CharacterModifiers;

            }
            if(Status == 10 || Status == 11) 
            {
                CharacterModifiers = 0;

                return CharacterModifiers;
            }
            if(Status == 12 || Status == 13)
            {
                CharacterModifiers = +1;

                return CharacterModifiers;
                
            }
            if(Status == 14 || Status == 15)
            {
                CharacterModifiers += 2;

                return CharacterModifiers;
            }
            if(Status == 16 || Status == 17)
            {
                CharacterModifiers = +3;

                return CharacterModifiers;
            }
            if (Status == 18 || Status == 19) 
            {
                CharacterModifiers = +4;

                return CharacterModifiers; 
            }
            if (Status == 20 || Status == 21)
            { 
                CharacterModifiers = +5;

                return CharacterModifiers;
            }
            if (Status == 22 || Status == 23)
            {
                CharacterModifiers = +6;

                return CharacterModifiers;  
            
            }
            if (Status == 24 || Status == 25) 
            {
                CharacterModifiers = +7;

                return CharacterModifiers;
            }
            if (Status == 26 || Status == 27)
            {
                CharacterModifiers = +8;

                return CharacterModifiers;
            }
            if (Status == 28 || Status == 29)
            {
                CharacterModifiers = +9;

                return CharacterModifiers;
            }

            if (Status == 30)
            {
                CharacterModifiers = +10;

                return CharacterModifiers;
            }
            return 0;
        }



    } 
}

