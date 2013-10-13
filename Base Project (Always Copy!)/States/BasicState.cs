using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_Project__Always_Copy__
{
    abstract class BasicState
    {

        public virtual void Update()
        {
        }

        public virtual void Redraw(PaintEventArgs e)
        {
        }

        public virtual void MouseMoved(MouseEventArgs e)
        {
        }

        public virtual void MouseClicked(MouseEventArgs e)
        {
        }

    }
}
