using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Memento
{
    class TextEditor
    {
        private TextDocument _document = new TextDocument();
        private Stack<DocumentMemento> _history = new Stack<DocumentMemento>();

        public void Write(string text) {
            Save();
            _document.SetContent(_document.Content + text);
        }

        public void Save()
        {
            _history.Push(new DocumentMemento(_document.Content));
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                var memento = _history.Pop();
                _document.SetContent(memento.Content);
            }
        }

        public void Show()
        {
            System.Console.WriteLine("Document: " + _document.Content);
        }
    }
}
