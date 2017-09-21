using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                test form2 = new test();
                form2.Show();

                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://msdn.microsoft.com/en-us/library/b9zzhatx(v=vs.90).aspx");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/nuget/tools/package-manager-ui");
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            System.Diagnostics.Process.Start("https://msdn.microsoft.com/en-us/library/5tdasz7h.aspx");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.nuget.org/packages/ClientServices/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.nuget.org/packages/ExergyAndWeb/");
        }
    }
}
