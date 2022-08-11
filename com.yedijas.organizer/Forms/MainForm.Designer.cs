
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
            this.btnMarkTDLPending = new System.Windows.Forms.Button();
            this.btnMarkTDLComplete = new System.Windows.Forms.Button();
            this.btnAddNewTDL = new System.Windows.Forms.Button();
            this.dgvTDL = new System.Windows.Forms.DataGridView();
            this.NotesGroupBox = new System.Windows.Forms.GroupBox();
            this.dgvNote = new System.Windows.Forms.DataGridView();
            this.btnDeleteNote = new System.Windows.Forms.Button();
            this.btnAddNewNote = new System.Windows.Forms.Button();
            this.btnDeleteTDL = new System.Windows.Forms.Button();
            this.TDLGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTDL)).BeginInit();
            this.NotesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).BeginInit();
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1089, 782);
            this.Controls.Add(this.NotesGroupBox);
            this.Controls.Add(this.TDLGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Yedijas\' Organizer";
            this.TDLGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTDL)).EndInit();
            this.NotesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TDLGroupBox;
        private System.Windows.Forms.Button btnMarkTDLPending;
        private System.Windows.Forms.Button btnMarkTDLComplete;
        private System.Windows.Forms.Button btnAddNewTDL;
        private System.Windows.Forms.DataGridView dgvTDL;
        private System.Windows.Forms.GroupBox NotesGroupBox;
        private System.Windows.Forms.Button btnDeleteNote;
        private System.Windows.Forms.DataGridView dgvNote;
        private System.Windows.Forms.Button btnAddNewNote;
        private System.Windows.Forms.Button btnDeleteTDL;
    }
}

