using System;
using System.Data;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();

            cmbTenders.DataSource = Class.DB_Works.DataSetCmd("SELECT id, Name FROM Tenders").Tables[0];
            cmbTenders.DisplayMember = "Name";
            cmbTenders.ValueMember = "id";

            cmbConstructors.DataSource = Class.DB_Works.DataSetCmd("SELECT id, Name FROM Constructors").Tables[0];
            cmbConstructors.DisplayMember = "Name";
            cmbConstructors.ValueMember = "id";

            cmbPartitions_Account.SelectedIndex = 0;
            cmbCollect_Tag.SelectedIndex = 0;
            cmbCheck_Tag.SelectedIndex = 0;
            cmbGrade_Tag.SelectedIndex = 0;

            DataSet Ds = Class.DB_Works.DataSetCmd("SELECT Name FROM Premises");

            AutoCompleteStringCollection filtervals = new AutoCompleteStringCollection();

            foreach (DataRow dr in Ds.Tables[0].Rows)
            {
                filtervals.Add(dr["Name"].ToString());
            }

            txtPremises_Name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtPremises_Name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtPremises_Name.AutoCompleteCustomSource = filtervals;
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            DataSet Ds = Class.DB_Works.DataSetCmd("SELECT Name FROM Types");

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                clbProjects_Types.Items.Add(Ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (Control item in tableLayoutPanel1.Controls)
            {
                if (item is CheckBox)
                {
                    var comm = item as CheckBox;
                    comm.Checked = true;
                }
            }
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            foreach (Control item in tableLayoutPanel1.Controls)
            {
                if (item is CheckBox)
                {
                    var comm = item as CheckBox;
                    comm.Checked = false;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmDesktop frm = new frmDesktop
            {
                TopLevel = false
            };

            string strSQL = "SELECT Premises.Name AS 房产名称, Code AS 房产编号, Date AS 建筑年代, Levels AS 建筑层数, Structure AS 建筑结构, Purpose AS 建筑用途, Assets_Amount AS 资产原值, Assets_Code AS 资产编码, Device_Code AS 设备编码, Region AS 地区, Projects.Name AS 工程名称, Types.Name AS 工程类型, Projects.Detail AS 工程内容, Projects.Amount AS 计划金额, Projects.Developing_Reply AS 可研批复, Projects.Initial_Reply AS 初始批复, Projects.Plan_Code AS 计划文号, Projects.Begin_Date AS 开工时间, Projects.End_Date AS 竣工时间, Tenders.Name AS 中标单位, Projects.Progress AS 形象进度, Projects.Amount_Order AS 合同金额, Projects.Amount_Reality AS 实际发生额, Projects.Amount_Pay AS 支付金额, Projects.Amount_Arrear AS 欠款金额, Projects.Warranty AS 质保金支付时间, Constructors.Name AS 施工单位, Constructors.Manager AS 负责人, Constructors.Contact AS 联系方式, Partitions.Amount AS 分包金额, Partitions.Amount_Pay AS 支付金额1, Partitions.Amount_Arrear AS 欠款金额1, Partitions.Management AS 管理费, Partitions.Account AS 是否挂账, Projects.Collect_Tag AS 收集整理, Projects.Check_Tag AS 立卷检查, Projects.Grade_Tag AS 验收合格 FROM Premises LEFT JOIN Projects ON Projects.Premises_id = Premises.id LEFT JOIN Types ON Types.id = Projects.Types_id LEFT JOIN Tenders ON Tenders.id = Projects.Tenders_id LEFT JOIN Partitions ON Partitions.Projects_id = Projects.id LEFT JOIN Constructors ON Partitions.Constructors_id = Constructors.id";

            if (ckbPremises_Name.Checked)
            {
                frm.txtName.Text = txtPremises_Name.Text;
            }

            if (ckbProjects_Types.Checked)
            {
                
            }

            if (ckbPremises_Date.Checked)
            {

            }

            if (ckbTenders.Checked)
            {
                frm.cmbTenders.Text = cmbTenders.Text;
            }

            if (ckbConstructors.Checked)
            {
                frm.cmbConstructors.Text = cmbConstructors.Text;
            }

            if (ckbContact.Checked)
            {
                frm.txtManager.Text = txtContact.Text;
            }

            if (ckbProjects_Amount.Checked)
            {
                
            }

            if (ckbProjects_Amount_Reality.Checked)
            {

            }

            if (ckbProjects_Amount_Pay.Checked)
            {

            }

            if (ckbProjects_Amount_Arrear.Checked)
            {

            }

            if (ckbPartitions_Amount.Checked)
            {

            }

            if (ckbPartitions_Amount_Pay.Checked)
            {

            }

            if (ckbPartitions_Amount_Arrear.Checked)
            {

            }

            if (ckbPartitions_Management.Checked)
            {

            }

            if (ckbPartitions_Account.Checked)
            {

            }

            if (ckbProjects_Collect_Tag.Checked)
            {

            }

            if (ckbProjects_Check_Tag.Checked)
            {

            }

            if (ckbProjects_Grade_Tag.Checked)
            {

            }
        }
    }
}
