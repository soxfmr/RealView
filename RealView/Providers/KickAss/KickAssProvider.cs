using RealView.Core.Provider;
using System;
using Flurl;
using Flurl.Http;
using RealView.Core.Model;
using RealView.Core.Parser;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace RealView.Providers.KickAss
{
    public class KickAssProvider : Provider
    {
        public override string GetName()
        {
            return "KickAssTorrent";
        }

        public override string GetDescription()
        {
            return "KickAssTorrent Provider";
        }

        public override async void Load(string keyword, ParserContract parser)
        {
            var result = await "https://kat.cr/usearch"
                .AppendPathSegment(keyword)
                .WithHeader("Accept-Encoding", "none")
                .WithCookie("user_legal_age", "yes")
                .GetStreamAsync();

            ResourceSet resources = parser.Parse(result);

            NotifyDataChanged(resources);
        }
    }

    
}
