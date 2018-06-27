using AdaptiveCards;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperBot.Cards.OnboardMe
{
    public class ArchitectureCard
    {
        public static Attachment Architecture()
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
                                       Text = "Architecture",
                                       Size = AdaptiveTextSize.ExtraLarge,
                                       IsSubtle = true,
                                       HorizontalAlignment = AdaptiveHorizontalAlignment.Center,
                                       Weight = AdaptiveTextWeight.Bolder
                                   },
                                   new AdaptiveTextBlock()
                                   {
                                       Text = "Microservices",
                                       Wrap = true,
                                       Size = AdaptiveTextSize.Medium,
                                       Separation = AdaptiveSeparationStyle.None,
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
                                        Text = "What is Microservices? Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla tempor lacus vel pellentesque mollis. Nam id quam at leo iaculis gravida. Aliquam nec est nec lacus porta ultricies vel in magna. Sed placerat accumsan dui eget fermentum. Maecenas blandit lacus nec auctor pretium. Donec et tortor efficitur, placerat libero ac, convallis augue.",
                                        Wrap = true,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Center
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "Impact and Benefits of LCC Microservice",
                                        Wrap = true,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Left,
                                        Spacing = AdaptiveSpacing.Padding,
                                        Weight = AdaptiveTextWeight.Bolder,
                                        Size = AdaptiveTextSize.Default
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "1. Easier implementation of DevOps",
                                        Wrap = true,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Left,
                                        Spacing = AdaptiveSpacing.Small,
                                        Size = AdaptiveTextSize.Default,
                                        Separation = AdaptiveSeparationStyle.None
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "2. Faster deployment of features",
                                        Wrap = true,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Left,
                                        Spacing = AdaptiveSpacing.Small,
                                        Size = AdaptiveTextSize.Default,
                                        Separation = AdaptiveSeparationStyle.None
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "3. Scalability",
                                        Wrap = true,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Left,
                                        Spacing = AdaptiveSpacing.Small,
                                        Size = AdaptiveTextSize.Default,
                                        Separation = AdaptiveSeparationStyle.None
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "4. Cost savings",
                                        Wrap = true,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Left,
                                        Spacing = AdaptiveSpacing.Small,
                                        Size = AdaptiveTextSize.Default,
                                        Separation = AdaptiveSeparationStyle.None
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "5. Reduced risk when introducing changes",
                                        Wrap = true,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Left,
                                        Spacing = AdaptiveSpacing.Small,
                                        Size = AdaptiveTextSize.Default,
                                        Separation = AdaptiveSeparationStyle.None
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "6. Fine-grained scaling",
                                        Wrap = true,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Left,
                                        Spacing = AdaptiveSpacing.Small,
                                        Size = AdaptiveTextSize.Default,
                                        Separation = AdaptiveSeparationStyle.None
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "7. Auto-scaling",
                                        Wrap = true,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Left,
                                        Spacing = AdaptiveSpacing.Small,
                                        Size = AdaptiveTextSize.Default,
                                        Separation = AdaptiveSeparationStyle.None
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "8. Auto-recovery",
                                        Wrap = true,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Left,
                                        Spacing = AdaptiveSpacing.Small,
                                        Size = AdaptiveTextSize.Default,
                                        Separation = AdaptiveSeparationStyle.None
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
                                    new AdaptiveImage()
                                    {
                                        Url = new Uri("http://messagecardplayground.azurewebsites.net/assets/Airplane.png"),
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Center,
                                        Size = AdaptiveImageSize.Large
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