using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Helpers
{
    public static class NavigationManagerExtension
    {
        public static Dictionary<string, string> GetQueryStrings(
            this NavigationManager navigationManager, string url)
        {
            if (string.IsNullOrWhiteSpace(url) || !url.Contains("?") || url.Substring(url.Length-1)=="?")
            {
                return null;
            }
            //https://domain.com?key=value1&key2=values2
            var quertStrings = url.Split(new string[] { "?" }, StringSplitOptions.None)[1];
            Dictionary<string, string> dicQueryString =
                quertStrings.Split('&').ToDictionary(c => c.Split('=')[0],
                                                     c => Uri.UnescapeDataString(c.Split('=')[1]));
            return dicQueryString;
        }
    }
}
