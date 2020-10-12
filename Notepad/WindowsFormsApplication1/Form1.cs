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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Want to Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
            
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {

                richTextBox1.Paste();
              
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Chosen_File = "";

            openFD.InitialDirectory = "./";
            openFD.Title = "Open a Text File";
            openFD.FileName = "";

            openFD.Filter = "Text Files|*.txt|Word Documents|*.doc";

            if (openFD.ShowDialog() != DialogResult.Cancel)
            {
                Chosen_File = openFD.FileName;
                richTextBox1.LoadFile(Chosen_File, RichTextBoxStreamType.PlainText);

                //string filename = Path.GetFilename(Chosen_File);
                
            }
        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            string Saved_File = "";

            saveFD.InitialDirectory = "./";
            saveFD.Title = "Save a Text File";
            saveFD.FileName = "";

            saveFD.Filter = "Text Files|*.txt|All Files|*.*";

            if (saveFD.ShowDialog() != DialogResult.Cancel)
            {
                Saved_File = saveFD.FileName;
                richTextBox1.SaveFile(Saved_File, RichTextBoxStreamType.PlainText);
            }
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*TabPage tp = new TabPage("New Document");
            RichTextBox rtb = new RichTextBox();
            rtb.Dock = DockStyle.Fill;

            tp.Controls.Add(rtb);
            tabControl1.TabPages.Add(tp);*/
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void NewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fontFD.ShowColor = true;
            fontFD.ShowEffects = true;
              
            if (fontFD.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.Font = fontFD.Font;
                richTextBox1.ForeColor = fontFD.Color;
            }
            
        }

        private void WwMStrip_Click(object sender, EventArgs e)
        {
            if(wwMStrip.Checked == false)
            {
                wwMStrip.Checked = true;
                richTextBox1.WordWrap = true;
            }

            else
            {
                wwMStrip.Checked = false;
                richTextBox1.WordWrap = false;
            }
        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            

        }

        private void StatusBarUpdate()
        {
            int statusbarLine = richTextBox1.GetLineFromCharIndex(richTextBox1.GetFirstCharIndexOfCurrentLine());

            int statusbarColumn = richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexOfCurrentLine();

            statusbarLine += 1;
            statusbarColumn += 1;

            toolStripStatusLabel1.Text = "Line: " + statusbarLine.ToString() + ", Column: " + statusbarColumn.ToString();
        }

        private void Maintext_changed(object sender, EventArgs e)
        {
            this.StatusBarUpdate();
        }

        private void OpenFD_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
