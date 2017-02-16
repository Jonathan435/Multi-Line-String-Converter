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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteTxt();

            if (radVB.Checked == true)
            {
                ConvertToVb();
            }
            else 
            {
                ConvertToCsharp();
            }
        }

        
        private void ConvertToVb()
        {
            List<string> l = new List<string>();
            for (int i = 0; i < txtSql.Lines.Length; i++)
            {
                l.Add(txtSql.Lines[i]);
            }

            for (int i = 0; i < l.Count; i++)
            {

                if (Math.Abs(i - l.Count) == 1)
                {
                    txtFormatedSql.AppendText("&" + '\u0022' + " " + l[i] + '\u0022');
                }

                else if (i > 0)
                {
                    txtFormatedSql.AppendText("&" + '\u0022' + " " + l[i] + '\u0022' + " _" + Environment.NewLine);
                }

                else
                {
                    txtFormatedSql.AppendText('\u0022' + l[i] + '\u0022' + " _" + Environment.NewLine);
                }
            }
        }

        private void ConvertToCsharp()
        {
            List<string> l = new List<string>();
            for (int i = 0; i < txtSql.Lines.Length; i++)
            {
                l.Add(txtSql.Lines[i]);
            }

            for (int i = 0; i < l.Count; i++)
            {

                if (Math.Abs(i - l.Count) == 1)
                {
                    txtFormatedSql.AppendText("+" + '\u0022' + " " + l[i] + '\u0022');
                }

                else if (i > 0)
                {
                    txtFormatedSql.AppendText("+" + '\u0022' + " " + l[i] + '\u0022'  + Environment.NewLine);
                }

                else
                {
                    txtFormatedSql.AppendText('\u0022' + l[i] + '\u0022' + Environment.NewLine);
                }
            }
        }

        private void DeleteTxt()
        {
            txtFormatedSql.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtFormatedSql.Text != "")
            {
                Clipboard.SetText(txtFormatedSql.Text);
            }
        }
       
    }
}
