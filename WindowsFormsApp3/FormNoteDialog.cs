using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormNoteDialog : Form
    {
        public string Note { get; private set; }

        public FormNoteDialog(string title = "Catatan Revisi")
        {
            InitializeComponent();
            this.Text = title;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Note = txtNote.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
