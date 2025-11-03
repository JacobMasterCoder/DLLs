using CZK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReaperExecutor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Execute1_Click(object sender, EventArgs e)
        {
            if (CZK.Xeno.IsInjected())
            {
                string script = ScriptEditor1.Text;
                CZK.Xeno.Execute(script);
            }
            else
            {
                MessageBox.Show("Not injected. Please attach first.");
            }


        }
        private void Inject1_Click(object sender, EventArgs e)
        {
            CZK.Xeno.Inject();
            if (CZK.Xeno.IsInjected())
            {
                MessageBox.Show("Injected via API!");
                checkInjection();
            }
            else
            {
                MessageBox.Show("Failed to inject via API.");
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkInjection()
        {
            if (CZK.Xeno.IsInjected())
            {
                Notification1.Text = "Injected"; // Replace with your textbox's name
            }
            else
            {
                Notification1.Text = "Not Injected"; // Replace with your textbox's name
            }
        }


    }
}
