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
    public partial class MessageClient : Form
    {
        private Server _server;
        private string _serverText = string.Empty;
        private DateTime _timestamp;
        private string _username;
        public MessageClient(Server server)
        {
            _server = server;
            InitializeComponent();

            this.FormClosing += TickerForm_FormClosing;
        }
        private void TickerForm_Load(object sender, EventArgs e)
        {
            this.NewsItemTextBox.Text = _serverText;
        }

        private void TickerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _server.RemoveObserver(this);
        }
        public void Update()
        {
            _serverText = _server.GetMessageText();
            _timestamp = _server.GetDateTime();

            if (this.NewsItemTextBox.Text != string.Empty)
                this.NewsItemTextBox.AppendText(Environment.NewLine);
            this.NewsItemTextBox.AppendText(string.Format("{0}:\t{1}", _timestamp.ToString("hh:mm:ss.fff"), _serverText));
        }

        public void SetUsername(string username)
        {
            _username = username;
        }

        public string GetUsername()
        {
            return _username;
        }
    }
}
