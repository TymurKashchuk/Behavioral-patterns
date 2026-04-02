namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var button = new LightElementNode("button", "inline", false);
            button.AddChild(new LightTextNode("Click me"));

            var clickListener = new EventListener("Listener1");
            var hoverListener = new EventListener("Listener2");

            button.Subscribe("click", clickListener);
            button.Subscribe("mouseover", hoverListener);

            Console.WriteLine(button.OuterHTML());

            Console.WriteLine("\nTrigger click:");
            button.TriggerEvent("click");

            Console.WriteLine("\nTrigger mouseover:");
            button.TriggerEvent("mouseover");
        }
    }
}
