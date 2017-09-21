using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Mail;


namespace WindowsFormsApplication1
{
    public partial class test : Form
    {    
       
        public test()
        {
            InitializeComponent();
            button3.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = null;
            try
            {
                button9.Hide();
                Email_TestStart1();
                string batDir = string.Format(@"C:\CodeduiMSTESTBatFiles\XWebClaims");
                proc = new System.Diagnostics.Process();
                proc.StartInfo.WorkingDirectory = batDir;
                proc.StartInfo.FileName = "Run1ConnectToDB.bat";
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                proc.WaitForExit();
                Email_TestEnded1();
                MessageBox.Show("Your test run completed.");
                button9.Show();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\CodeduiMSTESTBatFiles\Results\AwesomeResults.trx");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)

        {
            if (e.CloseReason == CloseReason.UserClosing)

            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process proc = null;
                    Email_TestStart5();
                    string batDir = string.Format(@"C:\CodeduiMSTESTBatFiles\XWebClaims");
                    proc = new System.Diagnostics.Process();
                    proc.StartInfo.WorkingDirectory = batDir;
                    proc.StartInfo.FileName = "Kill.bat";
                    proc.StartInfo.CreateNoWindow = false;
                    proc.Start();
                    proc.WaitForExit();
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = null;
            try
            {
                button3.Hide();
                Email_TestStart2();
                string batDir = string.Format(@"C:\CodeduiMSTESTBatFiles\XWebClaims");
                proc = new System.Diagnostics.Process();
                proc.StartInfo.WorkingDirectory = batDir;
                proc.StartInfo.FileName = "Run2ResetUsernames.bat";
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                proc.WaitForExit();
                Email_TestEnded2();
                MessageBox.Show("Your test to reset usernames completed.");
                button3.Show();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = null;
            try
            {
                button10.Hide();
                Email_TestStart3();
                string batDir = string.Format(@"C:\CodeduiMSTESTBatFiles\XWebClaims");
                proc = new System.Diagnostics.Process();
                proc.StartInfo.WorkingDirectory = batDir;
                proc.StartInfo.FileName = "Run3PolicyTest.bat";
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                proc.WaitForExit();
                Email_TestEnded3();
                MessageBox.Show("Your test to create a policy completed.");
                button10.Show();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = null;
            try
            {
                button11.Hide();
                Email_TestStart4();
                string batDir = string.Format(@"C:\CodeduiMSTESTBatFiles\XWebClaims");
                proc = new System.Diagnostics.Process();
                proc.StartInfo.WorkingDirectory = batDir;
                proc.StartInfo.FileName = "Run4CreateClaim.bat";
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                proc.WaitForExit();
                Email_TestEnded4();
                MessageBox.Show("Your test to create a claim completed.");
                button11.Show();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = null;
            try
            {
                button12.Hide();
                Email_TestStart5();
                string batDir = string.Format(@"C:\CodeduiMSTESTBatFiles\XWebClaims");
                proc = new System.Diagnostics.Process();
                proc.StartInfo.WorkingDirectory = batDir;
                proc.StartInfo.FileName = "Run5XWebTests.bat";
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                proc.WaitForExit();
                Email_TestEnded5();
                MessageBox.Show("Your XWeb autorisation and assessment tests completed.");
                button12.Show();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = null;
            try
            {
                button13.Hide();
                Email_TestStart6();
                string batDir = string.Format(@"C:\CodeduiMSTESTBatFiles\XWebClaims");
                proc = new System.Diagnostics.Process();
                proc.StartInfo.WorkingDirectory = batDir;
                proc.StartInfo.FileName = "Run6RunAll.bat";
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                proc.WaitForExit();
                Email_TestEnded6();
                MessageBox.Show("Total process test completed successful.");
                button13.Show();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\CodeduiMSTESTBatFiles\Results\Run1ConnectToDatabase.trx");
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start(@"C:\CodeduiMSTESTBatFiles\Results\Run2ResetUsernames.trx");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\CodeduiMSTESTBatFiles\Results\Run3CreatePolicy.trx");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\CodeduiMSTESTBatFiles\Results\Run4CreateClaim.trx");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\CodeduiMSTESTBatFiles\Results\Run5XWebTests.trx");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\CodeduiMSTESTBatFiles\Results\Run6RunAll.trx");
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            //Launch browser to facebook
            System.Diagnostics.Process.Start("http://ssjira.silverbridge.co.za:8080/secure/Dashboard.jspa");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Email_Send();
        }

        public void Email_Send()
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("jhalewis@gmail.com");
                mail.To.Add("jhalewis@gmail.com");
                mail.Subject = "Test Results";
                mail.Body = "Attached are you Test Results";

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment("D:\\CodeduiMSTESTBatFiles\\Results\\Run6RunAll.trx");
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("jhalewis@gmail.com", "MclarenF1");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

            }
        public void Email_TestStart1()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("jhalewis@gmail.com");
            mail.To.Add("jhalewis@gmail.com");
            mail.Subject = "Test Started";
            mail.Body = "Started - Run test to check your database connection";

            //System.Net.Mail.Attachment attachment;
            //attachment = new System.Net.Mail.Attachment("D:\\CodeduiMSTESTBatFiles\\Results\\Run6RunAll.trx");
            //mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("jhalewis@gmail.com", "MclarenF1");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
        public void Email_TestEnded1()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("jhalewis@gmail.com");
            mail.To.Add("jhalewis@gmail.com");
            mail.Subject = "Test completed";
            mail.Body = "Completed - Run test to check your database connection";

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(@"C:\CodeduiMSTESTBatFiles\Results\Run1ConnectToDatabase.trx");
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("jhalewis@gmail.com", "MclarenF1");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
        public void Email_TestStart2()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("jhalewis@gmail.com");
            mail.To.Add("jhalewis@gmail.com");
            mail.Subject = "Test Started";
            mail.Body = "Started - Reset Passwords for usernames in test";

            //System.Net.Mail.Attachment attachment;
            //attachment = new System.Net.Mail.Attachment("D:\\CodeduiMSTESTBatFiles\\Results\\Run6RunAll.trx");
            //mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("jhalewis@gmail.com", "MclarenF1");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
        public void Email_TestEnded2()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("jhalewis@gmail.com");
            mail.To.Add("jhalewis@gmail.com");
            mail.Subject = "Test completed";
            mail.Body = "Completed - Reset Passwords for usernames in test";

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(@"C:\CodeduiMSTESTBatFiles\Results\Run2ResetUsernames.trx");
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("jhalewis@gmail.com", "MclarenF1");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
        public void Email_TestStart3()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("jhalewis@gmail.com");
            mail.To.Add("jhalewis@gmail.com");
            mail.Subject = "Test Started";
            mail.Body = "Started - Create a new policy";

            //System.Net.Mail.Attachment attachment;
            //attachment = new System.Net.Mail.Attachment("D:\\CodeduiMSTESTBatFiles\\Results\\Run6RunAll.trx");
            //mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("jhalewis@gmail.com", "MclarenF1");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
        public void Email_TestEnded3()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("jhalewis@gmail.com");
            mail.To.Add("jhalewis@gmail.com");
            mail.Subject = "Test completed";
            mail.Body = "Completed - Create a new Policy";

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(@"C:\CodeduiMSTESTBatFiles\Results\Run3CreatePolicy.trx");
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("jhalewis@gmail.com", "MclarenF1");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
        public void Email_TestStart4()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("jhalewis@gmail.com");
            mail.To.Add("jhalewis@gmail.com");
            mail.Subject = "Test Started";
            mail.Body = "Started - Create a new Claim";

            //System.Net.Mail.Attachment attachment;
            //attachment = new System.Net.Mail.Attachment("D:\\CodeduiMSTESTBatFiles\\Results\\Run6RunAll.trx");
            //mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("jhalewis@gmail.com", "MclarenF1");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
        public void Email_TestEnded4()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("jhalewis@gmail.com");
            mail.To.Add("jhalewis@gmail.com");
            mail.Subject = "Test completed";
            mail.Body = "Completed - Create a new Claim";

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(@"C:\CodeduiMSTESTBatFiles\Results\Run4CreateClaim.trx");
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("jhalewis@gmail.com", "MclarenF1");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
        public void Email_TestStart5()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("jhalewis@gmail.com");
            mail.To.Add("jhalewis@gmail.com");
            mail.Subject = "Test Started";
            mail.Body = "Started - Claims Authorisation";

            //System.Net.Mail.Attachment attachment;
            //attachment = new System.Net.Mail.Attachment("D:\\CodeduiMSTESTBatFiles\\Results\\Run6RunAll.trx");
            //mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("jhalewis@gmail.com", "MclarenF1");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
        public void Email_TestEnded5()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("jhalewis@gmail.com");
            mail.To.Add("jhalewis@gmail.com");
            mail.Subject = "Test completed";
            mail.Body = "Completed - Run test to check your database connection";

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(@"C:\CodeduiMSTESTBatFiles\Results\Run5XWebTests.trx");
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("jhalewis@gmail.com", "MclarenF1");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
        public void Email_TestStart6()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("jhalewis@gmail.com");
            mail.To.Add("jhalewis@gmail.com");
            mail.Subject = "Test Started";
            mail.Body = "Started - Full process test";

            //System.Net.Mail.Attachment attachment;
            //attachment = new System.Net.Mail.Attachment("D:\\CodeduiMSTESTBatFiles\\Results\\Run6RunAll.trx");
            //mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("jhalewis@gmail.com", "MclarenF1");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
        public void Email_TestEnded6()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("jhalewis@gmail.com");
            mail.To.Add("jhalewis@gmail.com");
            mail.Subject = "Test completed";
            mail.Body = "Completed - Full process test";

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(@"C:\CodeduiMSTESTBatFiles\Results\Run6RunAll.trx");
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("jhalewis@gmail.com", "MclarenF1");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Launch browser to facebook
            System.Diagnostics.Process.Start("http://silverbridge.co.za/");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Setup Installation = new Setup();
            Installation.Show();

            this.Hide();            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\APJames\Intelligent Test Automation\ExergyWeb2\ExergyWebClaims\ExergyWeb\NightlyXWEBTest.orderedtest");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
               System.Diagnostics.Process.Start(@"C:\APJames\Intelligent Test Automation\ExergyWeb2\ExergyWebClaims\ExergyWeb\NightlyXWEBTest.orderedtest");
            
        }
    }

    
}



        
    

