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

            //Construtor
            public MotherSheet(string Name, int ArmorClass, int Strength ,int Dexterity, int Constitution, int Intelligence, int Wisdom, int Charisma )
            {
                this.CharacterName = Name;
                this.CharacterArmorClass = ArmorClass;

                this.CharacterStrength = Strength;
                this.CharacterDexterity = Dexterity;
                this.CharacterConstitution = Constitution;
                this.CharacterIntelligence = Intelligence;
                this.CharacterWisdom = Wisdom;
                this.CharacterCharisma = Charisma;
            }


        // GET SET Estilo JAVA
            public string GetCharacterName()
            {
                  return CharacterName; 
  
            }

            public void SetCharacterName(string name) 
            { 
                this.CharacterName = name;
            }


        
        // GET SET 1
            public string _CharacterName 
            {
                get { return CharacterName; }
                set { CharacterName = value; }
            }

        // GET SET 2

            public int _CharacterArmorClass { get; set; }
        
        }
    }

