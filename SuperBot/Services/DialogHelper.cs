using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using SuperBot.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace SuperBot.Services
{
    public class DialogHelper
    {
        public static async Task Check(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var activity = await result as Activity;
            var message = activity.Text.ToString().ToLower();

            if (message.Contains("restart") || message.Contains("stop") || message.Contains("go back"))
            {
                var compose = context.MakeMessage();
                compose.Attachments.Add(WelcomeCard.Welcome());

                await context.PostAsync(compose, CancellationToken.None);
                
            }
        }
    }
}