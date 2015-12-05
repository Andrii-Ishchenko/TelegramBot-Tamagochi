using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagochi.Domain;

namespace Tamagochi.Service
{
	public class Tamagochi : ITamagochi
	{

		public Pet Pet { get; private set; }

		public Tamagochi()
		{
			//get pet here
		}


		public void Feed()
		{
			if (Pet != null)
			{

			}
		}

		public void Play()
		{
			if (Pet != null)
			{

			}
		}

		public String Status()
		{
			return "OK!";

			if (Pet != null)
			{

			}
		}

		public void Sleep()
		{
			if (Pet != null)
			{

			}
		}

		public void Wash()
		{
			if (Pet != null)
			{

			}
		}

		public void Wakeup()
		{
			if (Pet != null)
			{

			}
		}

		public void Rename(string newName)
		{
			if (Pet != null)
			{
				Pet.Name = newName;
			}
		}
	}
}
