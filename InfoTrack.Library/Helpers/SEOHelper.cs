using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace InfoTrack.Library.Helpers
{
    public class SEOHelper : ISEOHelper
    {
        /// <summary>
        /// Returns a list of rankings for a url for the supplied keywords
        /// </summary>
        /// <param name="url"></param>
        /// <param name="keywords"></param>
        /// <returns>A list of integers corresponding to the rankings</returns>
        public List<int> GetRankings(string url, string keywords)
        {
            var rankings = new List<int>();
            
            var client = new WebClient();
            // fake the user agent
            client.Headers["User-Agent"] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.212 Safari/537.36";
            var googleSearchResults = client.DownloadString($"https://www.google.co.uk/search?num=100&q={HttpUtility.UrlEncode(keywords)}");

            var searchExpression = @"<h3.*?>.*?</h3>.*?<cite.*?>(\b(?:https?://|www\.)\S+\b).*?</cite>";

            var regEx = new Regex(searchExpression);

            int rank = 1;

            foreach (Match match in regEx.Matches(googleSearchResults))
            {
                if (match.Groups[1].Value.Contains(url))
                    rankings.Add(rank);
                        
                rank++;
            }

            return rankings;
        }
    }
}
