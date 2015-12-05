using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi.Service
{
	public interface ITamagochi
	{
		void Rename(String newName);

		void Feed();

		void Wash();

		void Play();

		void Sleep();

		void Wakeup();

		String Status();
	}
}
