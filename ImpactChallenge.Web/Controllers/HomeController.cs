using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using ImpactChallenge.Web.Models;

namespace ImpactChallenge.Web.Controllers
{
    public class HomeController : Controller
    {
        private const string DefaultFeedUrl = "https://api.foxsports.com/v1/rss?partnerKey=zBaFxRyGKCfxBagJG9b8pqLyndmvo7UU";

        public ActionResult Index(string url = null)
        {
            if (ViewBag.Url == null)
            {
                ViewBag.Url = DefaultFeedUrl;
            }

            return View();
        }

        public ActionResult UpdateFeed(string url)
        {
            if (!ValidUrl(url))
            {
                return HttpNotFound("Not a valid URL");
            }

            return Json(FetchFeed(url), JsonRequestBehavior.AllowGet);
        }

        private IEnumerable<FeedItem> FetchFeed(string url)
        {
            var reader = XmlReader.Create(url);
            var feed = SyndicationFeed.Load(reader);
            reader.Close();

            var result = new List<FeedItem>();

            foreach (var feedItem in feed.Items)
            {
                var myFeedItem = new FeedItem
                {
                    Title = feedItem.Title.Text,
                    Link = feedItem.Id,
                    PublishDate = feedItem.PublishDate.ToString()
                };
                
                result.Add(myFeedItem);
            }
            return result;
        }

        private static bool ValidUrl(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out var uriResult)
                   && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }
    }
}