﻿namespace SSPD
{
    partial class PhoneSIMCard
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
            this.NSim = new System.Windows.Forms.TextBox();
            this.ANamber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PIN1 = new System.Windows.Forms.TextBox();
            this.PIN2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PUK2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PUK1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.LineSeparatorBottom = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LineSeparatorBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Уникальный номер SIM-карты:";
            // 
            // NSim
            // 
            this.NSim.Location = new System.Drawing.Point(15, 26);
            this.NSim.MaxLength = 20;
            this.NSim.Name = "NSim";
            this.NSim.Size = new System.Drawing.Size(251, 20);
            this.NSim.TabIndex = 12;
            // 
            // ANamber
            // 
            this.ANamber.Location = new System.Drawing.Point(15, 73);
            this.ANamber.MaxLength = 20;
            this.ANamber.Name = "ANamber";
            this.ANamber.Size = new System.Drawing.Size(251, 20);
            this.ANamber.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Абонентский номер:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "PIN1:";
            // 
            // PIN1
            // 
            this.PIN1.Location = new System.Drawing.Point(52, 111);
            this.PIN1.MaxLength = 10;
            this.PIN1.Name = "PIN1";
            this.PIN1.Size = new System.Drawing.Size(80, 20);
            this.PIN1.TabIndex = 16;
            // 
            // PIN2
            // 
            this.PIN2.Location = new System.Drawing.Point(186, 111);
            this.PIN2.MaxLength = 10;
            this.PIN2.Name = "PIN2";
            this.PIN2.Size = new System.Drawing.Size(80, 20);
            this.PIN2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "PIN2:";
            // 
            // PUK2
            // 
            this.PUK2.Location = new System.Drawing.Point(186, 137);
            this.PUK2.MaxLength = 10;
            this.PUK2.Name = "PUK2";
            this.PUK2.Size = new System.Drawing.Size(80, 20);
            this.PUK2.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "PUK2:";
            // 
            // PUK1
            // 
            this.PUK1.Location = new System.Drawing.Point(52, 137);
            this.PUK1.MaxLength = 10;
            this.PUK1.Name = "PUK1";
            this.PUK1.Size = new System.Drawing.Size(80, 20);
            this.PUK1.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "PUK1:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancel.Location = new System.Drawing.Point(191, 177);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 30;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // LineSeparatorBottom
            // 
            this.LineSeparatorBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LineSeparatorBottom.BackgroundImage = global::SSPD.Properties.Resources.LineSeparator;
            this.LineSeparatorBottom.Location = new System.Drawing.Point(12, 167);
            this.LineSeparatorBottom.Name = "LineSeparatorBottom";
            this.LineSeparatorBottom.Size = new System.Drawing.Size(254, 2);
            this.LineSeparatorBottom.TabIndex = 29;
            this.LineSeparatorBottom.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSave.Location = new System.Drawing.Point(110, 177);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 28;
            this.buttonSave.Text = "ОК";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // PhoneSIMCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 212);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.LineSeparatorBottom);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.PUK2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PUK1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PIN2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PIN1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ANamber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NSim);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PhoneSIMCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PhoneSIMCard_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.LineSeparatorBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NSim;
        private System.Windows.Forms.TextBox ANamber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PIN1;
        private System.Windows.Forms.TextBox PIN2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PUK2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PUK1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox LineSeparatorBottom;
        private System.Windows.Forms.Button buttonSave;
    }
}