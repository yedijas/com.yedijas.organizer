
namespace com.yedijas.organizer.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TDLGroupBox = new System.Windows.Forms.GroupBox();
            this.btnDeleteTDL = new System.Windows.Forms.Button();
            this.btnAddNewTDL = new System.Windows.Forms.Button();
            this.dgvTDL = new System.Windows.Forms.DataGridView();
            this.NotesGroupBox = new System.Windows.Forms.GroupBox();
            this.btnDeleteNote = new System.Windows.Forms.Button();
            this.dgvNote = new System.Windows.Forms.DataGridView();
            this.btnAddNewNote = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteTasks = new System.Windows.Forms.Button();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.btnAddNewTasks = new System.Windows.Forms.Button();
            this.btnMarkTDLPending = new System.Windows.Forms.Button();
            this.btnMarkTDLComplete = new System.Windows.Forms.Button();
            this.TDLGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTDL)).BeginInit();
            this.NotesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // TDLGroupBox
            // 
            this.TDLGroupBox.Controls.Add(this.btnDeleteTDL);
            this.TDLGroupBox.Controls.Add(this.btnMarkTDLPending);
            this.TDLGroupBox.Controls.Add(this.btnMarkTDLComplete);
            this.TDLGroupBox.Controls.Add(this.btnAddNewTDL);
            this.TDLGroupBox.Controls.Add(this.dgvTDL);
            this.TDLGroupBox.Location = new System.Drawing.Point(12, 2);
            this.TDLGroupBox.Name = "TDLGroupBox";
            this.TDLGroupBox.Size = new System.Drawing.Size(527, 286);
            this.TDLGroupBox.TabIndex = 0;
            this.TDLGroupBox.TabStop = false;
            this.TDLGroupBox.Text = "To Do List";
            // 
            // btnDeleteTDL
            // 
            this.btnDeleteTDL.Location = new System.Drawing.Point(101, 256);
            this.btnDeleteTDL.Name = "btnDeleteTDL";
            this.btnDeleteTDL.Size = new System.Drawing.Size(107, 23);
            this.btnDeleteTDL.TabIndex = 6;
            this.btnDeleteTDL.Text = "Delete";
            this.btnDeleteTDL.UseVisualStyleBackColor = true;
            this.btnDeleteTDL.Click += new System.EventHandler(this.btnDeleteTDL_Click);
            // 
            // btnAddNewTDL
            // 
            this.btnAddNewTDL.Location = new System.Drawing.Point(440, 256);
            this.btnAddNewTDL.Name = "btnAddNewTDL";
            this.btnAddNewTDL.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewTDL.TabIndex = 1;
            this.btnAddNewTDL.Text = "Add New";
            this.btnAddNewTDL.UseVisualStyleBackColor = true;
            this.btnAddNewTDL.Click += new System.EventHandler(this.btnAddNewTDL_Click);
            // 
            // dgvTDL
            // 
            this.dgvTDL.AllowUserToAddRows = false;
            this.dgvTDL.AllowUserToDeleteRows = false;
            this.dgvTDL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTDL.Location = new System.Drawing.Point(7, 20);
            this.dgvTDL.MultiSelect = false;
            this.dgvTDL.Name = "dgvTDL";
            this.dgvTDL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTDL.Size = new System.Drawing.Size(508, 230);
            this.dgvTDL.TabIndex = 0;
            // 
            // NotesGroupBox
            // 
            this.NotesGroupBox.Controls.Add(this.btnDeleteNote);
            this.NotesGroupBox.Controls.Add(this.dgvNote);
            this.NotesGroupBox.Controls.Add(this.btnAddNewNote);
            this.NotesGroupBox.Location = new System.Drawing.Point(545, 1);
            this.NotesGroupBox.Name = "NotesGroupBox";
            this.NotesGroupBox.Size = new System.Drawing.Size(527, 287);
            this.NotesGroupBox.TabIndex = 1;
            this.NotesGroupBox.TabStop = false;
            this.NotesGroupBox.Text = "Notes";
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.Location = new System.Drawing.Point(327, 257);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(107, 23);
            this.btnDeleteNote.TabIndex = 5;
            this.btnDeleteNote.Text = "Delete";
            this.btnDeleteNote.UseVisualStyleBackColor = true;
            this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
            // 
            // dgvNote
            // 
            this.dgvNote.AllowUserToAddRows = false;
            this.dgvNote.AllowUserToDeleteRows = false;
            this.dgvNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNote.Location = new System.Drawing.Point(7, 19);
            this.dgvNote.MultiSelect = false;
            this.dgvNote.Name = "dgvNote";
            this.dgvNote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNote.Size = new System.Drawing.Size(508, 232);
            this.dgvNote.TabIndex = 4;
            // 
            // btnAddNewNote
            // 
            this.btnAddNewNote.Location = new System.Drawing.Point(440, 257);
            this.btnAddNewNote.Name = "btnAddNewNote";
            this.btnAddNewNote.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewNote.TabIndex = 4;
            this.btnAddNewNote.Text = "Add New";
            this.btnAddNewNote.UseVisualStyleBackColor = true;
            this.btnAddNewNote.Click += new System.EventHandler(this.btnAddNewNote_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteTasks);
            this.groupBox1.Controls.Add(this.dgvTasks);
            this.groupBox1.Controls.Add(this.btnAddNewTasks);
            this.groupBox1.Location = new System.Drawing.Point(12, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 287);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tasks";
            // 
            // btnDeleteTasks
            // 
            this.btnDeleteTasks.Location = new System.Drawing.Point(327, 257);
            this.btnDeleteTasks.Name = "btnDeleteTasks";
            this.btnDeleteTasks.Size = new System.Drawing.Size(107, 23);
            this.btnDeleteTasks.TabIndex = 5;
            this.btnDeleteTasks.Text = "Mark Completed";
            this.btnDeleteTasks.UseVisualStyleBackColor = true;
            this.btnDeleteTasks.Click += new System.EventHandler(this.btnDeleteTasks_Click);
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AllowUserToDeleteRows = false;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(7, 19);
            this.dgvTasks.MultiSelect = false;
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.Size = new System.Drawing.Size(508, 232);
            this.dgvTasks.TabIndex = 4;
            // 
            // btnAddNewTasks
            // 
            this.btnAddNewTasks.Location = new System.Drawing.Point(440, 257);
            this.btnAddNewTasks.Name = "btnAddNewTasks";
            this.btnAddNewTasks.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewTasks.TabIndex = 4;
            this.btnAddNewTasks.Text = "Add New";
            this.btnAddNewTasks.UseVisualStyleBackColor = true;
            this.btnAddNewTasks.Click += new System.EventHandler(this.btnAddNewTasks_Click);
            // 
            // btnMarkTDLPending
            // 
            this.btnMarkTDLPending.Location = new System.Drawing.Point(214, 256);
            this.btnMarkTDLPending.Name = "btnMarkTDLPending";
            this.btnMarkTDLPending.Size = new System.Drawing.Size(107, 23);
            this.btnMarkTDLPending.TabIndex = 3;
            this.btnMarkTDLPending.Text = "Mark Pending";
            this.btnMarkTDLPending.UseVisualStyleBackColor = true;
            this.btnMarkTDLPending.Click += new System.EventHandler(this.btnMarkTDLPending_Click);
            // 
            // btnMarkTDLComplete
            // 
            this.btnMarkTDLComplete.Location = new System.Drawing.Point(327, 256);
            this.btnMarkTDLComplete.Name = "btnMarkTDLComplete";
            this.btnMarkTDLComplete.Size = new System.Drawing.Size(107, 23);
            this.btnMarkTDLComplete.TabIndex = 2;
            this.btnMarkTDLComplete.Text = "Mark Completed";
            this.btnMarkTDLComplete.UseVisualStyleBackColor = true;
            this.btnMarkTDLComplete.Click += new System.EventHandler(this.btnMarkTDLComplete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1089, 782);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NotesGroupBox);
            this.Controls.Add(this.TDLGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Yedijas\' Organizer";
            this.TDLGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTDL)).EndInit();
            this.NotesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TDLGroupBox;
        private System.Windows.Forms.Button btnAddNewTDL;
        private System.Windows.Forms.DataGridView dgvTDL;
        private System.Windows.Forms.GroupBox NotesGroupBox;
        private System.Windows.Forms.Button btnDeleteNote;
        private System.Windows.Forms.DataGridView dgvNote;
        private System.Windows.Forms.Button btnAddNewNote;
        private System.Windows.Forms.Button btnDeleteTDL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteTasks;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Button btnAddNewTasks;
        private System.Windows.Forms.Button btnMarkTDLPending;
        private System.Windows.Forms.Button btnMarkTDLComplete;
    }
}

