using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.yedijas.organizer.logic;

namespace com.yedijas.organizer
{
    public partial class MainForm : Form
    {
        private logic.ToDos.ToDoList myToDoList;

        public MainForm()
        {
            InitializeComponent();
            myToDoList = new logic.ToDos.ToDoList();
            RefreshToDoList();
        }

        private void btnAddNewTDL_Click(object sender, EventArgs e)
        {
            using (NewToDoListDialog newTDLDialog = new NewToDoListDialog())
            {
                if (newTDLDialog.ShowDialog() == DialogResult.OK)
                {
                    myToDoList.DaftarToDo.Add(new logic.ToDos.ToDo(newTDLDialog.ToDoDeadline, newTDLDialog.ToDoDescription));
                }
            }
            Console.WriteLine(myToDoList.DaftarToDo.Count);
            RefreshToDoList();
        }

        private void RefreshToDoList()
        {
            DataTable ds = myToDoList.ExportToDataTable();
            dgvTDL.DataSource = ds;
            dgvTDL.Update();
            dgvTDL.Refresh();
        }

        private void btnMarkTDLComplete_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvTDL.SelectedRows[0].Index;
            myToDoList.MarkItemCompleted(rowIndex);
            RefreshToDoList();
        }

        private void btnMarkTDLPending_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvTDL.SelectedRows[0].Index;
            myToDoList.MarkItemPending(rowIndex);
            RefreshToDoList();
        }
    }
}
