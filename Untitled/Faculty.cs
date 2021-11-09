using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5.Untitled
{
	public class Faculty : User
	{
		int roomNumber { get; set; }

		string name { get; set; }

        public Faculty(string name) : base(name)
		{
			this.name = name;
		}

		public string getOfficehours()
		{
			throw new NotImplementedException();
		}
	}
}
