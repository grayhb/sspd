﻿namespace Контроль_запросов_ТКП.SelectForm
{
    partial class ListZadGip
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.NumZad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShPrj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePrj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIPOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filter = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.элВерсияЗаданияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Фильтр = new System.Windows.Forms.ToolStripMenuItem();
            this.ФМесяц = new System.Windows.Forms.ToolStripMenuItem();
            this.ФПроект = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ФОтсутствует = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumZad,
            this.ShPrj,
            this.NamePrj,
            this.GIPOut,
            this.DateOut,
            this.Note});
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(0, 44);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(892, 529);
            this.DGV.TabIndex = 16;
            this.DGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellDoubleClick);
            this.DGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGV_KeyDown);
            // 
            // NumZad
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NumZad.DefaultCellStyle = dataGridViewCellStyle2;
            this.NumZad.HeaderText = "№ Зад.";
            this.NumZad.Name = "NumZad";
            this.NumZad.ReadOnly = true;
            this.NumZad.Width = 75;
            // 
            // ShPrj
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShPrj.DefaultCellStyle = dataGridViewCellStyle3;
            this.ShPrj.HeaderText = "Шифр проекта";
            this.ShPrj.Name = "ShPrj";
            this.ShPrj.ReadOnly = true;
            this.ShPrj.Width = 200;
            // 
            // NamePrj
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NamePrj.DefaultCellStyle = dataGridViewCellStyle4;
            this.NamePrj.HeaderText = "Наименование проекта";
            this.NamePrj.Name = "NamePrj";
            this.NamePrj.ReadOnly = true;
            this.NamePrj.Width = 400;
            // 
            // GIPOut
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GIPOut.DefaultCellStyle = dataGridViewCellStyle5;
            this.GIPOut.HeaderText = "Выдал";
            this.GIPOut.Name = "GIPOut";
            this.GIPOut.ReadOnly = true;
            // 
            // DateOut
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateOut.DefaultCellStyle = dataGridViewCellStyle6;
            this.DateOut.HeaderText = "Дата выдачи";
            this.DateOut.Name = "DateOut";
            this.DateOut.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Note.DefaultCellStyle = dataGridViewCellStyle7;
            this.Note.HeaderText = "Краткое содержание";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // Filter
            // 
            this.Filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.Filter.Location = new System.Drawing.Point(0, 24);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(892, 20);
            this.Filter.TabIndex = 17;
            this.Filter.TextChanged += new System.EventHandler(this.Filter_TextChanged);
            this.Filter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Filter_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииToolStripMenuItem,
            this.элВерсияЗаданияToolStripMenuItem,
            this.Фильтр});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьToolStripMenuItem,
            this.toolStripSeparator1,
            this.закрытьToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // выбратьToolStripMenuItem
            // 
            this.выбратьToolStripMenuItem.Name = "выбратьToolStripMenuItem";
            this.выбратьToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.выбратьToolStripMenuItem.Text = "Выбрать";
            this.выбратьToolStripMenuItem.Click += new System.EventHandler(this.выбратьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // элВерсияЗаданияToolStripMenuItem
            // 
            this.элВерсияЗаданияToolStripMenuItem.Name = "элВерсияЗаданияToolStripMenuItem";
            this.элВерсияЗаданияToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.элВерсияЗаданияToolStripMenuItem.Text = "Эл. версия задания";
            this.элВерсияЗаданияToolStripMenuItem.Click += new System.EventHandler(this.элВерсияЗаданияToolStripMenuItem_Click);
            // 
            // Фильтр
            // 
            this.Фильтр.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ФМесяц,
            this.ФПроект,
            this.toolStripSeparator2,
            this.ФОтсутствует});
            this.Фильтр.Name = "Фильтр";
            this.Фильтр.Size = new System.Drawing.Size(57, 20);
            this.Фильтр.Text = "Фильтр";
            // 
            // ФМесяц
            // 
            this.ФМесяц.Checked = true;
            this.ФМесяц.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ФМесяц.Name = "ФМесяц";
            this.ФМесяц.Size = new System.Drawing.Size(186, 22);
            this.ФМесяц.Text = "За последний месяц";
            this.ФМесяц.Click += new System.EventHandler(this.ФМесяц_Click);
            // 
            // ФПроект
            // 
            this.ФПроект.Name = "ФПроект";
            this.ФПроект.Size = new System.Drawing.Size(186, 22);
            this.ФПроект.Text = "По проекту";
            this.ФПроект.Click += new System.EventHandler(this.ФПроект_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // ФОтсутствует
            // 
            this.ФОтсутствует.Name = "ФОтсутствует";
            this.ФОтсутствует.Size = new System.Drawing.Size(186, 22);
            this.ФОтсутствует.Text = "Отсутствует";
            this.ФОтсутствует.Click += new System.EventHandler(this.ФОтсутствует_Click);
            // 
            // ListZadGip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 573);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.Name = "ListZadGip";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реестр заданий (от Бюро ГИП)";
            this.Load += new System.EventHandler(this.ListZadGip_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListZadGip_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.TextBox Filter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem элВерсияЗаданияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Фильтр;
        private System.Windows.Forms.ToolStripMenuItem ФМесяц;
        private System.Windows.Forms.ToolStripMenuItem ФПроект;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ФОтсутствует;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumZad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShPrj;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePrj;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIPOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}