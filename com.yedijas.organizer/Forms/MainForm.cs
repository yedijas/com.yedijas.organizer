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
using com.yedijas.organizer.logic.Tasks;
using com.yedijas.organizer.logic.Helper;
using com.yedijas.organizer.logic;

namespace com.yedijas.organizer.Forms
{
    public partial class MainForm : Form
    {
        private ToDoList myToDoList;
        private TaskList myTaskList;

        public MainForm()
        {
            InitializeComponent();
            InitDB();
            InitLists();
            RefreshAll();
        }

        #region basic function
        private void InitLists()
        {
            myToDoList = new ToDoList();
            myTaskList = new TaskList();
        }

        private void InitDB()
        {
            DBHelper.InitDB();
        }
        #endregion

        #region to-do list
        private void btnAddNewTDL_Click(object sender, EventArgs e)
        {
            using (NewToDoListDialog newTDLDialog = new NewToDoListDialog())
            {
                if (newTDLDialog.ShowDialog() == DialogResult.OK)
                {
                    myToDoList.AddItem(new ToDo(newTDLDialog.ToDoDescription));
                }
            }
            RefreshToDoList();
        }

        private void btnMarkTDLComplete_Click(object sender, EventArgs e)
        {
            try
            {

                int rowIndex = dgvTDL.SelectedRows[0].Index;
                if (MessageBox.Show(this, "Is the shit really completed?"
                    , "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    myToDoList.MarkItemCompleted(rowIndex);
                    RefreshToDoList();
                }
            }
            catch (ArgumentOutOfRangeException aore)
            {
                MessageBox.Show(this, "Select a thing from the list, first!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMarkTDLPending_Click(object sender, EventArgs e)
        {
            try
            {

                int rowIndex = dgvTDL.SelectedRows[0].Index;
                myToDoList.MarkItemPending(rowIndex);
                RefreshToDoList();
            }
            catch (ArgumentOutOfRangeException aore)
            {
                MessageBox.Show(this, "Select a thing from the list, first!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteTDL_Click(object sender, EventArgs e)
        {
            try
            {

                int rowIndex = dgvTDL.SelectedRows[0].Index;
                myToDoList.MarkItemPending(rowIndex);
                RefreshToDoList();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(this, "Select a thing from the list, first!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshToDoList()
        {
            dgvTDL.DataSource = DBHelper.AllToDataTable<ToDo>();
            dgvTDL.Update();
            dgvTDL.Refresh();
        }
        #endregion

        #region notes
        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            try
            {
                DBHelper.DeleteItemByID<Note>((int)dgvNote.SelectedRows[0].Cells["ID"].Value);
                RefreshNoteList();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(this, "Select a thing from the list, first!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddNewNote_Click(object sender, EventArgs e)
        {
            using (NewNoteDialog newNoteDialog = new NewNoteDialog())
            {
                if (newNoteDialog.ShowDialog() == DialogResult.OK)
                {
                    DBHelper.AddItem<Note>(new Note(newNoteDialog.NoteDescription));
                }
            }
            RefreshNoteList();
        }

        private void RefreshNoteList()
        {
            dgvNote.DataSource = DBHelper.AllToDataTable<Note>();
            dgvNote.Update();
            dgvNote.Refresh();
        }
        #endregion

        #region tasks
        private void btnAddNewTasks_Click(object sender, EventArgs e)
        {
            using (NewTaskDialog newTaskDialog = new NewTaskDialog())
            {
                if (newTaskDialog.ShowDialog() == DialogResult.OK)
                {
                    myTaskList.AddItem(new Tasks(newTaskDialog.DeadLine, newTaskDialog.Description));
                }
            }
            RefreshTaskList();
        }

        private void btDeleteTask_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dgvTasks.SelectedRows[0].Index;

                myTaskList.RemoveItem(rowindex);
                RefreshNoteList();
            }
            catch (TaskNotCompletedException tce)
            {
                MessageBox.Show(this, tce.Message, "Error!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompleteTasks_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dgvTasks.SelectedRows[0].Index;

                if (MessageBox.Show(this, "Have you really done \"" + myTaskList.GetDescription(rowindex) + "\" ?"
                    , "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    myTaskList.MarkItemCompleted(rowindex);
                    RefreshNoteList();
                }

                if (MessageBox.Show(this, "Do you want to remove the task?"
                    , "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    myTaskList.RemoveItem(rowindex);
                    RefreshNoteList();
                }

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(this, "Select a thing from the list, first!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TaskNotCompletedException tce)
            {
                MessageBox.Show(this, tce.Message, "Error!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshTaskList();
        }

        private void RefreshTaskList()
        {
            dgvTasks.DataSource = DBHelper.AllToDataTable<Tasks>();
            dgvTasks.Update();
            dgvTasks.Refresh();
        }
        #endregion

        #region combined
        private void RefreshAll()
        {
            RefreshToDoList();
            RefreshNoteList();
            RefreshTaskList();
        }
        #endregion
    }
}