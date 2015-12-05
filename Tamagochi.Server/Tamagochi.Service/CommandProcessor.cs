using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagochi.DAL;
using Tamagochi.Domain;
using Telegram.Bot.Types;

namespace Tamagochi.Service
{
	public class CommandProcessor
	{

		public Dictionary<int, ChatActionEnum> LastChatAction = new Dictionary<int, ChatActionEnum>();

		public CommandProcessor()
		{
			
		}

		public void Process(Update update)
		{
			var UserId = update.Message.From.Id;
			
			
		}

	}
}
