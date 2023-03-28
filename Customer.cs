using System;
using System.Collections.Generic;
namespace PianoDataApp
{
	public class Customer : PianoType
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
      

        public Customer(string FirstName, string LastName, string Email, string Address, string Brand, string Model, string Serial, string Age)
		{
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.Email = Email;
			this.Address = Address;
			PianoBrand = Brand;
			PianoModel = Model;
			PianoSerialNumber = Serial;
			PianoAge = Age;
        }

		public override string ToString()
		{
			return "First Name: " + FirstName + "   Last Name: " + LastName + "   Email: " + Email + "   Address: " + Address + "   Piano Brand: " + PianoBrand + "   Piano Model: " + PianoModel + "   Serial Number: " + PianoSerialNumber + "   Piano Age: " + PianoAge;
		}
	}
}

