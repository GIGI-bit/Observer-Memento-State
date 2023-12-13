using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor
{
    public class Editor
    {
        public IOptions Options;
        private MementoSaver memento;
        public Editor()
        {
            memento = new MementoSaver();
        }
        public void Save()
        {
            memento.Memento = new PhotoMemento();
            memento.Memento.options = Options;
        }
        public void Undo()
        {
            PhotoMemento undo = memento.Memento;
            Options = undo.options;
        }

    }
}
