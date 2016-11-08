using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiteolikaMediaplayer
{
    public class KeyboardMessageFilter : IMessageFilter
    {
        const int WM_KEYDOWN = 0x100;
        private readonly IMediator _mediator;
        public KeyboardMessageFilter(IMediator mediator)
        {
            _mediator = mediator;
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == ((int)WM_KEYDOWN))
            {
                _mediator.KeyPressed((int)m.WParam);
                return true;
            }
            return false;

        }
    }
}
