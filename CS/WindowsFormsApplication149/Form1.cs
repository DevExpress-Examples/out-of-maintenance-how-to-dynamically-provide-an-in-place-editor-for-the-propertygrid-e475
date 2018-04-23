using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;

namespace WindowsFormsApplication149
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Record r = new Record() { Phone = "123-45-67", Name = "Name" };
            this.propertyGridControl1.SelectedObject = r;
            propertyGridControl1.RetrieveFields();
            RepositoryItemTextEdit ri = new RepositoryItemTextEdit();
            ri.Mask.MaskType  =  DevExpress.XtraEditors.Mask.MaskType.RegEx;
            ri.Mask.EditMask = @"(\(\d\d\d\))?\d{1,3}-\d\d-\d\d";
            ri.Mask.UseMaskAsDisplayFormat = true;
            propertyGridControl1.RepositoryItems.Add(ri);
            propertyGridControl1.GetRowByFieldName("Phone").Properties.RowEdit = ri;
        }
    }

    public class Record {
        string _name;
        string _phone;
        public string Name { get { return _name; } set { _name = value; } }
        public string Phone { get { return _phone; } set { _phone = value; } }
    }
}
