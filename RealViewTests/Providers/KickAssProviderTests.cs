using Microsoft.VisualStudio.TestTools.UnitTesting;
using RealView.Core.Parser;
using RealView.Core.Provider;
using RealView.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealView.Core.Model;
using System.Threading;
using System.IO;
using System.Net.Http;
using System.Net;
using System.IO.Compression;

namespace RealView.Providers.Tests
{
    [TestClass()]
    public class KickAssProviderTests
    {
        [TestMethod()]
        public void LoadTest()
        {
            Provider provider = new KickAssProvider();

            TestParser parser = new TestParser();
            provider.Load("JUX", parser);

            while (!parser.isParsed)
            {
                Thread.Sleep(800);
            }
        }
    }

    public class TestParser : ParserContract
    {
        public Boolean isParsed = false;

        public ResourceSet Parse(object o)
        {
            //Stream stream = (Stream) o;

            //StringBuilder sb = new StringBuilder();

            //StreamReader reader = new StreamReader(stream, Encoding.GetEncoding("GBK"));

            //string line;
            //while ((line = reader.ReadLine()) != null)
            //{
            //    sb.Append(line);
            //}

            //Assert.IsTrue(sb.ToString().Length > 0);
            HttpResponseMessage msg = (HttpResponseMessage) o;

            var stream = msg.Content.ReadAsStreamAsync();
            var gzipStream = new GZipStream(stream.Result, CompressionMode.Decompress);
            StreamReader reader = new StreamReader(gzipStream);
            String str = reader.ReadToEnd();

            Assert.AreEqual(HttpStatusCode.OK, msg.StatusCode);

            isParsed = true;
            return null;
        }
    }
}