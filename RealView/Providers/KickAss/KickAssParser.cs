using Newtonsoft.Json;
using RealView.Core.Model;
using RealView.Core.Parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace RealView.Providers.KickAss
{
    public class KickAssParser : ParserContract
    {
        private Regex pattern;
        private Regex metaPattern;

        public KickAssParser()
        {
            pattern = new Regex(@"<tr.+?id=""[\s\S]+?<\/tr>", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            metaPattern = new Regex(@"data-sc-params=""(.+?)""", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        }

        public ResourceSet Parse(object o)
        {
            ResourceSet resources = null;

            Stream rawStream = null;
            GZipStream gzipStream = null;
            StreamReader reader = null;
            try
            {
                rawStream = (Stream) o;
                gzipStream = new GZipStream(rawStream, CompressionMode.Decompress);

                reader = new StreamReader(gzipStream);
                String result = reader.ReadToEnd();

                resources = Compose(result);

            }
            catch (Exception)
            {
            }
            finally
            {
                if (reader != null) reader.Close();
                if (gzipStream != null) gzipStream.Close();
                if (rawStream != null) rawStream.Close();
            }



            return resources;
        }

        public ResourceSet Compose(string data)
        {
            ResourceSet resources = new ResourceSet();

            MatchCollection matches = pattern.Matches(data);
            if (matches.Count > 0)
            {
                resources.ResourceList = new List<ResourceInfo>(matches.Count);

                foreach (Match match in matches)
                {
                    var meta = metaPattern.Match(match.Value);
                    // Convent to MetaInfo instance
                    MetaInfo mi = JsonConvert.DeserializeObject<MetaInfo>(meta.Groups[1].Value);

                    ResourceInfo ri = new ResourceInfo();
                    ri.Title = HttpUtility.UrlDecode(mi.Name);
                    ri.MagnetLink = HttpUtility.UrlDecode(mi.Magnet);

                    resources.ResourceList.Add(ri);
                }
            }

            return resources;
        }
    }
}
