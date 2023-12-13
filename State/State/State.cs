using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public abstract class State
    {
        protected Computer comp;
        public State()
        {
            
        }
        protected abstract void click();
        protected abstract void clickToOpen();
        protected abstract void clickToClose();
    }
}
