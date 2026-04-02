using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
    public class ImageNode : LightNode
    {
        private string _href;
        private IImageLoader _loader;

        public ImageNode(string href)
        {
            _href = href;

            if (href.StartsWith("http"))
                _loader = new NetworkImageLoader();
            else
                _loader = new FileImageLoader();
        }

        public void LoadImage()
        {
            Console.WriteLine(_loader.Load(_href));
        }

        public override string OuterHTML()
        {
            return $"<img src=\"{_href}\" />";
        }

        public override string InnerHTML()
        {
            return "";
        }
    }
}
