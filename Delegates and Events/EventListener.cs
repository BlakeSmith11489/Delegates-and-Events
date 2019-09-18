using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_Events
{
    class EventListener
    {
        private ListWithChangedEvent List;

        public EventListener(ListWithChangedEvent _list)
        {
            List = _list;
            List.Changed += new ChangeEventHandler(OnListChanged);
        }

        private void OnListChanged(object sender, EventArgs e)
        {
            Console.WriteLine("list changed event recieved");
        }

        public void Detach()
        {
            List.Changed -= new ChangeEventHandler(OnListChanged);
            List = null;
        }
    }
}
