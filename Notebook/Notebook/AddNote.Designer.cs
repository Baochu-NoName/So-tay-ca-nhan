﻿
namespace Notebook
{
    partial class AddNote
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
            this.components = new System.ComponentModel.Container();
            this.returnaddscrnbtn = new System.Windows.Forms.Button();
            this.Addnotebtn = new System.Windows.Forms.Button();
            this.descripbox = new System.Windows.Forms.RichTextBox();
            this.titlebox = new System.Windows.Forms.TextBox();
            this.datebox = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // returnaddscrnbtn
            // 
            this.returnaddscrnbtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnaddscrnbtn.Location = new System.Drawing.Point(12, 606);
            this.returnaddscrnbtn.Name = "returnaddscrnbtn";
            this.returnaddscrnbtn.Size = new System.Drawing.Size(148, 46);
            this.returnaddscrnbtn.TabIndex = 4;
            this.returnaddscrnbtn.Text = "Quay lại";
            this.returnaddscrnbtn.UseVisualStyleBackColor = true;
            this.returnaddscrnbtn.Click += new System.EventHandler(this.returnaddscrnbtn_Click);
            // 
            // Addnotebtn
            // 
            this.Addnotebtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addnotebtn.Location = new System.Drawing.Point(881, 606);
            this.Addnotebtn.Name = "Addnotebtn";
            this.Addnotebtn.Size = new System.Drawing.Size(140, 46);
            this.Addnotebtn.TabIndex = 10;
            this.Addnotebtn.Text = "Thêm";
            this.Addnotebtn.UseVisualStyleBackColor = true;
            this.Addnotebtn.Click += new System.EventHandler(this.Addnotebtn_Click);
            // 
            // descripbox
            // 
            this.descripbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripbox.Location = new System.Drawing.Point(12, 190);
            this.descripbox.Name = "descripbox";
            this.descripbox.Size = new System.Drawing.Size(1009, 391);
            this.descripbox.TabIndex = 11;
            this.descripbox.Text = "";
            this.descripbox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // titlebox
            // 
            this.titlebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlebox.Location = new System.Drawing.Point(12, 126);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(941, 38);
            this.titlebox.TabIndex = 12;
            this.titlebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // datebox
            // 
            this.datebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datebox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datebox.Location = new System.Drawing.Point(675, 70);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(130, 30);
            this.datebox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tiêu đề:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(499, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ngày và tháng:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1043, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 678);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.titlebox);
            this.Controls.Add(this.descripbox);
            this.Controls.Add(this.Addnotebtn);
            this.Controls.Add(this.returnaddscrnbtn);
            this.Name = "AddNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnaddscrnbtn;
        private System.Windows.Forms.Button Addnotebtn;
        private System.Windows.Forms.RichTextBox descripbox;
        private System.Windows.Forms.TextBox titlebox;
        private System.Windows.Forms.DateTimePicker datebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}