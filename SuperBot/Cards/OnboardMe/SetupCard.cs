using AdaptiveCards;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperBot.Cards.OnboardMe
{
    public class SetupCard
    {
        public static Attachment Setup()
        {
            AdaptiveCard adaptiveCard = new AdaptiveCard()
            {
                Body = new List<AdaptiveElement>()
                {
                    new AdaptiveColumnSet()
                    {
                        Separator = true,
                        Columns = new List<AdaptiveColumn>()
                        {
                            new AdaptiveColumn()
                            {
                                Items = new List<AdaptiveElement>()
                                {
                                   new AdaptiveTextBlock()
                                   {
                                       Text = "Setup Dev Environment",
                                       Size = AdaptiveTextSize.ExtraLarge,
                                       IsSubtle = true,
                                       HorizontalAlignment = AdaptiveHorizontalAlignment.Center,
                                       Weight = AdaptiveTextWeight.Bolder
                                   }
                                }
                            }
                        }
                    },
                    new AdaptiveColumnSet()
                    {
                        Columns = new List<AdaptiveColumn>()
                        {
                            new AdaptiveColumn()
                            {
                                Items = new List<AdaptiveElement>()
                                {
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "1) Download and Install Visual Studio 2017",
                                        Wrap = true,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Center
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "2) Download and Install Docker for Windows",
                                        Wrap = true,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Center
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "3) Configure NSQ for Windows",
                                        Wrap = true,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Center
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "4) Download and Install Kubernetes for Windows",
                                        Wrap = true,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Center
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "5) Download and Install Microsoft Azure SDK for Windows",
                                        Wrap = true,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Center
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "6) Download and Install Git for Windows",
                                        Wrap = true,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Center
                                    }

                                }
                            }
                        }
                    }
                }
            };

            Attachment attach = new Attachment()
            {
                ContentType = AdaptiveCard.ContentType,
                Content = adaptiveCard
            };

            return attach;

        }

    }
}