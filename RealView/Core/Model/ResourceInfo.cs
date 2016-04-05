using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealView.Core.Model
{
    public class ResourceInfo
    {
        /// <summary>
        /// The title of the resource
        /// </summary>
        public String Title;

        /// <summary>
        /// The magnet url of the resource
        /// </summary>
        public String MagnetLink;

        /// <summary>
        /// The url of the torrent for the resource
        /// </summary>
        public String TorrentLink;

        /// <summary>
        /// The unique id of the resource
        /// </summary>
        public String Identifier;
    }
}
