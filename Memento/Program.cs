namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var editor = new TextEditor();

            editor.Write("Hello");
            editor.Show();

            editor.Write(" world");
            editor.Show();

            editor.Write("!!!");
            editor.Show();

            Console.WriteLine("\nUndo:");
            editor.Undo();
            editor.Show();

            Console.WriteLine("\nUndo:");
            editor.Undo();
            editor.Show();
        }
    }
}
