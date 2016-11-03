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
        

        Boolean Status;  // variable that checks status of the website
        private void CheckStatusbutton_Click(object sender, EventArgs e)
        {
            //Initializing Label with no text
            Loglbl.Text = "";

            Loglbl.Text += "Checking status....";

            Loglbl.Text += "\n\nWill take a few seconds";

            //Calling Status Checker
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
             //Creating a variable named ping
            System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();

            //concatenating the website name with https://wwww.
            string url ="https://www." + WebsiteName.Text;

            //convering URL name to uristring 
            Uri URLname = new Uri(url);

            //Displaying website name 
            Loglbl.Text += "\nPinging " + Convert.ToString(WebsiteName.Text);
            try
            { 
                //Making variable named pingresult which sends ping to the URL host and with a timeout of 5000ms
                System.Net.NetworkInformation.PingReply pingresult = ping.Send(URLname.Host, 5000);

                //Checking the status of ping result , if its a success
                if (pingresult.Status == System.Net.NetworkInformation.IPStatus.Success)
                {
                    //If true , status = true and the website is up
                    Status = true;

                }
            }catch
            {
                //If false , status = false and the website is down 
                Status = false;
                
            }
        }
    }
}
