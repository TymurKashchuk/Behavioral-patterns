using Strategy.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class LightElementNode : LightNode
    {
        private string _tagName;
        private string _displayType;
        private bool _selfClosing;

        private List<string> _classes = new List<string>();
        private List<LightNode> _children = new List<LightNode>();

        private Dictionary<string, List<IEventListener>> _listeners =
            new Dictionary<string, List<IEventListener>>();

        public string TagName => _tagName;

        public LightElementNode(string tagName, string displayType, bool selfClosing)
        {
            _tagName = tagName;
            _displayType = displayType;
            _selfClosing = selfClosing;
        }

        public void AddClass(string className)
        {
            _classes.Add(className);
        }

        public void AddChild(LightNode node)
        {
            _children.Add(node);
        }

        public int ChildrenCount => _children.Count;

        // Observer
        public void Subscribe(string eventType, IEventListener listener)
        {
            if (!_listeners.ContainsKey(eventType))
                _listeners[eventType] = new List<IEventListener>();

            _listeners[eventType].Add(listener);
        }

        public void TriggerEvent(string eventType)
        {
            Console.WriteLine($"Event '{eventType}' triggered on <{_tagName}>");

            if (_listeners.ContainsKey(eventType))
            {
                foreach (var listener in _listeners[eventType])
                {
                    listener.Update(eventType, this);
                }
            }
        }

        public override string InnerHTML()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var child in _children)
            {
                sb.Append(child.OuterHTML());
            }

            return sb.ToString();
        }

        public override string OuterHTML()
        {
            StringBuilder sb = new StringBuilder();

            string classAttr = _classes.Count > 0
                ? $" class=\"{string.Join(" ", _classes)}\""
                : "";

            if (_selfClosing)
            {
                sb.Append($"<{_tagName}{classAttr}/>");
            }
            else
            {
                sb.Append($"<{_tagName}{classAttr}>");
                sb.Append(InnerHTML());
                sb.Append($"</{_tagName}>");
            }

            return sb.ToString();
        }
    }
}
