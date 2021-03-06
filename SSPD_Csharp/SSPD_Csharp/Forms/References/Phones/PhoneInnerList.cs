﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SSPD
{
    public partial class PhoneInnerList : Form
    {

        #region [Объявление переменных]

        private bool ReadOnly;

        public string SelID = "";
        public string SelPhoneInner = "";
        public string SelPhoneTown = "";
        public string SelPhoneMATS = "";
        public string SelPhoneGroup = "";
        public string SelRoom = "";

        #endregion

        #region [Инициализация и загрузка формы]

        public PhoneInnerList(bool FlRead)
        {
            InitializeComponent();

            StrFind.GotFocus += new EventHandler(StrFind_GotFocus);
            StrFind.LostFocus += new EventHandler(StrFind_LostFocus);
            StrFind.KeyDown += new KeyEventHandler(StrFind_KeyDown);

            ReadOnly = FlRead;

            if (ReadOnly == true)
            {
                btnDataAdd.Visible = false;
                btnDataEdit.Visible = false;
                btnDataDel.Visible = false;
                mbtnData.Visible = false;
                btnDataSelect.Visible = true;
                mbtnSelect.Visible = true;
                toolStripSeparator1.Visible = true;
            }
            else
            {
                btnDataAdd.Visible = true;
                btnDataEdit.Visible = true;
                btnDataDel.Visible = true;
                mbtnData.Visible = true;
                btnDataSelect.Visible = false;
                mbtnSelect.Visible = false;
                toolStripSeparator1.Visible = false;
            }
        }

        private void PhoneInnerList_Load(object sender, EventArgs e)
        {
            LoadDataList();
        }

        #endregion

        #region [Загрузка данных]

        private void LoadDataList()
        {
            string SqlStr = "";
            SqlStr = "SELECT PhoneInner.ID_PInner, PhoneInner.NamberPInner, PhoneTown.NamberPTown, PhoneMATS.NamberPMATS, PhoneGroup.NamberGroup, PhoneInner.Room"
                    + " FROM PhoneInner LEFT OUTER JOIN"
                    + " PhoneGroup ON PhoneInner.ID_PGroup = PhoneGroup.ID_PGroup LEFT OUTER JOIN"
                    + " PhoneMATS ON PhoneInner.ID_PMATS = PhoneMATS.ID_PMATS LEFT OUTER JOIN"
                    + " PhoneTown ON PhoneInner.ID_PTown = PhoneTown.ID_PTown";

            var rs = DB.GetFields(SqlStr + " ORDER BY PhoneInner.ID_PInner DESC");
            if (rs.Count == 0) return;

            DataGridViewRow DGVR;
            DGV.Rows.Clear();


            foreach (DataRow dr in rs)
            {
                DGV.Rows.Add();
                DGVR = DGV.Rows[DGV.Rows.GetLastRow(DataGridViewElementStates.Visible)];

                DGVR.Tag = dr["ID_PInner"].ToString();
                DGVR.Cells[0].Value = dr["NamberPInner"].ToString();
                DGVR.Cells[1].Value = dr["NamberPTown"].ToString();
                DGVR.Cells[2].Value = dr["NamberPMATS"].ToString();
                DGVR.Cells[3].Value = dr["NamberGroup"].ToString();
                DGVR.Cells[4].Value = dr["Room"].ToString();
            }

            //красим строки
            SSPDUI.SetBgRowInDGV(DGV);
        }

        #endregion

        #region [Управление записями]

        private void AddNewItem()
        {
            PhoneInnerCard PIC = new PhoneInnerCard(false, "");
            PIC.ShowDialog();
            if (PIC.FlSave == true && PIC.GetData != null)
            {
                DGV.Rows.Add();
                DGV.ClearSelection();
                DGV.Rows[DGV.Rows.Count - 1].Selected = true;
                DGV.Rows[DGV.Rows.Count - 1].Cells[0].Selected = true;
                DGV.Rows[DGV.Rows.Count - 1].Tag = PIC.GetData["ID_PInner"];
                DGV.Rows[DGV.Rows.Count - 1].Cells[0].Value = PIC.GetData["NamberPInner"];
                DGV.Rows[DGV.Rows.Count - 1].Cells[1].Value = PIC.GetData["NamberPTown"];
                DGV.Rows[DGV.Rows.Count - 1].Cells[2].Value = PIC.GetData["NamberPMATS"];
                DGV.Rows[DGV.Rows.Count - 1].Cells[3].Value = PIC.GetData["NamberGroup"];
                DGV.Rows[DGV.Rows.Count - 1].Cells[4].Value = PIC.GetData["Room"];
            }
        }

        private void EditItem()
        {
            if (DGV.Rows.Count == 0) return;
            PhoneInnerCard PIC = new PhoneInnerCard(true, DGV.CurrentRow.Tag.ToString());
            PIC.ShowDialog();
            if (PIC.FlSave == true && PIC.GetData != null)
            {
                DGV.CurrentRow.Cells[1].Value = PIC.GetData["NamberPTown"];
                DGV.CurrentRow.Cells[2].Value = PIC.GetData["NamberPMATS"];
                DGV.CurrentRow.Cells[3].Value = PIC.GetData["NamberGroup"];
                DGV.CurrentRow.Cells[4].Value = PIC.GetData["Room"];
            }
        }

        private void DelItem()
        {
            if (MessageBox.Show("Удалить номер - " + DGV.CurrentRow.Cells[0].Value.ToString() + "?", "Удаление записи",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            var rs = DB.GetFields("SELECT COUNT(*) AS MaxRec From WorkersExt WHERE PhoneInner = " + DGV.CurrentRow.Tag.ToString());
            if ((int)rs[0]["MaxRec"] > 0)
            {
                rs = DB.GetFields("SELECT COUNT(*) AS MaxRec From WorkersExt WHERE Room IS NULL AND PhoneInner = " + DGV.CurrentRow.Tag.ToString());
                if ((int)rs[0]["MaxRec"] > 0)
                {
                    DB.DeleteRow("WorkersExt", "Room IS NULL AND PhoneInner = " + DGV.CurrentRow.Tag.ToString());
                }
                else
                {
                    Dictionary<string, string> DataSet = new Dictionary<string, string>();
                    DataSet.Add("PhoneInner", "");
                    DB.SetFields(DataSet, "WorkersExt", "PhoneInner = " + DGV.CurrentRow.Tag.ToString());
                }
            }

            DB.DeleteRow("PhoneInner", "ID_PInner = " + DGV.CurrentRow.Tag.ToString());
            DGV.Rows.RemoveAt(DGV.CurrentRow.Index);
            SSPDUI.SetBgRowInDGV(DGV);
        }

        private void SelectItem()
        {
            SelID = DGV.CurrentRow.Tag.ToString();
            SelPhoneInner = DGV.CurrentRow.Cells[0].Value.ToString();
            SelPhoneTown = DGV.CurrentRow.Cells[1].Value.ToString();
            SelPhoneMATS = DGV.CurrentRow.Cells[2].Value.ToString();
            SelPhoneGroup = DGV.CurrentRow.Cells[3].Value.ToString();
            SelRoom = DGV.CurrentRow.Cells[4].Value.ToString();
            this.Close();
        }

        #endregion

        #region [События элементов формы]

        private void PhoneInnerList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7) SSPDUI.SearchInDGV(DGV, StrFind.Text, DGV.CurrentRow.Index);
            if (e.KeyCode == Keys.Insert) AddNewItem();
        }

        private void DGV_Sorted(object sender, EventArgs e)
        {
            //красим строки
            SSPDUI.SetBgRowInDGV(DGV);
        }

        private void DGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (DGV.Rows.Count == 0) return;
                if (ReadOnly == true)
                    SelectItem();
                else EditItem();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (ReadOnly == true)
                SelectItem();
            else EditItem();
        }

        private void StrFind_LostFocus(object sender, EventArgs e)
        {
            if (StrFind.Text == "")
            {
                StrFind.Text = Params.StrFindLabel;
                StrFind.ForeColor = Color.DarkGray;
            }
        }

        private void StrFind_GotFocus(object sender, EventArgs e)
        {
            if (StrFind.Text == Params.StrFindLabel)
            {
                StrFind.Text = "";
                StrFind.ForeColor = Color.Black;
            }
        }

        private void StrFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SSPDUI.SearchInDGV(DGV, StrFind.Text, DGV.CurrentRow.Index);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SSPDUI.SearchInDGV(DGV, StrFind.Text, DGV.CurrentRow.Index);
        }

        private void mbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDataAdd_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        private void mbtnDataAdd_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        private void btnDataEdit_Click(object sender, EventArgs e)
        {
            EditItem();
        }

        private void mbtnDataEdit_Click(object sender, EventArgs e)
        {
            EditItem();
        }

        private void btnDataDel_Click(object sender, EventArgs e)
        {
            DelItem();
        }

        private void mbtnDataDel_Click(object sender, EventArgs e)
        {
            DelItem();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectItem();
        }

        private void mbtnSelect_Click(object sender, EventArgs e)
        {
            SelectItem();
        }

        #endregion

    }
}
