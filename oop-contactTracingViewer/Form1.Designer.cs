﻿namespace oop_contactTracingViewer
{
    partial class viewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewer));
            this.outerTable = new System.Windows.Forms.TableLayoutPanel();
            this.innerTable = new System.Windows.Forms.TableLayoutPanel();
            this.header = new System.Windows.Forms.Label();
            this.submissionGroup = new System.Windows.Forms.GroupBox();
            this.submission = new System.Windows.Forms.Label();
            this.nameGroup = new System.Windows.Forms.GroupBox();
            this.name = new System.Windows.Forms.Label();
            this.addressGroup = new System.Windows.Forms.GroupBox();
            this.address = new System.Windows.Forms.Label();
            this.contactsGroup = new System.Windows.Forms.GroupBox();
            this.contacts = new System.Windows.Forms.Label();
            this.statusGroup = new System.Windows.Forms.GroupBox();
            this.status = new System.Windows.Forms.Label();
            this.tempGroup = new System.Windows.Forms.GroupBox();
            this.temp = new System.Windows.Forms.Label();
            this.genderGroup = new System.Windows.Forms.GroupBox();
            this.gender = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.page = new System.Windows.Forms.Label();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.outerTable.SuspendLayout();
            this.innerTable.SuspendLayout();
            this.submissionGroup.SuspendLayout();
            this.nameGroup.SuspendLayout();
            this.addressGroup.SuspendLayout();
            this.contactsGroup.SuspendLayout();
            this.statusGroup.SuspendLayout();
            this.tempGroup.SuspendLayout();
            this.genderGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outerTable
            // 
            this.outerTable.ColumnCount = 3;
            this.outerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.outerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.outerTable.Controls.Add(this.innerTable, 1, 1);
            this.outerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outerTable.Location = new System.Drawing.Point(0, 0);
            this.outerTable.Name = "outerTable";
            this.outerTable.RowCount = 3;
            this.outerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.outerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.outerTable.Size = new System.Drawing.Size(780, 457);
            this.outerTable.TabIndex = 0;
            // 
            // innerTable
            // 
            this.innerTable.BackColor = System.Drawing.SystemColors.Control;
            this.innerTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.innerTable.ColumnCount = 3;
            this.innerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.innerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.innerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.innerTable.Controls.Add(this.header, 0, 0);
            this.innerTable.Controls.Add(this.submissionGroup, 0, 1);
            this.innerTable.Controls.Add(this.nameGroup, 0, 2);
            this.innerTable.Controls.Add(this.addressGroup, 0, 3);
            this.innerTable.Controls.Add(this.contactsGroup, 0, 4);
            this.innerTable.Controls.Add(this.statusGroup, 1, 4);
            this.innerTable.Controls.Add(this.tempGroup, 2, 1);
            this.innerTable.Controls.Add(this.genderGroup, 2, 2);
            this.innerTable.Controls.Add(this.tableLayoutPanel1, 1, 5);
            this.innerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerTable.Location = new System.Drawing.Point(23, 23);
            this.innerTable.Name = "innerTable";
            this.innerTable.RowCount = 6;
            this.innerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.innerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2853F));
            this.innerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2853F));
            this.innerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2853F));
            this.innerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2853F));
            this.innerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2853F));
            this.innerTable.Size = new System.Drawing.Size(734, 411);
            this.innerTable.TabIndex = 0;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.innerTable.SetColumnSpan(this.header, 3);
            this.header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header.Font = new System.Drawing.Font("Century Gothic", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.header.Location = new System.Drawing.Point(3, 0);
            this.header.Name = "header";
            this.header.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.header.Size = new System.Drawing.Size(728, 68);
            this.header.TabIndex = 0;
            this.header.Text = "CT Database";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submissionGroup
            // 
            this.innerTable.SetColumnSpan(this.submissionGroup, 2);
            this.submissionGroup.Controls.Add(this.submission);
            this.submissionGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submissionGroup.Location = new System.Drawing.Point(3, 71);
            this.submissionGroup.Name = "submissionGroup";
            this.submissionGroup.Size = new System.Drawing.Size(482, 62);
            this.submissionGroup.TabIndex = 12;
            this.submissionGroup.TabStop = false;
            this.submissionGroup.Text = "Date and Time of Submission";
            // 
            // submission
            // 
            this.submission.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.submission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submission.Font = new System.Drawing.Font("Century Gothic", 13.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.submission.Location = new System.Drawing.Point(3, 18);
            this.submission.Name = "submission";
            this.submission.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.submission.Size = new System.Drawing.Size(476, 41);
            this.submission.TabIndex = 0;
            this.submission.Text = "Loading...";
            this.submission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameGroup
            // 
            this.innerTable.SetColumnSpan(this.nameGroup, 2);
            this.nameGroup.Controls.Add(this.name);
            this.nameGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameGroup.Location = new System.Drawing.Point(3, 139);
            this.nameGroup.Name = "nameGroup";
            this.nameGroup.Size = new System.Drawing.Size(482, 62);
            this.nameGroup.TabIndex = 13;
            this.nameGroup.TabStop = false;
            this.nameGroup.Text = "Full Name";
            // 
            // name
            // 
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name.Font = new System.Drawing.Font("Century Gothic", 13.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(3, 18);
            this.name.Name = "name";
            this.name.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.name.Size = new System.Drawing.Size(476, 41);
            this.name.TabIndex = 0;
            this.name.Text = "Loading...";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addressGroup
            // 
            this.innerTable.SetColumnSpan(this.addressGroup, 3);
            this.addressGroup.Controls.Add(this.address);
            this.addressGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressGroup.Location = new System.Drawing.Point(3, 207);
            this.addressGroup.Name = "addressGroup";
            this.addressGroup.Size = new System.Drawing.Size(728, 62);
            this.addressGroup.TabIndex = 14;
            this.addressGroup.TabStop = false;
            this.addressGroup.Text = "Complete Address";
            // 
            // address
            // 
            this.address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.address.Font = new System.Drawing.Font("Century Gothic", 13.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.address.Location = new System.Drawing.Point(3, 18);
            this.address.Name = "address";
            this.address.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.address.Size = new System.Drawing.Size(722, 41);
            this.address.TabIndex = 0;
            this.address.Text = "Loading...";
            this.address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contactsGroup
            // 
            this.contactsGroup.Controls.Add(this.contacts);
            this.contactsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactsGroup.Location = new System.Drawing.Point(3, 275);
            this.contactsGroup.Name = "contactsGroup";
            this.contactsGroup.Size = new System.Drawing.Size(238, 62);
            this.contactsGroup.TabIndex = 15;
            this.contactsGroup.TabStop = false;
            this.contactsGroup.Text = "Contacts";
            // 
            // contacts
            // 
            this.contacts.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contacts.Font = new System.Drawing.Font("Century Gothic", 13.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.contacts.Location = new System.Drawing.Point(3, 18);
            this.contacts.Name = "contacts";
            this.contacts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.contacts.Size = new System.Drawing.Size(232, 41);
            this.contacts.TabIndex = 0;
            this.contacts.Text = "Loading...";
            this.contacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusGroup
            // 
            this.innerTable.SetColumnSpan(this.statusGroup, 2);
            this.statusGroup.Controls.Add(this.status);
            this.statusGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusGroup.Location = new System.Drawing.Point(247, 275);
            this.statusGroup.Name = "statusGroup";
            this.statusGroup.Size = new System.Drawing.Size(484, 62);
            this.statusGroup.TabIndex = 16;
            this.statusGroup.TabStop = false;
            this.statusGroup.Text = "Status";
            // 
            // status
            // 
            this.status.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.status.Font = new System.Drawing.Font("Century Gothic", 13.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.status.Location = new System.Drawing.Point(3, 18);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.status.Size = new System.Drawing.Size(478, 41);
            this.status.TabIndex = 0;
            this.status.Text = "Loading...";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tempGroup
            // 
            this.tempGroup.Controls.Add(this.temp);
            this.tempGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tempGroup.Location = new System.Drawing.Point(491, 71);
            this.tempGroup.Name = "tempGroup";
            this.tempGroup.Size = new System.Drawing.Size(240, 62);
            this.tempGroup.TabIndex = 17;
            this.tempGroup.TabStop = false;
            this.tempGroup.Text = "Temperature";
            // 
            // temp
            // 
            this.temp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.temp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temp.Font = new System.Drawing.Font("Century Gothic", 13.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.temp.Location = new System.Drawing.Point(3, 18);
            this.temp.Name = "temp";
            this.temp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.temp.Size = new System.Drawing.Size(234, 41);
            this.temp.TabIndex = 0;
            this.temp.Text = "Loading...";
            this.temp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // genderGroup
            // 
            this.genderGroup.Controls.Add(this.gender);
            this.genderGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genderGroup.Location = new System.Drawing.Point(491, 139);
            this.genderGroup.Name = "genderGroup";
            this.genderGroup.Size = new System.Drawing.Size(240, 62);
            this.genderGroup.TabIndex = 18;
            this.genderGroup.TabStop = false;
            this.genderGroup.Text = "Gender";
            // 
            // gender
            // 
            this.gender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gender.Font = new System.Drawing.Font("Century Gothic", 13.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.gender.Location = new System.Drawing.Point(3, 18);
            this.gender.Name = "gender";
            this.gender.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.gender.Size = new System.Drawing.Size(234, 41);
            this.gender.TabIndex = 0;
            this.gender.Text = "Loading...";
            this.gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Controls.Add(this.page, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.right, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.left, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(247, 343);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(238, 65);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // page
            // 
            this.page.AutoSize = true;
            this.page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page.Location = new System.Drawing.Point(78, 10);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(82, 45);
            this.page.TabIndex = 0;
            this.page.Text = "X out of Y";
            this.page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // right
            // 
            this.right.Font = new System.Drawing.Font("Century Gothic", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.right.Location = new System.Drawing.Point(166, 13);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(69, 39);
            this.right.TabIndex = 10;
            this.right.Text = ">";
            this.right.UseVisualStyleBackColor = true;
            // 
            // left
            // 
            this.left.Font = new System.Drawing.Font("Century Gothic", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.left.Location = new System.Drawing.Point(3, 13);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(69, 39);
            this.left.TabIndex = 9;
            this.left.Text = "<";
            this.left.UseVisualStyleBackColor = true;
            // 
            // viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Controls.Add(this.outerTable);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "viewer";
            this.Text = "Contact Tracing Viewer";
            this.outerTable.ResumeLayout(false);
            this.innerTable.ResumeLayout(false);
            this.innerTable.PerformLayout();
            this.submissionGroup.ResumeLayout(false);
            this.nameGroup.ResumeLayout(false);
            this.addressGroup.ResumeLayout(false);
            this.contactsGroup.ResumeLayout(false);
            this.statusGroup.ResumeLayout(false);
            this.tempGroup.ResumeLayout(false);
            this.genderGroup.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel outerTable;
        private System.Windows.Forms.TableLayoutPanel innerTable;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.GroupBox submissionGroup;
        private System.Windows.Forms.Label submission;
        private System.Windows.Forms.GroupBox nameGroup;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.GroupBox addressGroup;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.GroupBox contactsGroup;
        private System.Windows.Forms.Label contacts;
        private System.Windows.Forms.GroupBox statusGroup;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.GroupBox tempGroup;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.GroupBox genderGroup;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label page;
    }
}
