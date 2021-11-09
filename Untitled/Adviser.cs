using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5.Untitled
{
	public class Adviser : User
	{
		string name { get; set; } 

		public Adviser(string name) : base (name)
        {
			this.name = name;
        }
		public string advisingHours()
		{
			throw new NotImplementedException();
		}
	}
}
