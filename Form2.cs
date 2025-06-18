using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingProject
{
    public partial class Form2 : Form
    {
        string? title;
        string? msg;
        public Form2(string title, string text)
        {
            this.title = title;
            this.msg = text;
            InitializeComponent();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (title != null && msg != null) 
            {
                titleTxt.Text = title;
                msgTxt.Text = msg;
            }
        }
    }
}
