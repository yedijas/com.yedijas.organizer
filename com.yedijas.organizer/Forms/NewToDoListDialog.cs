﻿using System;
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
    public partial class NewToDoListDialog : Form
    {
        public String ToDoDescription;

        public NewToDoListDialog()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ToDoDescription = tbDescription.Text;
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
