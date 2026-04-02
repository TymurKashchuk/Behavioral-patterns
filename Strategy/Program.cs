using Strategy.Strategy;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var localImg = new ImageNode("images/photo.png");
            var webImg = new ImageNode("https://example.com/image.jpg");

            Console.WriteLine(localImg.OuterHTML());
            localImg.LoadImage();

            Console.WriteLine();

            Console.WriteLine(webImg.OuterHTML());
            webImg.LoadImage();
        }
    }
}
