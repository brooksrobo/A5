using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5.Untitled
{
	public class User
	{
		int ID { get; set; }
		string Name { get; set; }

		public User(string name)
        {
			this.Name = name;
        }

		public User (int id)
        {
			this.ID = id;
        }


		public string setContact()
		{
			throw new NotImplementedException();
		}

		private string setName()
		{
			throw new NotImplementedException();
		}
	}
}
