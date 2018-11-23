using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Citizen
    {

        public Citizen(int pasNumber)
        {
            this.passportNumber = pasNumber;
        }

        private readonly int passportNumber;

        public int PassportNumber
        {
            get { return passportNumber; } 
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Citizen ob = (Citizen) obj;
            return this.PassportNumber == ob.PassportNumber;    
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return this.PassportNumber.GetHashCode();
        }
    }

    class Student : Citizen
    {
        public Student(int pasNum) :base(pasNum)
        {
        }
        
    }

    class Pensioner : Citizen
    {
        public Pensioner(int pasNum) : base(pasNum)
        {
        }        
    }

    class Worker : Citizen
    {
        public Worker(int pasNum) : base(pasNum)
        {
        }
    }
}
