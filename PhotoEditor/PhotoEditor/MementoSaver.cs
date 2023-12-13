using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor
{
    public class MementoSaver
    {
        private Stack<PhotoMemento> _mementos;
        public MementoSaver()
        {
            _mementos = new Stack<PhotoMemento>();
        }
        public PhotoMemento Memento
        {
            get => _mementos.Pop();
            set { _mementos.Push(value); }
        }

    }
}
