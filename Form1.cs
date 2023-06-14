using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Silgil_s_doumb
{
    public partial class Form1 : Form
    {
        public FormWindowState WinowState { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (visualStudioTabControl1.TabPages.Count > 0)
                {
                    FastColoredTextBoxNS.FastColoredTextBox textBox = this.visualStudioTabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBoxNS.FastColoredTextBox;
                    textBox.Text = "";
                }
            }
            catch { }
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
              
        }

        private void siticoneButton6_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open File";
                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = File.ReadAllText($"./Scripts/{listBox1.SelectedItem}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.mcfunction");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.py");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.html");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.js");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.css");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.cs");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.bat");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.json");
        }

        private void AddTabButton_Click(object sender, EventArgs e)
        {
            TabPage newTab = new TabPage();
            FastColoredTextBoxNS.FastColoredTextBox textBox = new FastColoredTextBoxNS.FastColoredTextBox();
            newTab.Name = "Script" + (visualStudioTabControl1.TabCount + 1);
            newTab.Text = "New Tab";
            newTab.Parent = visualStudioTabControl1;
            textBox.Dock = DockStyle.Fill;
            textBox.Name = "fastColoredTextBox1";
            textBox.Parent = newTab;
            visualStudioTabControl1.SelectTab(newTab);
            AddTabButton.Left = AddTabButton.Left + 75;
            RemoveTabButton.Left = RemoveTabButton.Left + 77;
            if (visualStudioTabControl1.TabCount == 7)
            {
                AddTabButton.Hide();
            }
            if (visualStudioTabControl1.TabCount > 1)
            {
                RemoveTabButton.Show();
            }
        }

        private void RemoveTabButton_Click(object sender, EventArgs e)
        {
            if (visualStudioTabControl1.TabCount > 1)
            {
                Control tabPageToRemove = visualStudioTabControl1.Controls["Script" + (visualStudioTabControl1.TabCount)];
                visualStudioTabControl1.SelectTab("Script" + (visualStudioTabControl1.TabCount - 1));
                visualStudioTabControl1.Controls.Remove(tabPageToRemove);
                AddTabButton.Left = AddTabButton.Left - 75;
                RemoveTabButton.Left = RemoveTabButton.Left - 77;
                if (visualStudioTabControl1.TabCount == 7)
                {
                    AddTabButton.Hide();
                }
                else
                {
                    AddTabButton.Show();
                }
                if (visualStudioTabControl1.TabCount == 1)
                {
                    RemoveTabButton.Hide();
                }
            }
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            Lua_FastColoredtextBox lua_fastcoloredtextbox = new Lua_FastColoredtextBox();
            lua_fastcoloredtextbox.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JSON;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.VB;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.XML;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.SQL;
        }
    }
}
