using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
    public class FileImageLoader : IImageLoader
    {
        public string Load(string href)
        {
            return $"Loading image from file system: {href}";
        }
    }
}
