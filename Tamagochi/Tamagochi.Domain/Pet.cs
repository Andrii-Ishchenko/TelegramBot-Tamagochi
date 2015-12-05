using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi.Domain
{
	public class Pet
	{
		public int Id { get; set; }

		public int UserId { get; set; }

		public String Name { get; set; }

		public DateTime CreationDate { get; set; }

		public virtual List<Activity> Activity { get; set; }
	}
}
