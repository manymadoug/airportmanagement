using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public string PassportNumber { get; set; }
        public string FirstName { get; set; }
        public int Id { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }
        public int? TelNumber { get; set; }
        public string? EmailAddress { get; set; }

        public IList<Flight> Flights { get; set; }
        /*public bool CheckProfile(string firstName, string lastName)
        {
            return FirstName==firstName&& LastName == lastName;
        }
        public bool CheckProfile(string firstName, string lastName, string email)
        {
            return FirstName == firstName && LastName == lastName && EmailAddress == email;
        }*/
        public bool CheckProfile(string firstName, string lastName, string email)
        {
            if(email!=null)
            {
                return FirstName == firstName && LastName == lastName;
            }else
            {
                return FirstName == firstName && LastName == lastName && EmailAddress == email;
            }

        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I am Passenger");
        }


        public override string ToString()
        {
            return "PassportNumber" + PassportNumber + "FirstName: " + FirstName + " LastName: " + LastName + " date ofBirth: "+ BirthDate;
}
    }
}
