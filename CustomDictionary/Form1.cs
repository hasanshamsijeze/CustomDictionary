using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomDictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rb_Search.Checked = true;
            tb_Word.ReadOnly = false;
            tb_Discript.ReadOnly = true;
            tb_Word.Focus();
        }

        private void rb_Add_CheckedChanged(object sender, EventArgs e)
        {
            tb_Word.ReadOnly = false;
            tb_Discript.ReadOnly = false;
        }

        private void rb_Search_CheckedChanged(object sender, EventArgs e)
        {
            tb_Word.ReadOnly = false;
            tb_Discript.ReadOnly = true;
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            if (rb_Add.Checked)
            {

            }
            else if (rb_Search.Checked)
            {
            }
            tb_Discript.Text += "hello \r\n";
        }

        private void tb_Word_KeyDown(object sender, KeyEventArgs e)
        {

            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.V)
            {
                tb_Word.Text = "";
                //tb_Word.Text = Clipboard.GetText(TextDataFormat.Text);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
