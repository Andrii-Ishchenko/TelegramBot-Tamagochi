using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Tamagochi.Server
{
	class Program
	{
		static void Main(string[] args)
		{
			Run().Wait();
		}

		static async Task Run()
		{
			var Bot = new Api("160372642:AAEPQPrjQd7xwabWDdKcLR9JpkUcCsAboMQ");
			var me = await Bot.GetMe();

			Console.WriteLine("Hello my name is {0}", me.Username);

			var offset = 0;

			while (true)
			{
				var updates = await Bot.GetUpdates(offset);
				
				foreach(var update in updates)
				{
					//ReplyKeyboardMarkup rm = new ReplyKeyboardMarkup();
					//rm.Keyboard =new string[][]{
					//	new string[]{ "a", "b" },
					//	new string[]{ "c", "d" }
					//};
					//rm.ResizeKeyboard = true;
					//rm.OneTimeKeyboard = true;

					//var t =  Bot.SendTextMessage(update.Message.Chat.Id, update.Message.Text,false,0,rm);

					var t = Bot.SendTextMessage(update.Message.Chat.Id, update.Message.Text);
					Console.WriteLine("Message :{0} \tUser Id: {1}", update.Message.Text,update.Message.From.Id);
					offset = update.Id + 1;
				
				}

				await Task.Delay(1000);
			}
		}
	}
}
