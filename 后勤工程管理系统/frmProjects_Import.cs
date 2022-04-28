using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmProjects_Import : Form
    {
        public DataTable dt = null;

        public frmProjects_Import()
        {
            InitializeComponent();

            dgvExcel = Class.Public.SetDataGridViewStyle(dgvExcel);
        }

        private void frmProjects_Import_Load(object sender, EventArgs e)
        {
            if (dt != null)
            {
                dgvExcel.DataSource = dt;

                btnCheck_Click(this, e);
            }
            else
            {
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvExcel.Rows.Count; i++)
            {
                int Types_id = Convert.ToInt16(Class.DB_Works.DataSetCmd($"SELECT id FROM Types WHERE Name = '{dgvExcel.Rows[i].Cells[1].Value}'").Tables[0].Rows[0][0]);

                int Tenders_id = Convert.ToInt16(Class.DB_Works.DataSetCmd($"SELECT id FROM Tenders WHERE Name = '{dgvExcel.Rows[i].Cells[9].Value}'").Tables[0].Rows[0][0]);
                Class.DB_Works.ExecuteCmd($"INSERT INTO Projects(Name, Types_id, Detail, Amount, Developing_Reply, Initial_Reply, Plan_Code, Begin_Date, End_Date, Tenders_id, Progress, Collect_Tag, Check_Tag, Grade_Tag, Amount_Order, Amount_Reality, Warranty, Users_id, DateTime) VALUES('{dgvExcel.Rows[i].Cells[0].Value}', {Types_id}, '{dgvExcel.Rows[i].Cells[2].Value}', {dgvExcel.Rows[i].Cells[3].Value}, '{dgvExcel.Rows[i].Cells[4].Value}', '{dgvExcel.Rows[i].Cells[5].Value}', '{dgvExcel.Rows[i].Cells[6].Value}', '{dgvExcel.Rows[i].Cells[7].Value}', '{dgvExcel.Rows[i].Cells[8].Value}', {Tenders_id}, '{dgvExcel.Rows[i].Cells[10].Value}', '{dgvExcel.Rows[i].Cells[11].Value}', '{dgvExcel.Rows[i].Cells[12].Value}', '{dgvExcel.Rows[i].Cells[13].Value}', 0, 0, '1900-01-01', {AppSetter.Current_User.id}, NOW())");
            }

            Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '导入', '【导入工程信息】导入工程数据【{dgvExcel.Rows.Count - 1}】条', NOW())");

            Class.Public.Sys_MsgBox("工程项目导入成功！");

            DialogResult = DialogResult.Yes;
            Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnImport.Enabled = true;

            for (int i = 0; i < dgvExcel.Rows.Count; i++)
            {
                dgvExcel.Rows[i].DefaultCellStyle.BackColor = Color.White;

                //房产名称
                if (dgvExcel.Rows[i].Cells[0].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[0].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //房产编号
                if (dgvExcel.Rows[i].Cells[1].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //建筑年代
                try
                {
                    Convert.ToInt16(dgvExcel.Rows[i].Cells[2].Value);
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //建筑层数
                if (dgvExcel.Rows[i].Cells[3].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //建筑结构
                if (dgvExcel.Rows[i].Cells[4].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[4].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //建筑用途
                if (dgvExcel.Rows[i].Cells[5].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[5].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //资产原值
                try
                {
                    Convert.ToDecimal(dgvExcel.Rows[i].Cells[6].Value);
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[6].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //资产编码
                if (dgvExcel.Rows[i].Cells[7].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[7].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //设备编码
                if (dgvExcel.Rows[i].Cells[8].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[8].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //地区
                if (dgvExcel.Rows[i].Cells[9].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[9].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //工程编号
                if (dgvExcel.Rows[i].Cells[10].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[10].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //工程名称
                if (dgvExcel.Rows[i].Cells[11].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[11].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //工程类型
                if (Class.DB_Works.DataSetCmd($"SELECT id FROM Types WHERE Name = '{dgvExcel.Rows[i].Cells[1].Value}'").Tables[0].Rows.Count == 0)
                {
                    dgvExcel.Rows[i].Cells[12].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //工程内容

                //工程年份
                if (dgvExcel.Rows[i].Cells[14].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[14].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //计划金额
                try
                {
                    Convert.ToDecimal(dgvExcel.Rows[i].Cells[15].Value);
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[15].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //可研批复
                if (dgvExcel.Rows[i].Cells[16].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[16].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //初始批复
                if (dgvExcel.Rows[i].Cells[17].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[17].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //计划文号
                if (dgvExcel.Rows[i].Cells[18].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[18].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //开工时间
                try
                {
                    Convert.ToDateTime(dgvExcel.Rows[i].Cells[19].Value);
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[19].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //竣工时间
                try
                {
                    Convert.ToDateTime(dgvExcel.Rows[i].Cells[20].Value);
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[20].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //中标单位
                if (Class.DB_Works.DataSetCmd($"SELECT id FROM Tenders WHERE Name ='{dgvExcel.Rows[i].Cells[21].Value}'").Tables[0].Rows.Count == 0)
                {
                    dgvExcel.Rows[i].Cells[21].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //形象进度
                if (dgvExcel.Rows[i].Cells[22].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[22].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //合同金额
                try
                {
                    Convert.ToDecimal(dgvExcel.Rows[i].Cells[23].Value);
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[23].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //实际发生额
                try
                {
                    Convert.ToDecimal(dgvExcel.Rows[i].Cells[24].Value);
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[24].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //支付金额
                try
                {
                    Convert.ToDecimal(dgvExcel.Rows[i].Cells[25].Value);
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[25].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //欠款金额
                try
                {
                    Convert.ToDecimal(dgvExcel.Rows[i].Cells[26].Value);
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[26].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //质保金支付时间
                try
                {
                    Convert.ToDateTime(dgvExcel.Rows[i].Cells[27].Value);
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[27].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //施工单位
                if (dgvExcel.Rows[i].Cells[28].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[28].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //负责人
                if (dgvExcel.Rows[i].Cells[29].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[29].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //联系方式
                if (dgvExcel.Rows[i].Cells[30].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[30].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //分包金额
                try
                {
                    Convert.ToDecimal(dgvExcel.Rows[i].Cells[31].Value);
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[31].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //支付金额1
                try
                {
                    Convert.ToDecimal(dgvExcel.Rows[i].Cells[32].Value);
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[32].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //欠款金额1
                try
                {
                    Convert.ToDecimal(dgvExcel.Rows[i].Cells[33].Value);
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[33].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //管理费
                try
                {
                    Convert.ToDecimal(dgvExcel.Rows[i].Cells[34].Value);
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[34].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //是否挂账
                if (dgvExcel.Rows[i].Cells[35].Value.ToString().Length > 5)
                {
                    dgvExcel.Rows[i].Cells[35].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //收集整理
                if (dgvExcel.Rows[i].Cells[36].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[36].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //立卷检查
                if (dgvExcel.Rows[i].Cells[37].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[37].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //验收合格
                if (dgvExcel.Rows[i].Cells[38].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[38].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                if (Class.DB_Works.DataSetCmd($"SELECT Projects.id FROM Projects LEFT JOIN Types ON Types.id = Projects.Types_id WHERE Projects.Name = '{dgvExcel.Rows[i].Cells[0].Value}' AND Types.Name = '{dgvExcel.Rows[i].Cells[1].Value}' AND Projects.id IN (SELECT Types_id FROM Limits WHERE Users_id = {AppSetter.Current_User.id})").Tables[0].Rows.Count > 0)
                {
                    dgvExcel.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
            }
        }
    }
}
