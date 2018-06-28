using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using SuperBot.Services.ContactIT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;

namespace SuperBot.Dialogs
{
    [Serializable]
    public class ContactITDialog : IDialog<object>
    {
        public async Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);
        }
        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
           SharepointService.SharepointConnector(WebConfigurationManager.AppSettings["Uri"]);
            //await context.PostAsync("try");
        }
    }
}