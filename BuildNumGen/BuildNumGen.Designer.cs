﻿namespace BuildNumGen
{
    partial class BuildNumGen
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
            this.btn_Generate = new System.Windows.Forms.Button();
            this.txt_BuildNum = new System.Windows.Forms.TextBox();
            this.txt_YPS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ReleaseNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Generate
            // 
            this.btn_Generate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Generate.Location = new System.Drawing.Point(12, 101);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(235, 23);
            this.btn_Generate.TabIndex = 0;
            this.btn_Generate.Text = "Generate && Copy To Clipboard";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // txt_BuildNum
            // 
            this.txt_BuildNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_BuildNum.Location = new System.Drawing.Point(166, 65);
            this.txt_BuildNum.Name = "txt_BuildNum";
            this.txt_BuildNum.ReadOnly = true;
            this.txt_BuildNum.Size = new System.Drawing.Size(80, 20);
            this.txt_BuildNum.TabIndex = 2;
            // 
            // txt_YPS
            // 
            this.txt_YPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_YPS.Location = new System.Drawing.Point(209, 12);
            this.txt_YPS.Name = "txt_YPS";
            this.txt_YPS.Size = new System.Drawing.Size(37, 20);
            this.txt_YPS.TabIndex = 1;
            this.txt_YPS.TextChanged += new System.EventHandler(this.txt_YPS_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Years since project start:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Build number:";
            // 
            // txt_ReleaseNum
            // 
            this.txt_ReleaseNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ReleaseNum.Location = new System.Drawing.Point(209, 39);
            this.txt_ReleaseNum.Name = "txt_ReleaseNum";
            this.txt_ReleaseNum.Size = new System.Drawing.Size(37, 20);
            this.txt_ReleaseNum.TabIndex = 6;
            this.txt_ReleaseNum.TextChanged += new System.EventHandler(this.txt_ReleaseNum_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Release number:";
            // 
            // BuildNumGen
            // 
            this.AcceptButton = this.btn_Generate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 136);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ReleaseNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_YPS);
            this.Controls.Add(this.txt_BuildNum);
            this.Controls.Add(this.btn_Generate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuildNumGen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Build Number Generator";
            this.Load += new System.EventHandler(this.BuildNumGen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.TextBox txt_BuildNum;
        private System.Windows.Forms.TextBox txt_YPS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ReleaseNum;
        private System.Windows.Forms.Label label3;
    }
}

