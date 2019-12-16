using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TibiaHelper
{
    public partial class InformationPage : Form
    {
        private string tempPath = System.IO.Path.GetTempPath();
        string localFilenameENG;
        string localFilenamePL;

        public InformationPage()
        {
            InitializeComponent();
            ZaladujObrazki();
        }

        private void ZaladujObrazki()
        {
            localFilenameENG = tempPath+@"\InfoENG.jpg";
            localFilenamePL = tempPath + @"\InfoPL.jpg";

            using (WebClient client = new WebClient())
            {
                //client.DownloadFile("http://candiahelper.pl/wp-content/uploads/2018/06/InfoENG.jpg", localFilenameENG);
                //client.DownloadFile("http://candiahelper.pl/wp-content/uploads/2018/06/InfoPL.jpg", localFilenamePL);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.BackgroundImage = Image.FromFile(localFilenamePL);
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            Form.ActiveForm.BackgroundImage = Image.FromFile(localFilenameENG);
        }
    }
}
