using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi.Domain
{
	public class Activity
	{
		public int Id { get; set; }

		public int PetId { get; set; }

		public string Command { get; set; }

		public DateTime Date { get; set; }

		public virtual Pet Pet { get; set; }
	}
}
