using System;
using System.Windows.Forms;
using com.yedijas.organizer.logic;

namespace com.yedijas.organizer.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitDB();
            RefreshAll();
        }

        #region basic function
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
                    DBHelper.AddItem<ToDo>(new ToDo(newTDLDialog.ToDoDescription));
                }
            }
            RefreshToDoList();
        }

        private void btnMarkTDLComplete_Click(object sender, EventArgs e)
        {
            try
            {
                if ((bool)dgvTDL.SelectedRows[0].Cells["Completed"].Value == false)
                {
                    if (MessageBox.Show(this, "Is the shit really completed?"
                    , "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DBHelper.Update<ToDo>(new ToDo
                        {
                            Completed = true,
                            Created = (DateTime)dgvTDL.SelectedRows[0].Cells["Created"].Value,
                            Description = (string)dgvTDL.SelectedRows[0].Cells["Description"].Value,
                            ID = (int)dgvTDL.SelectedRows[0].Cells["ID"].Value
                        });
                        RefreshToDoList();
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(this, "Select a thing from the list, first!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMarkTDLPending_Click(object sender, EventArgs e)
        {
            try
            {
                DBHelper.Update<ToDo>(new ToDo
                {
                    Completed = false,
                    Created = (DateTime)dgvTDL.SelectedRows[0].Cells["Created"].Value,
                    Description = (string)dgvTDL.SelectedRows[0].Cells["Description"].Value,
                    ID = (int)dgvTDL.SelectedRows[0].Cells["ID"].Value
                });
                RefreshToDoList();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(this, "Select a thing from the list, first!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteTDL_Click(object sender, EventArgs e)
        {
            try
            {
                DBHelper.DeleteItemByID<ToDo>((int)dgvTDL.SelectedRows[0].Cells["ID"].Value);
                RefreshToDoList();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(this, "Select a thing from the list, first!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TaskNotCompletedException)
            {
                MessageBox.Show(this, "Only completed task may be closed.", "Error!",
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
                    DBHelper.AddItem<Tugas>(new Tugas(newTaskDialog.DeadLine, newTaskDialog.Description));
                }
            }
            RefreshTaskList();
        }

        private void btDeleteTask_Click(object sender, EventArgs e)
        {
            try
            {
                if ((bool)dgvTasks.SelectedRows[0].Cells["Completed"].Value == false)
                {
                    throw new TaskNotCompletedException("Task must be completed before you may delete it!");
                }
                DBHelper.DeleteItemByID<Tugas>((int)dgvTDL.SelectedRows[0].Cells["ID"].Value);
                RefreshTaskList();
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
                int rowindex = (int)dgvTasks.SelectedRows[0].Cells["ID"].Value;
                string desc = (string)dgvTDL.SelectedRows[0].Cells["Description"].Value;

                if (MessageBox.Show(this, "Have you really done \"" + desc + "\" ?"
                    , "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DBHelper.Update<Tugas>(new Tugas
                    {
                        Completed = true,
                        Created = (DateTime)dgvTDL.SelectedRows[0].Cells["Created"].Value,
                        Description = desc,
                        Deadline = (DateTime)dgvTDL.SelectedRows[0].Cells["Deadline"].Value,
                        ID = rowindex
                    });
                    RefreshNoteList();
                }

                if (MessageBox.Show(this, "Do you want to remove the task?"
                    , "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DBHelper.DeleteItemByID<Tugas>(rowindex);
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
            dgvTasks.DataSource = DBHelper.AllToDataTable<Tugas>();
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