using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SeverinoBot
{
    public static class MessageController
    {
        public static async Task OnMessageCreated(MessageCreateEventArgs e)
        {
            if (!e.Message.Author.IsBot && !e.Message.Content.Trim().StartsWith("-"))
            {
                string mensagem = e.Message.Content.Trim();

                if (mensagem.ToLower().Equals("free fire"))
                {
                    await e.Message.RespondAsync("salve tropa", e.Message.IsTTS);
                }

                await e.Message.RespondAsync(ParseLaugh(mensagem));
                return;
            }
        }

        private static string ParseLaugh(string message)
        {
            StringBuilder Laugh = new StringBuilder();

            for(int i = 0; i < GetWordCount(message); i++)
                Laugh.Append("kappa ");

            return Laugh.ToString();
        }

        private static int GetWordCount(string message)
        {
            return message.Split(' ').Length;
        }
    }
}
