using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5.Untitled
{
	public class Faculty : User
	{
        private static int ID;

        int roomNumber { get; set; }

		string name { get; set; }


		public Faculty(int roomNumber, string name): base (ID)
		{
			this.roomNumber = roomNumber;
			this.name = name;
		}

		public override string setContact()
        {
			return name;
        }

        public Faculty(string name) : base(name)
		{
			this.name = name;
		}


        public string getOfficehours()
		{
			throw new NotImplementedException();
		}

        public override string setName()
        {
            throw new NotImplementedException();
        }
    }
}
