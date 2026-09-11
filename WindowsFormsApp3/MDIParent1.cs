using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void TampilkanFormChild(Form Child)
        {
            Child.MdiParent = this;
            Child.StartPosition = FormStartPosition.Manual;
            Child.Show();

            int x = (this.ClientSize.Width - Child.Width) / 2;
            int y = (this.ClientSize.Width - Child.Width) / 2;

            Child.Location = new Point(Math.Max(0, x), Math.Max(0, y));
        }

        public string sus;
        private void siswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSiswa frmchild = new FormSiswa();
            frmchild.MdiParent = this;
            TampilkanFormChild(frmchild);
        }

        private void guruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGuru frmchild = new FormGuru();
                frmchild.MdiParent = this;
            TampilkanFormChild(frmchild);
        }

        private void ptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPT frmchild = new FormPT();
            frmchild.MdiParent = this;
            TampilkanFormChild(frmchild);
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            DialogResult setuju = MessageBox.Show("Apakah yakin?", "Pemeberithauan", MessageBoxButtons.YesNo);

            if (setuju == DialogResult.Yes)
            {
                Form1 Gibran = new Form1();
                Gibran.Visible = true;
                this.Hide();
            }
        }

        private void btnDataSiswa_Click(object sender, EventArgs e)
        {
            FormSiswa frmchild = new FormSiswa();
            frmchild.MdiParent = this;
            TampilkanFormChild(frmchild);
        }

        private void btnDataGuru_Click(object sender, EventArgs e)
        {
            FormGuru frmchild = new FormGuru();
            frmchild.MdiParent = this;
            TampilkanFormChild(frmchild);
        }

        private void btnDataPT_Click(object sender, EventArgs e)
        {
            FormPT frmchild = new FormPT();
            frmchild.MdiParent = this;
            TampilkanFormChild(frmchild);
        }
    }
}
