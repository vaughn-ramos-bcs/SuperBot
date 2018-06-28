using AdaptiveCards;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperBot.Cards
{
    public class WelcomeCard
    {
        public static Attachment Welcome()
        {
            AdaptiveCard adaptiveCards = new AdaptiveCard()
            {
                Body = new List<AdaptiveElement>()
                {
                    new AdaptiveTextBlock()
                    {
                        Text = "Hi! \U0001F60A Welcome to the Super Bot. I'll assist you in every way I can. \U00002708 What would you like to do?",
                        Wrap = true
                    }
                },
                Actions = new List<AdaptiveAction>()
                {
                    new AdaptiveSubmitAction()
                    {
                        Title = "Ask HR",
                        Data = "Ask HR"
                    },
                    new AdaptiveSubmitAction()
                    {
                        Title = "Contact IT",
                        Data = "Contact IT"
                    },
                    new AdaptiveSubmitAction()
                    {
                        Title ="Contact Graphic Team",
                        Data = "Contact Graphic Team"
                    },
                    new AdaptiveSubmitAction()
                    {
                        Title = "File Leave",
                        Data = "File Leave"
                    },
                    new AdaptiveSubmitAction()
                    {
                        Title = "Get Payslip",
                        Data = "Get Payslip"
                    },
                    new AdaptiveSubmitAction()
                    {
                        Title = "Onboard Me",
                        Data = "Onboard Me"
                    }
                }
            };

            Attachment attachment = new Attachment()
            {
                ContentType = AdaptiveCard.ContentType,
                Content = adaptiveCards
            };

            return attachment;
        }
    }
}