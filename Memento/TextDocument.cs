using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class TextDocument
    {
        public string Content { get; private set; } = "";
        public void SetContent(string content) {
            Content = content;
        }
    }
}
