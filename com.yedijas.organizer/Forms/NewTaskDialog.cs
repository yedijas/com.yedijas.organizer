using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.yedijas.organizer.Forms
{
    public partial class NewTaskDialog : Form
    {
        public string Description;
        public DateTime DeadLine;

        public NewTaskDialog()
        {
            InitializeComponent();
            dtpDeadline.Value = DateTime.Now;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Description = tbDescription.Text;
            DeadLine = dtpDeadline.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
