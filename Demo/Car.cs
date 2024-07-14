using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {
        //Access Modifier Allowed Inside Class?
        //Private[Default]
        //Private Protected
        //Protected
        //Internal
        //Protected Internal
        //Public

        #region Properties
        //since we donot need to validate anything we will
        //use the Automatic Property
        private int Id { get; set; } //4 bytes
        private string Model {  get; set; } // 4 bytes for refrence
        private double Speed {  get; set; } // 8 bytes

        #endregion

        #region Constructors

        //Constructor in Class :
        //* If There is no User defined Constructor,
        //Compiler Will Always Generate Empty Parameterless constructor => Will do Nothing.
        //* If You defined a User defined Constructor ,
        //Compiler Will No Longer Generate Empty Parameterless constructor.

        public Car() //Empty Parameterless constructor
        {

            //DoNothing

        } 

        public Car(int id , string model,double speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
                
        }

        //    public Car (int id , string model) : this(id,model,190) => constructor chanining

        public Car (int id , string model) : this(id,model,190)
        {
            //Id = id;
            //Model = model;
            //Speed = 190;

        }
        public Car(int id) : this(id,"Audi",200)
        {
            //Id = id;
            //Model = "Audi";
            //Speed = 200;

        }


        #endregion
        public override string ToString()
        {
            return $"CarId : {Id}\nModel: {Model}\nSpeed : {Speed}";
        }


    }
}
