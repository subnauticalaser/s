using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Silgil_s_doumb
{
    public partial class Lua_FastColoredtextBox : Form
    {
        public Lua_FastColoredtextBox()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }
    }
}
