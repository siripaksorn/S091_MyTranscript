﻿
namespace MyTranscript
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.textBoxCredit = new System.Windows.Forms.TextBox();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewY1S1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageYear1Sem1 = new System.Windows.Forms.TabPage();
            this.tabPageYear1Sem2 = new System.Windows.Forms.TabPage();
            this.dataGridViewY1S2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewY1S1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageYear1Sem1.SuspendLayout();
            this.tabPageYear1Sem2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewY1S2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "My university name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(68, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(565, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "My faculty name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonAddCourse);
            this.groupBox1.Controls.Add(this.textBoxGrade);
            this.groupBox1.Controls.Add(this.textBoxCredit);
            this.groupBox1.Controls.Add(this.textBoxCourseName);
            this.groupBox1.Controls.Add(this.textBoxCourseID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(11, 387);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(668, 170);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new course";
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(273, 112);
            this.buttonAddCourse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(72, 31);
            this.buttonAddCourse.TabIndex = 8;
            this.buttonAddCourse.Text = "Add";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.AddGrade);
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(114, 117);
            this.textBoxGrade.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(52, 26);
            this.textBoxGrade.TabIndex = 7;
            this.textBoxGrade.Text = "B+";
            // 
            // textBoxCredit
            // 
            this.textBoxCredit.Location = new System.Drawing.Point(114, 87);
            this.textBoxCredit.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCredit.Name = "textBoxCredit";
            this.textBoxCredit.Size = new System.Drawing.Size(52, 26);
            this.textBoxCredit.TabIndex = 6;
            this.textBoxCredit.Text = "3";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(114, 57);
            this.textBoxCourseName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(231, 26);
            this.textBoxCourseName.TabIndex = 5;
            this.textBoxCourseName.Text = "Computer Laboratory";
            // 
            // textBoxCourseID
            // 
            this.textBoxCourseID.Location = new System.Drawing.Point(114, 27);
            this.textBoxCourseID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.Size = new System.Drawing.Size(94, 26);
            this.textBoxCourseID.TabIndex = 4;
            this.textBoxCourseID.Text = "12345678";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Grade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Credit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Course ID";
            // 
            // dataGridViewY1S1
            // 
            this.dataGridViewY1S1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewY1S1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewY1S1.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewY1S1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewY1S1.Name = "dataGridViewY1S1";
            this.dataGridViewY1S1.RowHeadersWidth = 82;
            this.dataGridViewY1S1.RowTemplate.Height = 33;
            this.dataGridViewY1S1.Size = new System.Drawing.Size(654, 268);
            this.dataGridViewY1S1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageYear1Sem1);
            this.tabControl1.Controls.Add(this.tabPageYear1Sem2);
            this.tabControl1.Location = new System.Drawing.Point(11, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 300);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageYear1Sem1
            // 
            this.tabPageYear1Sem1.Controls.Add(this.dataGridViewY1S1);
            this.tabPageYear1Sem1.Location = new System.Drawing.Point(4, 22);
            this.tabPageYear1Sem1.Name = "tabPageYear1Sem1";
            this.tabPageYear1Sem1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageYear1Sem1.Size = new System.Drawing.Size(660, 274);
            this.tabPageYear1Sem1.TabIndex = 0;
            this.tabPageYear1Sem1.Text = "Year 1 Sem 1";
            this.tabPageYear1Sem1.UseVisualStyleBackColor = true;
            // 
            // tabPageYear1Sem2
            // 
            this.tabPageYear1Sem2.Controls.Add(this.dataGridViewY1S2);
            this.tabPageYear1Sem2.Location = new System.Drawing.Point(4, 22);
            this.tabPageYear1Sem2.Name = "tabPageYear1Sem2";
            this.tabPageYear1Sem2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageYear1Sem2.Size = new System.Drawing.Size(660, 274);
            this.tabPageYear1Sem2.TabIndex = 1;
            this.tabPageYear1Sem2.Text = "Year 1 Sem 2";
            this.tabPageYear1Sem2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewY1S2
            // 
            this.dataGridViewY1S2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewY1S2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewY1S2.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewY1S2.Name = "dataGridViewY1S2";
            this.dataGridViewY1S2.Size = new System.Drawing.Size(654, 268);
            this.dataGridViewY1S2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 568);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewY1S1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageYear1Sem1.ResumeLayout(false);
            this.tabPageYear1Sem2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewY1S2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.TextBox textBoxCredit;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.TextBox textBoxCourseID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.DataGridView dataGridViewY1S1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageYear1Sem1;
        private System.Windows.Forms.TabPage tabPageYear1Sem2;
        private System.Windows.Forms.DataGridView dataGridViewY1S2;
    }
}

