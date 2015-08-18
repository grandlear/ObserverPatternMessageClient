using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPatternMessageClient
{
    public partial class Server : Form
    {
        private MessageClient _messageClient;
        private List<MessageClient> _messageClients;
        public Server()
        {
            _messageClients = new List<MessageClient>();
            InitializeComponent();
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            _messageClient = new MessageClient(this);
            AddObserver(_messageClient);
            _messageClient.Show();
        }

        public void AddObserver(MessageClient messageClient)
        {
            if (_messageClients.IndexOf(messageClient) < 0)
                _messageClients.Add(messageClient);
        }

        public void RemoveObserver(MessageClient messageClient)
        {
            if (_messageClients.IndexOf(messageClient) >= 0)
                _messageClients.Remove(messageClient);
        }

        public string GetMessageText()
        {
            return this.MessageText.Text;
        }

        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }

        private void NotifyObservers()
        {
            foreach (var messageClient in _messageClients)
            {
                messageClient.Update();
            }
        }

        private void MessageButton_Click(object sender, EventArgs e)
        {
            NotifyObservers();
        }
    }
}
