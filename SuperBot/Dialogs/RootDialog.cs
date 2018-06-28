using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using SuperBot.Cards;
using SuperBot.Cards.OnboardMe;
using SuperBot.Models;
using SuperBot.Services;

namespace SuperBot.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        public async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var activity = await result as Activity;            
            var message = activity.Text.ToString().ToLower();

            if (message != null)
            {
                try
                {
                    #region alternative
                    //await DialogHelper.Check(context, result);
                    //switch (message)
                    //{
                    //    //case "ask hr":
                    //    //case "contact it":
                    //    //case "contact graphic team":
                    //    //case "file leave":
                    //    //case "get payslip":
                    //    case "onboard me":
                    //        await context.Forward(new OnboardMeDialog(), ResumeAfterModuleDialog, message, CancellationToken.None);
                    //        return;

                    //    default:
                    //        await context.PostAsync("I didn't understand. Can you try again.");
                    //        return;
                    //}
                    #endregion

                    if (message.Contains("onboard me"))
                        await context.Forward(new OnboardMeDialog(), ResumeAfterModuleDialog, message, CancellationToken.None);
                    else if (message.Contains("contact it"))
                        await context.Forward(new ContactITDialog(), ResumeAfterModuleDialog, message, CancellationToken.None);
                    else if(message.Contains("restart") || message.Contains("stop") || message.Contains("go back") || message.Contains("options"))
                    {
                        var compose = context.MakeMessage();
                        compose.Attachments.Add(WelcomeCard.Welcome());

                        await context.PostAsync(compose, CancellationToken.None);
                    }
                    else
                    {
                        await context.PostAsync("I didn't understand. Can you try again.");
                    }

                }
                catch(Exception ex)
                {
                    await context.PostAsync("Oops! Something went wrong. Please try again");
                }
            }

            return;
                
        }

        private async Task ResumeAfterModuleDialog(IDialogContext context, IAwaitable<object> result)
        {
            //context.Wait(MessageReceivedAsync);
            await context.PostAsync("Leave your comments/suggestion to improve your experience!");
        }
        #region privates
        //Adaptive card will be used instead of Prompt.Choice
        private IEnumerable<string> GetModules()
        {
            var modules = new List<string>()
            {
                "Ask HR",
                "Contact IT",
                "Contact Graphic Team",
                "File Leave",
                "Get Payslip",
                "Onboard Me"
            };

            return modules;
        }
        #endregion

       
    }
}