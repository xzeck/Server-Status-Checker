using System;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

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

            //Calling Status Checker
            StatusChecker();


            if(Status == true)
            {
                Loglbl.ForeColor = System.Drawing.Color.LawnGreen;
                Loglbl.Text += "\n\nThe website is up and running";
                
            }
            else if (Status == false)
            {
                Loglbl.ForeColor = System.Drawing.Color.Red;
                Loglbl.Text += "\n\nThe website is down , please check after a few minutes";
               
            }
        }

        public void StatusChecker()
        {
             //Creating a variable named ping
            System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();

            //concatenating the website name with https://wwww.
            string url ="https://www." + WebsiteName.Text;

            //convering URL name to uristring 
            Uri URLname = new Uri(url);

            
            try
            { 
                //Making variable named pingresult which sends ping to the URL host and with a timeout of 5000ms
                System.Net.NetworkInformation.PingReply pingresult = ping.Send(URLname.Host, 5000);
                //Displaying website name 
                Loglbl.Text += "\nPinging " + Convert.ToString(WebsiteName.Text) +"[" + pingresult.Address + "]";

                Loglbl.Text += "Round trip time for ICMP in ms:" + pingresult.RoundtripTime;

                //Checking the status of ping result , if its a success
                if (pingresult.Status == System.Net.NetworkInformation.IPStatus.Success)
                {

                    //If true , status = true and the website is up
                    Status = true;
                    //Calling function to change the picture box color 
                    changepictureboxcolor();
                }
            }catch
            {
                //If false , status = false and the website is down 
                Status = false;

                //Calling function to change the picture box color 
                changepictureboxcolor();
            }
        }

        void changepictureboxcolor()
        {
            //Default image
            StatusPictureBox.BackgroundImage = ServerStatusChecker.Properties.Resources.WebDown;

            
            if(Status == true)
            {   //If the website is up
                StatusPictureBox.BackgroundImage = ServerStatusChecker.Properties.Resources.WebUp;
            }else if (Status == false)
            {
                //If the website is down
                StatusPictureBox.BackgroundImage = ServerStatusChecker.Properties.Resources.WebDown;
            }
        }

    }
}
