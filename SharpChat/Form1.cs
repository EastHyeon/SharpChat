using ServerCore;
using System.Net;

namespace SharpChat
{
    public partial class SharpChat : Form
    {
        public SharpChat()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // DNS (Domain Name System)
            IPAddress ipAddr = IPAddress.Parse("220.76.143.34");
            IPEndPoint endPoint = new IPEndPoint(ipAddr, 7777);
            Connector connector = new Connector();

            connector.Connect(endPoint, () => { return SessionManager.Instance.Generate(); });
            mainMsgBox.Clear();
            msgButton.BringToFront();
            ServerSession.itemStr += new StrAddHandler(msgAdd);
            PacketHandler.itemStr += new StrAddHandler(msgAdd);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (msgInputBox.Text == "")
                return;
            if (e.KeyData == Keys.Enter)
            {
                if (nameBox.Text == "")
                    SessionManager.Instance.Send("익명", msgInputBox.Text);
                else
                    SessionManager.Instance.Send(nameBox.Text, msgInputBox.Text);
                msgInputBox.Clear();
            }
        }
        private void msgAdd(string msg)
        {
            mainMsgBox.AppendText(msg + System.Environment.NewLine);
            mainMsgBox.ScrollToCaret();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (msgInputBox.Text == "")
                return;
            if (nameBox.Text == "")
                SessionManager.Instance.Send("익명", msgInputBox.Text);
            else
                SessionManager.Instance.Send(nameBox.Text, msgInputBox.Text);
            msgInputBox.Clear();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {

        }

        private void msgInputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
