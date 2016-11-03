using System;
using System.Windows.Forms;
using System.Threading;

namespace ServerStatusChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Boolean Status;
        private void CheckStatusbutton_Click(object sender, EventArgs e)
        {

            Loglbl.Text = "";

            Loglbl.ForeColor = System.Drawing.Color.Aqua;
            Loglbl.Text += "Checking status....";

            Loglbl.Text += "\n\nWill take a few seconds";

            Thread.Sleep(100);
            ServerStatusChecker();

            Thread.Sleep(1000);

            if(Status == true)
            {
                Loglbl.ForeColor = System.Drawing.Color.LawnGreen;
                Loglbl.Text += "\n\nThe website is up and running";
                Thread.Sleep(100);
            }
            else if (Status == false)
            {
                Loglbl.ForeColor = System.Drawing.Color.Red;
                Loglbl.Text += "\n\nThe website is down , please check after a few minutes";
                Thread.Sleep(100);
            }
        }

        public void ServerStatusChecker()
        {
           
            

            System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();

            string url ="https://www." + WebsiteName.Text;

            Uri URLname = new Uri(url);

           
            Loglbl.Text += "\nPinging " + Convert.ToString(WebsiteName.Text);
            try
            {
                System.Net.NetworkInformation.PingReply pingresult = ping.Send(URLname.Host, 5000);
                if(pingresult.Status == System.Net.NetworkInformation.IPStatus.Success)
                {
                    Status = true;
                   
                   
                }
            }catch
            {
                Status = false;
                
            }
        }
    }
}
