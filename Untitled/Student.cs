using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5.Untitled
{
	public class Student : User
	{
		string socialMedianame { get; set; }

		string name { get; set; }

		public Student(string name) : base(name)
		{
			this.name = name;
		}
		private void regHold()
		{
			throw new NotImplementedException();
		}

		public string viewProfile()
		{
			throw new NotImplementedException();
		}

		private string courseList()
		{
			throw new NotImplementedException();
		}

        public override string setContact()
        {
            throw new NotImplementedException();
        }

        public override string setName()
        {
            throw new NotImplementedException();
        }
    }
}
