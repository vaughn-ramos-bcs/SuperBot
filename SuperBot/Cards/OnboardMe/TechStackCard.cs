using AdaptiveCards;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperBot.Cards.OnboardMe
{
    public class TechStackCard
    {
        public static Attachment TechStack()
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
                                       Text = "Tech Stack",
                                       Size = AdaptiveTextSize.ExtraLarge,
                                       IsSubtle = true,
                                       HorizontalAlignment = AdaptiveHorizontalAlignment.Center,
                                       Weight = AdaptiveTextWeight.Bolder
                                   },
                                   new AdaptiveTextBlock()
                                   {
                                       Text = "Architecture: Microservices",
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
                        Spacing = AdaptiveSpacing.Medium,
                        Separator = true,
                        Columns = new List<AdaptiveColumn>()
                        {
                            new AdaptiveColumn()
                            {
                                Items = new List<AdaptiveElement>()
                                {
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "Development",
                                        Size = AdaptiveTextSize.Medium,
                                        Weight = AdaptiveTextWeight.Bolder,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Left
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "1. .Net Core 2.0",
                                        Wrap = true,
                                        Separation = AdaptiveSeparationStyle.None,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Left
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "2. Microsoft Azure",
                                        Wrap = true,
                                        Separation = AdaptiveSeparationStyle.None,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Left
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "3. NSQ",
                                        Wrap = true,
                                        Separation = AdaptiveSeparationStyle.None,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Left
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "4. Docker",
                                        Wrap = true,
                                        Separation = AdaptiveSeparationStyle.None,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Left
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "Data Analytics",
                                        Size = AdaptiveTextSize.Medium,
                                        Weight = AdaptiveTextWeight.Bolder,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Left
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "1. Sumologic",
                                        Wrap = true,
                                        Separation = AdaptiveSeparationStyle.None,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Left
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "2. Grafana",
                                        Wrap = true,
                                        Separation = AdaptiveSeparationStyle.None,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Left
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "3. StatsD",
                                        Wrap = true,
                                        Separation = AdaptiveSeparationStyle.None,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Left
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "4. Graphite",
                                        Wrap = true,
                                        Separation = AdaptiveSeparationStyle.None,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Left
                                    }

                                }
                            },
                            new AdaptiveColumn()
                            {
                                Items = new List<AdaptiveElement>()
                                {
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "Deployment",
                                        Size = AdaptiveTextSize.Medium,
                                        Weight = AdaptiveTextWeight.Bolder,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Center
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "1. Kubernetes",
                                        Wrap = true,
                                        Separation = AdaptiveSeparationStyle.None,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Center
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "2. Jenkins",
                                        Wrap = true,
                                        Separation = AdaptiveSeparationStyle.None,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Center
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "Framework",
                                        Size = AdaptiveTextSize.Medium,
                                        Weight = AdaptiveTextWeight.Bolder,
                                        Spacing = AdaptiveSpacing.ExtraLarge,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Center
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "1. Prometheus",
                                        Wrap = true,
                                        Separation = AdaptiveSeparationStyle.None,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Center
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "2. Navitaire NewSkies",
                                        Wrap = true,
                                        Separation = AdaptiveSeparationStyle.None,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Center
                                    }
                                }
                            },
                            new AdaptiveColumn()
                            {
                                Items = new List<AdaptiveElement>()
                                {
                                     new AdaptiveTextBlock()
                                    {
                                        Text = "Version Control",
                                        Size = AdaptiveTextSize.Medium,
                                        Weight = AdaptiveTextWeight.Bolder,
                                        Spacing = AdaptiveSpacing.ExtraLarge,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Right
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "1. Git/Github",
                                        Wrap = true,
                                        Separation = AdaptiveSeparationStyle.None,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Right
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "Approach",
                                        Size = AdaptiveTextSize.Medium,
                                        Weight = AdaptiveTextWeight.Bolder,
                                        Spacing = AdaptiveSpacing.ExtraLarge,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Right
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "1. TDD",
                                        Wrap = true,
                                        Separation = AdaptiveSeparationStyle.None,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Right
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "2. Agile",
                                        Wrap = true,
                                        Separation = AdaptiveSeparationStyle.None,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Right
                                    },
                                    new AdaptiveTextBlock()
                                    {
                                        Text = "3. Scrum",
                                        Wrap = true,
                                        Separation = AdaptiveSeparationStyle.None,
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Right
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
                                        Text = "Any Questions?",
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