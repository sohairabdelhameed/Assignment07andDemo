using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encapsulation
{
    internal struct PhoneBook
    {
        #region Attributes
       private string [] Names;
       private int [] Numbers;
      // private int size; //to know the phonebook contains how many pages


        #endregion

        #region Properties

        public int Size { get; } //ReadOnly Property


        #endregion

        #region Constructor
        public PhoneBook(int size)
        {
            Size = size;
            Names = new string[Size];
            Numbers = new int[Size];

        }
        #endregion

        #region Getter - Setter
        
        //Get
        public int GetPersonNumbers(string PersonName)
        {
            if(Names is not null && Numbers is not null)
            {
                for(int i = 0;i < Numbers.Length; i++)
                {
                    if (Names[i] == PersonName)
                    {
                        return Numbers[i];
                    }
                }
            }
            return -1;
        }

        //Set
        public void SetPersonNumber(string PersonName, int NewNumber) 
        {
            if (Names is not null && Numbers is not null)
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    if (Names[i].Equals(PersonName))
                    {
                        Numbers[i] = NewNumber;
                        break;
                    }

                }


            }

        }
        #endregion

        #region Methods
        //Add person To NoteBook
        //public void AddPerson(int Position,string PersonName,int PhoneNumber)
        //{
        //    Names[Position] = PersonName;
        //    Numbers[Position] = PhoneNumber;



        //} //Not Protective Code

        //Add person To NoteBook with Protective code
        public void AddPerson(int Position, string PersonName, int PhoneNumber)
        {
            if(Names is not null && Numbers is not null)
            {
                if(Position < Size)
                {
                    Names[Position] = PersonName;
                    Numbers[Position] = PhoneNumber;

                }
               

            }
            



        }
        #endregion

        #region Indexer
        //Special Property
        //1. Named With Keyword "This"
        //2. Can take Parameters

        // We want to acheive => Note["Ali"]
        public int this[string name]
        {
            get
            {
                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < Numbers.Length; i++)
                    {
                        if (Names[i] == name)
                        {
                            return Numbers[i];
                        }
                    }
                }
                return -1;

            }
            set
            {
                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < Names.Length; i++)
                    {
                        if (Names[i].Equals(name))
                        {
                            Numbers[i] = value ;
                            break;
                        }

                    }


                }

            }
        }

        // 0  ::  Sohair  :: 123
        //Indexing Overloading
        
        public string this[ int index]
        {
            //ReadOnly Indexer
            get
            {
                return $"{index} :: {Names[index]} :: {Numbers[index]}";

            }
        }


        #endregion

    }
}
