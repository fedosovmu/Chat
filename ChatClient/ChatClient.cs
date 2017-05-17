using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    class ChatClient
    {
        public event Action Connected;
        public event Action Disconnected;

        public ChatClient()
        {
            
        }

        public void Connect()
        {
            Connected();
        }

        public void Disconnect()
        {
            Disconnected();
        }

    }
}
