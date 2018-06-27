using AdaptiveCards;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperBot.Cards.OnboardMe
{
    public class ExpectationCard
    {
        public static Attachment Expectation()
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
                                       Text = "What to expect",
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
                                       Text = "Booking and Price Quotation are still being converted to Microservices architecture Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla tempor lacus vel pellentesque mollis. Nam id quam at leo iaculis gravida. Aliquam nec est nec lacus porta ultricies vel in magna. Sed placerat accumsan dui eget fermentum. Maecenas blandit lacus nec auctor pretium. Donec et tortor efficitur, placerat libero ac, convallis augue.",
                                       Wrap = true,
                                       HorizontalAlignment = AdaptiveHorizontalAlignment.Center
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
                                        Text = "Got it?",
                                        Color = AdaptiveTextColor.Accent,
                                        Size = AdaptiveTextSize.ExtraLarge,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Center,
                                        Weight = AdaptiveTextWeight.Bolder,
                                        Separator = true
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