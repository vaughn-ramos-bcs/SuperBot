using AdaptiveCards;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperBot.Cards.OnboardMe
{
    public class OverviewCard
    {
        public static Attachment Overview()
        {
            AdaptiveCard card = new AdaptiveCard();

            var Title = new AdaptiveTextBlock()
            {
                Text = "Overview",
                HorizontalAlignment = AdaptiveHorizontalAlignment.Center,
                Weight = AdaptiveTextWeight.Bolder,
                Size = AdaptiveTextSize.ExtraLarge
            };

            var T2 = new AdaptiveTextBlock()
            {
                Text = "Project: Lorem Ipsum",
                Size = AdaptiveTextSize.Large,
                Weight = AdaptiveTextWeight.Normal,
                HorizontalAlignment = AdaptiveHorizontalAlignment.Center
            };


            var body = new AdaptiveTextBlock()
            {
                Text = " is a web service Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla tempor lacus vel pellentesque mollis. Nam id quam at leo iaculis gravida. Aliquam nec est nec lacus porta ultricies vel in magna. Sed placerat accumsan dui eget fermentum. Maecenas blandit lacus nec auctor pretium. Donec et tortor efficitur, placerat libero ac, convallis augue. Nunc in purus nec turpis porttitor placerat. Pellentesque blandit, tortor vel hendrerit bibendum, massa velit egestas turpis, vitae suscipit neque eros non quam. Pellentesque id accumsan elit. Nunc nec posuere orci, sed eleifend nulla. Etiam sit amet lacinia sapien. Cras malesuada mollis placerat. In mollis turpis sed luctus vehicula. Suspendisse semper purus non fermentum eleifend.",
                Wrap = true,
                HorizontalAlignment = AdaptiveHorizontalAlignment.Center
            };

            var body2 = new AdaptiveTextBlock()
            {
                Text = " is a web service Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla tempor lacus vel pellentesque mollis. Nam id quam at leo iaculis gravida. Aliquam nec est nec lacus porta ultricies vel in magna. Sed placerat accumsan dui eget fermentum. Maecenas blandit lacus nec auctor pretium. Donec et tortor efficitur, placerat libero ac, convallis augue. Nunc in purus nec turpis porttitor placerat. Pellentesque blandit, tortor vel hendrerit bibendum, massa velit egestas turpis, vitae suscipit neque eros non quam.",
                Wrap = true,
                HorizontalAlignment = AdaptiveHorizontalAlignment.Center,
                Spacing = AdaptiveSpacing.Padding
            };

            var body3 = new AdaptiveTextBlock()
            {
                Text = "Got it?",
                Color = AdaptiveTextColor.Accent,
                Size = AdaptiveTextSize.ExtraLarge,
                HorizontalAlignment = AdaptiveHorizontalAlignment.Center,
                Weight = AdaptiveTextWeight.Bolder,
                Spacing = AdaptiveSpacing.Medium,
                Separator = true
            };

            card.Body.Add(Title);
            card.Body.Add(T2);
            card.Body.Add(body);
            card.Body.Add(body2);
            card.Body.Add(body3);


            Attachment attachment = new Attachment()
            {
                ContentType = AdaptiveCard.ContentType,
                Content = card
            };


            return attachment;
        }
    }
}