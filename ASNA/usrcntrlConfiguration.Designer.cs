﻿namespace ASNA
{
    partial class usrcntrlConfiguration
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstboxSites = new System.Windows.Forms.ListBox();
            this.dgridSystem = new System.Windows.Forms.DataGridView();
            this.dgridSFTP = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddSite = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblRename = new System.Windows.Forms.Label();
            this.txtRenameBox = new System.Windows.Forms.TextBox();
            this.btnRenameOK = new System.Windows.Forms.Button();
            this.btnAddNewline = new System.Windows.Forms.Button();
            this.btnAddCommand = new System.Windows.Forms.Button();
            this.txtStatusBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgridSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridSFTP)).BeginInit();
            this.SuspendLayout();
            // 
            // lstboxSites
            // 
            this.lstboxSites.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstboxSites.FormattingEnabled = true;
            this.lstboxSites.Location = new System.Drawing.Point(0, 0);
            this.lstboxSites.Name = "lstboxSites";
            this.lstboxSites.Size = new System.Drawing.Size(250, 706);
            this.lstboxSites.TabIndex = 0;
            this.lstboxSites.TabStop = false;
            this.lstboxSites.SelectedIndexChanged += new System.EventHandler(this.lstboxSites_SelectedIndexChanged);
            // 
            // dgridSystem
            // 
            this.dgridSystem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgridSystem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridSystem.Location = new System.Drawing.Point(259, 180);
            this.dgridSystem.Name = "dgridSystem";
            this.dgridSystem.Size = new System.Drawing.Size(674, 170);
            this.dgridSystem.TabIndex = 2;
            this.dgridSystem.TabStop = false;
            this.dgridSystem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridSystem_CellContentClick);
            // 
            // dgridSFTP
            // 
            this.dgridSFTP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgridSFTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridSFTP.Location = new System.Drawing.Point(259, 356);
            this.dgridSFTP.Name = "dgridSFTP";
            this.dgridSFTP.Size = new System.Drawing.Size(674, 170);
            this.dgridSFTP.TabIndex = 3;
            this.dgridSFTP.TabStop = false;
            this.dgridSFTP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridSFTP_CellContentClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(256, 652);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 51);
            this.btnSave.TabIndex = 4;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddSite
            // 
            this.btnAddSite.Location = new System.Drawing.Point(398, 652);
            this.btnAddSite.Name = "btnAddSite";
            this.btnAddSite.Size = new System.Drawing.Size(136, 51);
            this.btnAddSite.TabIndex = 5;
            this.btnAddSite.TabStop = false;
            this.btnAddSite.Text = "Add Site";
            this.btnAddSite.UseVisualStyleBackColor = true;
            this.btnAddSite.Click += new System.EventHandler(this.btnAddSite_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(540, 652);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(136, 51);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.TabStop = false;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(797, 652);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 51);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblRename
            // 
            this.lblRename.AutoSize = true;
            this.lblRename.Location = new System.Drawing.Point(537, 599);
            this.lblRename.Name = "lblRename";
            this.lblRename.Size = new System.Drawing.Size(47, 13);
            this.lblRename.TabIndex = 8;
            this.lblRename.Text = "Rename";
            // 
            // txtRenameBox
            // 
            this.txtRenameBox.Location = new System.Drawing.Point(540, 617);
            this.txtRenameBox.MaxLength = 60;
            this.txtRenameBox.Name = "txtRenameBox";
            this.txtRenameBox.Size = new System.Drawing.Size(278, 20);
            this.txtRenameBox.TabIndex = 9;
            this.txtRenameBox.TabStop = false;
            // 
            // btnRenameOK
            // 
            this.btnRenameOK.Location = new System.Drawing.Point(824, 613);
            this.btnRenameOK.Name = "btnRenameOK";
            this.btnRenameOK.Size = new System.Drawing.Size(52, 20);
            this.btnRenameOK.TabIndex = 10;
            this.btnRenameOK.TabStop = false;
            this.btnRenameOK.Text = "OK";
            this.btnRenameOK.UseVisualStyleBackColor = true;
            this.btnRenameOK.Click += new System.EventHandler(this.btnRenameOK_Click);
            // 
            // btnAddNewline
            // 
            this.btnAddNewline.Location = new System.Drawing.Point(838, 4);
            this.btnAddNewline.Name = "btnAddNewline";
            this.btnAddNewline.Size = new System.Drawing.Size(95, 51);
            this.btnAddNewline.TabIndex = 14;
            this.btnAddNewline.Text = "Add Newline";
            this.btnAddNewline.UseVisualStyleBackColor = true;
            this.btnAddNewline.Click += new System.EventHandler(this.btnAddNewline_Click);
            // 
            // btnAddCommand
            // 
            this.btnAddCommand.Location = new System.Drawing.Point(838, 123);
            this.btnAddCommand.Name = "btnAddCommand";
            this.btnAddCommand.Size = new System.Drawing.Size(95, 51);
            this.btnAddCommand.TabIndex = 15;
            this.btnAddCommand.Text = "Add Custom Text";
            this.btnAddCommand.UseVisualStyleBackColor = true;
            this.btnAddCommand.Click += new System.EventHandler(this.btnAddCommand_Click);
            // 
            // txtStatusBox
            // 
            this.txtStatusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusBox.Location = new System.Drawing.Point(262, 4);
            this.txtStatusBox.Name = "txtStatusBox";
            this.txtStatusBox.Size = new System.Drawing.Size(570, 170);
            this.txtStatusBox.TabIndex = 16;
            this.txtStatusBox.TabStop = false;
            this.txtStatusBox.Text = "";
            this.txtStatusBox.TextChanged += new System.EventHandler(this.txtStatusBox_TextChanged_1);
            // 
            // usrcntrlConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtStatusBox);
            this.Controls.Add(this.btnAddCommand);
            this.Controls.Add(this.btnAddNewline);
            this.Controls.Add(this.btnRenameOK);
            this.Controls.Add(this.txtRenameBox);
            this.Controls.Add(this.lblRename);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddSite);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgridSFTP);
            this.Controls.Add(this.dgridSystem);
            this.Controls.Add(this.lstboxSites);
            this.MaximumSize = new System.Drawing.Size(936, 706);
            this.Name = "usrcntrlConfiguration";
            this.Size = new System.Drawing.Size(936, 706);
            ((System.ComponentModel.ISupportInitialize)(this.dgridSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridSFTP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxSites;
        private System.Windows.Forms.DataGridView dgridSystem;
        private System.Windows.Forms.DataGridView dgridSFTP;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddSite;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblRename;
        private System.Windows.Forms.TextBox txtRenameBox;
        private System.Windows.Forms.Button btnRenameOK;
        private System.Windows.Forms.Button btnAddNewline;
        private System.Windows.Forms.Button btnAddCommand;
        private System.Windows.Forms.RichTextBox txtStatusBox;
    }
}