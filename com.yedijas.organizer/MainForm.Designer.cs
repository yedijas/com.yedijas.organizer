
namespace com.yedijas.organizer
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
            this.dgvTDL = new System.Windows.Forms.DataGridView();
            this.btnAddNewTDL = new System.Windows.Forms.Button();
            this.btnMarkTDLComplete = new System.Windows.Forms.Button();
            this.btnMarkTDLPending = new System.Windows.Forms.Button();
            this.TDLGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTDL)).BeginInit();
            this.SuspendLayout();
            // 
            // TDLGroupBox
            // 
            this.TDLGroupBox.Controls.Add(this.btnMarkTDLPending);
            this.TDLGroupBox.Controls.Add(this.btnMarkTDLComplete);
            this.TDLGroupBox.Controls.Add(this.btnAddNewTDL);
            this.TDLGroupBox.Controls.Add(this.dgvTDL);
            this.TDLGroupBox.Location = new System.Drawing.Point(12, 12);
            this.TDLGroupBox.Name = "TDLGroupBox";
            this.TDLGroupBox.Size = new System.Drawing.Size(776, 286);
            this.TDLGroupBox.TabIndex = 0;
            this.TDLGroupBox.TabStop = false;
            this.TDLGroupBox.Text = "To Do List";
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
            this.dgvTDL.Size = new System.Drawing.Size(763, 230);
            this.dgvTDL.TabIndex = 0;
            // 
            // btnAddNewTDL
            // 
            this.btnAddNewTDL.Location = new System.Drawing.Point(695, 256);
            this.btnAddNewTDL.Name = "btnAddNewTDL";
            this.btnAddNewTDL.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewTDL.TabIndex = 1;
            this.btnAddNewTDL.Text = "Add New";
            this.btnAddNewTDL.UseVisualStyleBackColor = true;
            this.btnAddNewTDL.Click += new System.EventHandler(this.btnAddNewTDL_Click);
            // 
            // btnMarkTDLComplete
            // 
            this.btnMarkTDLComplete.Location = new System.Drawing.Point(582, 256);
            this.btnMarkTDLComplete.Name = "btnMarkTDLComplete";
            this.btnMarkTDLComplete.Size = new System.Drawing.Size(107, 23);
            this.btnMarkTDLComplete.TabIndex = 2;
            this.btnMarkTDLComplete.Text = "Mark Completed";
            this.btnMarkTDLComplete.UseVisualStyleBackColor = true;
            this.btnMarkTDLComplete.Click += new System.EventHandler(this.btnMarkTDLComplete_Click);
            // 
            // btnMarkTDLPending
            // 
            this.btnMarkTDLPending.Location = new System.Drawing.Point(469, 256);
            this.btnMarkTDLPending.Name = "btnMarkTDLPending";
            this.btnMarkTDLPending.Size = new System.Drawing.Size(107, 23);
            this.btnMarkTDLPending.TabIndex = 3;
            this.btnMarkTDLPending.Text = "Mark Pending";
            this.btnMarkTDLPending.UseVisualStyleBackColor = true;
            this.btnMarkTDLPending.Click += new System.EventHandler(this.btnMarkTDLPending_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 729);
            this.Controls.Add(this.TDLGroupBox);
            this.Name = "MainForm";
            this.Text = "Yedijas\' Organizer";
            this.TDLGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTDL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TDLGroupBox;
        private System.Windows.Forms.Button btnMarkTDLPending;
        private System.Windows.Forms.Button btnMarkTDLComplete;
        private System.Windows.Forms.Button btnAddNewTDL;
        private System.Windows.Forms.DataGridView dgvTDL;
    }
}

