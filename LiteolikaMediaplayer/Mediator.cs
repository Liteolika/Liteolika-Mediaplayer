using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiteolikaMediaplayer
{
    public interface IMediator
    {
        void KeyPressed(int key);
        event KeyPressDelegate OnKeyPressed;
    }

    public delegate void KeyPressDelegate(object sender, int key);

    public class Mediator : IMediator
    {
        //public delegate void KeyPressDelegate(object sender);

        public event KeyPressDelegate OnKeyPressed;

        public void KeyPressed(int key)
        {
            OnKeyPressed?.Invoke(this, key);
        }
    }
}
