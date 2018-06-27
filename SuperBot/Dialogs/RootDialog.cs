using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using SuperBot.Cards.OnboardMe;

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

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var activity = await result as Activity;

            var message = await result;
            if (activity.Text != null)
                PromptDialog.Choice(context, ShowProcessAsync, new List<string>() { "Onboard Me", "Ask HR", "Contact IT", "File Leave", "Get Payroll" }, "Hi, I am Super Bot!");

        }
        private async Task ShowProcessAsync(IDialogContext context, IAwaitable<string> result)
        {
            var res = Convert.ToString(await result);
            if (res.ToLower() == "onboard me")
            {
                PromptDialog.Confirm(context, ConfirmAsync, "Are you deployed to a project?");
            }
            else
            {
                await context.PostAsync("Not Implemented yet.");
            }
        }
        private async Task ConfirmAsync(IDialogContext context, IAwaitable<bool> result)
        {
            var res = await result;
            if (res is true)
            {
                var message = context.MakeMessage();
                message.Attachments.Add(OverviewCard.Overview());

                await context.PostAsync(message, CancellationToken.None);

                PromptDialog.Text(context, OverviewAsync, "Any question?");
            }
            else
            {
                await context.PostAsync("Please ask your manager. You may try again later.");
            }
        }

        private async Task OverviewAsync(IDialogContext context, IAwaitable<string> result)
        {

            if (result != null || !string.IsNullOrWhiteSpace(result.ToString()))
            {
                var message = context.MakeMessage();
                message.Attachments.Add(TechStackCard.TechStack());

                await context.PostAsync(message, CancellationToken.None);
                PromptDialog.Text(context, ArchitectureAsync, "Got it?");
            }

        }

        private async Task ArchitectureAsync(IDialogContext context, IAwaitable<string> result)
        {
            if (result != null || !string.IsNullOrWhiteSpace(result.ToString()))
            {
                var message = context.MakeMessage();
                message.Attachments.Add(ArchitectureCard.Architecture());

                await context.PostAsync(message, CancellationToken.None);
                PromptDialog.Text(context, ExpectationAsync, "Understand?");
            }
        }

        private async Task ExpectationAsync(IDialogContext context, IAwaitable<string> result)
        {
            if (result != null || !string.IsNullOrWhiteSpace(result.ToString()))
            {
                var message = context.MakeMessage();
                message.Attachments.Add(ExpectationCard.Expectation());

                await context.PostAsync(message, CancellationToken.None);
                PromptDialog.Text(context, SetupAsync, "Question?");
            }
        }

        private async Task SetupAsync(IDialogContext context, IAwaitable<string> result)
        {
            if (result != null || !string.IsNullOrWhiteSpace(result.ToString()))
            {
                var message = context.MakeMessage();
                message.Attachments.Add(SetupCard.Setup());

                await context.PostAsync(message, CancellationToken.None);
                PromptDialog.Text(context, LastAsync, "Any concern/help needed?");
            }
        }

        private async Task LastAsync(IDialogContext context, IAwaitable<string> result)
        {
            if (result != null || !string.IsNullOrWhiteSpace(result.ToString()))
            {
                await context.PostAsync("That's Great! \U0001F601 Congratulations and Welcome to Technology.");
                await context.PostAsync("You may now tap your manager/lead for task assignment");
            }
        }
    }
}