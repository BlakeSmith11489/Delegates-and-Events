using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_Events
{
    public delegate void ChangeEventHandler(object sender, EventArgs e);

    class ListWithChangedEvent : ArrayList
    {
        public ChangeEventHandler Changed;

        protected virtual void OnChanged(EventArgs e)
        {
            if (Changed != null)
                Changed(this, e);
        }

        public override int[] Add(int[] array, int value)
        {
            int[] i = base.Add(array, value);
            OnChanged(EventArgs.Empty);
            return i;
        }

        public override object Clear()
        {
            object c = base.Clear();
            OnChanged(EventArgs.Empty);
            return c;
        }

        public override object this[int index]
        {
            set
            {
                base[index] = value;
                OnChanged(EventArgs.Empty);
            }
        }
    }
}
