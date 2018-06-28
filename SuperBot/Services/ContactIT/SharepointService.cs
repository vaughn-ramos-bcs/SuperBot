using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web;
using System.Web.Configuration;
using Microsoft.SharePoint.Client;

namespace SuperBot.Services.ContactIT
{
    public class SharepointService
    {
        public static void SharepointConnector(string url)
        {
            //ClientContext context = new ClientContext(url);
            //Web web = context.Web;
            //context.Load(web);
            //context.ExecuteQuery();

            //var a = web;

            string email, password,uri;
            email = WebConfigurationManager.AppSettings["Email"];
            password = WebConfigurationManager.AppSettings["Password"];
            uri = WebConfigurationManager.AppSettings["Uri"];

            Uri siteUri = new Uri(url);
            //string realm = TokenHelper.GetRealmFromTargetUrl(siteUri);

            //string accessToken = TokenHelper.GetAppOnlyAccessToken(TokenHelper.SharePointPrincipal,
            //                                                        siteUri.Authority, realm).AccessToken;
            //ClientContext context = new ClientContext(siteUri);
  
            SecureString pw = new SecureString();

            Array.ForEach(password.ToCharArray(), pw.AppendChar); 
            using (var context = new ClientContext(siteUri))
            {

                context.Credentials = new SharePointOnlineCredentials(email, pw);
                context.ExecuteQuery();
                Web web = context.Web;


                //context.Load(web, w => w.Title, w => w.Lists, w => w.Navigation, w => w.QuickLaunchEnabled, w => w.Navigation.QuickLaunch, w => w.ListTemplates, w => w.ParentWeb);
                //context.ExecuteQuery();

                //bool aa = context.Web.IsObjectPropertyInstantiated("Lists");
                //bool bb = context.Web.IsPropertyAvailable("Title");
                //var b = web.Title;
                //var a = web;


                List list = context.Web.Lists.GetByTitle("My IT Helpdesk Request");
                context.Load(list);
                context.ExecuteQuery();
                try
                {
                    ListItemCreationInformation itemCreateInfo = new ListItemCreationInformation();
                    ListItem newItem = list.AddItem(itemCreateInfo);
                    newItem["Title"] = "[Super Bot] - Test";
                    //newItem["Description"] = "Will delete right away";
                    newItem.Update();

                    context.ExecuteQuery();
                }
                catch (Exception ex)
                {

                }

                #region Clutter

                //View view = list.Views.GetByTitle("All Items");

                //context.Load(view);
                //context.ExecuteQuery();
                //CamlQuery query = new CamlQuery();
                //query.ViewXml = view.ViewQuery;

                //ListItemCollection items = list.GetItems(query);
                //context.Load(items);
                //context.ExecuteQuery();


                //ctx.Load(ctx.Web, w => w.Title);
                //ctx.ExecuteQuery();
                ////Results:
                //ctx.Web.IsObjectPropertyInstantiated("Lists")  False
                //ctx.Web.IsPropertyAvailable("Title")


                //var test = web.Lists.GetByTitle("My IT Helpdesk Request");
                //List test2 = web.Lists.;
                //test.Data
                //context.Load(test);
                //foreach (var test3 in test2)
                //{
                //    //if (test2.Any() => test2. "My IT Helpdesk Request")
                //    //{
                //    //    context.Load(test2);
                //    //}
                //    var test3 = test
                //    //if (test2.Any(v => v.Title == "My IT Helpdesk Request" ))
                //} 

                //context.Load(test, t => t.Title);
                //var tt = test;
                ////List test = web.Lists.GetByTitle("Philippines");
                ////context.Load(test);

                //NavigationNodeCollection topNavigationColl = web.Navigation.TopNavigationBar;

                //context.Load(topNavigationColl);
                //List x = web.Lists.GetByTitle("BCS-IT Manila Helpdesk");
                //context.Load(x);

                //NavigationNodeCollection qlNavNodeColl = context.Web.Navigation.QuickLaunch;
                //NavigationNode projectsNode = qlNavNodeColl.Where(n => n.Title == "BCS-IT Manila Helpdesk").FirstOrDefault();
                //var a2 = projectsNode;

                //var nn = x;
                //List<string> get = new List<string>();
                //foreach(Web oW in web.Webs)
                //{
                //    string p = "https://bcstechinternational.sharepoint.com/" + web.ServerRelativeUrl;
                //    get.Add(p + "/n" + web.Title);
                //}
                //var ss = get;

                //context.ExecuteQuery();
                //var c = topNavigationColl;
                //client.Load(ChangeRequestList);

                #endregion
            }
        }
    }
}

