using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.yedijas.organizer.logic.ToDos;
using com.yedijas.organizer.logic.Notes;

namespace com.yedijas.organizer.Forms
{
    public partial class MainForm : Form
    {
        private ToDoList myToDoList;
        private NoteList myNoteList;

        public MainForm()
        {
            InitializeComponent();
            myToDoList = new ToDoList();
            myNoteList = new NoteList();
            RefreshAll();
        }

        #region to-do list
        private void btnAddNewTDL_Click(object sender, EventArgs e)
        {
            using (NewToDoListDialog newTDLDialog = new NewToDoListDialog())
            {
                if (newTDLDialog.ShowDialog() == DialogResult.OK)
                {
                    myToDoList.AddItem(new logic.ToDos.ToDo(newTDLDialog.ToDoDeadline, newTDLDialog.ToDoDescription));
                }
            }
            RefreshToDoList();
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

        private void btnDeleteTDL_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvTDL.SelectedRows[0].Index;
            myToDoList.MarkItemPending(rowIndex);
            RefreshToDoList();
        }

        private void RefreshToDoList()
        {
            dgvTDL.DataSource = myToDoList.ExportToDataTable();
            dgvTDL.Update();
            dgvTDL.Refresh();
        }
        #endregion

        #region notes
        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            int rowindex = dgvNote.SelectedRows[0].Index;
            myNoteList.RemoveItem(rowindex);
            RefreshNoteList();
        }

        private void btnAddNewNote_Click(object sender, EventArgs e)
        {
            using (NewNoteDialog newNoteDialog = new NewNoteDialog())
            {
                if (newNoteDialog.ShowDialog() == DialogResult.OK)
                {
                    myNoteList.AddItem(new Note(newNoteDialog.NoteDescription));
                }
            }
            RefreshNoteList();
        }

        private void RefreshNoteList()
        {
            dgvNote.DataSource = myNoteList.ExportToDataTable();
            dgvNote.Update();
            dgvNote.Refresh();
        }
        #endregion

        #region combined
        private void RefreshAll()
        {
            RefreshToDoList();
            RefreshNoteList();
        }
        #endregion
    }
}
