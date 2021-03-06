﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SSPD;

namespace Контроль_запросов_ТКП
{
    public partial class Contacts : Form
    {

        public string ID_Org;
        public bool flSave = false;

        private bool iNew = true;

        public Contacts()
        {
            InitializeComponent();
        }

        private void Contacts_Load(object sender, EventArgs e)
        {
            LoadData();
            Contact.SelectionStart = 0;
            Contact.SelectionLength = 0;

            //проверка привелегий
            if (Params.UserInfo.ID_Otdel != TKP_Conf.AdminIDOtdel)
            {
                btnSave.Enabled = false;
                Contact.ReadOnly = true; 
            }
        }

        private void LoadData()
        {
            var rs = LocalDB.LoadData("SELECT ID, Contacts FROM КонтрольТКП_Контакты WHERE ID_Org = " + ID_Org);
            if (rs != null)
                if (rs.Count > 0)
                {
                    Contact.Text = rs[0]["Contacts"].ToString();
                    iNew = false;
                }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> DS = new Dictionary<string, object>();
            DS.Add("Contacts", Contact.Text);
            if (iNew)
            {
                DS.Add("ID_Org", ID_Org);
                LocalDB.InsertData(DS, "КонтрольТКП_Контакты");
            }
            else
                LocalDB.UpdateData(DS, "КонтрольТКП_Контакты", "ID_Org = " + ID_Org);
            flSave = true;
            this.Close();
        }

        private void Contacts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

    }
}
