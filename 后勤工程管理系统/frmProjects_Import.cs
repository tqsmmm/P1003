using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmProjects_Import : Form
    {
        public DataTable dt = new DataTable();

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

                for (int i = 0; i < dgvExcel.RowCount; i++)
                {
                    if (dgvExcel.Rows[i].Cells["工程内容"].Value.ToString().Length > 0)
                    {
                        dgvExcel.AutoResizeRow(i, DataGridViewAutoSizeRowMode.AllCells);
                    }
                }

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
            tspbImport.Maximum = dgvExcel.RowCount;
            tspbImport.Value = 1;
            tspbImport.Step = 1;

            int intPremisesTrue = 0;
            int intPremisesFalse = 0;
            int intProjectsTrue = 0;
            int intProjectsFalse = 0;
            int intPartitionsTrue = 0;
            int intPartitionsFalse = 0;

            for (int i = 0; i < dgvExcel.Rows.Count; i++)
            {
                bool bFalse = true;

                //基础数据导入

                //工程类型
                if (!string.IsNullOrEmpty(dgvExcel.Rows[i].Cells["工程类型"].Value.ToString()))
                {
                    if (Class.DB_Works.DataSetCmd($"SELECT id FROM Types WHERE Name = '{dgvExcel.Rows[i].Cells["工程类型"].Value}'").Tables[0].Rows.Count == 0)
                    {
                        Class.DB_Works.ExecuteCmd($"INSERT INTO Types(Name) VALUES('{dgvExcel.Rows[i].Cells["工程类型"].Value}')");
                    }
                }

                //中标单位
                if (!string.IsNullOrEmpty(dgvExcel.Rows[i].Cells["中标单位"].Value.ToString()))
                {
                    if (Class.DB_Works.DataSetCmd($"SELECT id FROM Tenders WHERE Name = '{dgvExcel.Rows[i].Cells["中标单位"].Value}'").Tables[0].Rows.Count == 0)
                    {
                        Class.DB_Works.ExecuteCmd($"INSERT INTO Tenders(Name, Manager, Contact) VALUES('{dgvExcel.Rows[i].Cells["中标单位"].Value}', '', '')");
                    }
                }

                //施工单位
                if (!string.IsNullOrEmpty(dgvExcel.Rows[i].Cells["施工单位"].Value.ToString()))
                {
                    if (Class.DB_Works.DataSetCmd($"SELECT id FROM Constructors WHERE Name = '{dgvExcel.Rows[i].Cells["施工单位"].Value}'").Tables[0].Rows.Count == 0)
                    {
                        Class.DB_Works.ExecuteCmd($"INSERT INTO Constructors(Name, Manager, Contact) VALUES('{dgvExcel.Rows[i].Cells["施工单位"].Value}', '{dgvExcel.Rows[i].Cells["负责人"].Value}', '{dgvExcel.Rows[i].Cells["联系方式"].Value}')");
                    }
                }

                if (string.IsNullOrEmpty(dgvExcel.Rows[i].Cells["房产名称"].Value.ToString()))
                {
                    intPremisesFalse++;
                    intProjectsFalse++;
                    intPartitionsFalse++;
                }
                else
                {
                    DataSet ds;

                    //房产数据
                    if (!string.IsNullOrEmpty(dgvExcel.Rows[i].Cells["房产编号"].Value.ToString()))
                    {
                        ds = Class.DB_Works.DataSetCmd($"SELECT Code FROM Premises WHERE Code = '{dgvExcel.Rows[i].Cells["房产编号"].Value}'");
                    }
                    else
                    {
                        ds = Class.DB_Works.DataSetCmd($"SELECT Name FROM Premises WHERE Name = '{dgvExcel.Rows[i].Cells["房产名称"].Value}'");
                    }

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        if (!Class.DB_Works.ExecuteCmd(
                        $"INSERT INTO Premises(Name, Code, Address, Date, Levels, Structure, Dimension, Purpose, Assets_Amount, Assets_Code, Device_Code, Region, Users_id, DateTime) " +
                        $"VALUES('{dgvExcel.Rows[i].Cells["房产名称"].Value}', " +
                        $"'{dgvExcel.Rows[i].Cells["房产编号"].Value}', " +
                        $"'', " +
                        $"'{dgvExcel.Rows[i].Cells[2].Value}', " +
                        $"'{dgvExcel.Rows[i].Cells[3].Value}', " +
                        $"'{dgvExcel.Rows[i].Cells[4].Value}', " +
                        $"{dgvExcel.Rows[i].Cells[5].Value}, " +
                        $"'{dgvExcel.Rows[i].Cells[6].Value}', " +
                        $"{dgvExcel.Rows[i].Cells[7].Value}, " +
                        $"'{dgvExcel.Rows[i].Cells[8].Value}', " +
                        $"'{dgvExcel.Rows[i].Cells[9].Value}', " +
                        $"'{dgvExcel.Rows[i].Cells[10].Value}', " +
                        $"{AppSetter.Current_User.id}, NOW())"))
                        {
                            bFalse = false;
                            intPremisesFalse++;
                        }
                        else
                        {
                            intPremisesTrue++;
                        }
                    }
                    else
                    {
                        intPremisesFalse++;
                    }

                    if (bFalse)
                    {
                        //工程数据
                        if (!string.IsNullOrEmpty(dgvExcel.Rows[i].Cells["工程编号"].Value.ToString()))
                        {
                            ds = Class.DB_Works.DataSetCmd($"SELECT OrderID FROM Projects WHERE OrderID = '{dgvExcel.Rows[i].Cells["工程编号"].Value}'");
                        }
                        else
                        {
                            ds = Class.DB_Works.DataSetCmd($"SELECT Name FROM Projects WHERE Name = '{dgvExcel.Rows[i].Cells["工程名称"].Value}'");
                        }

                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            if (!Class.DB_Works.ExecuteCmd(
                                $"INSERT INTO Projects(Premises_id, OrderID, Name, Types_id, Detail, Amount, Developing_Reply, Initial_Reply, Plan_Code, Begin_Date, End_Date, Tenders_id, " +
                                $"Progress, Collect_Tag, Check_Tag, Grade_Tag, Remark, Amount_Order, Amount_Reality, Amount_Pay, Amount_Arrear, Warranty, Users_id, DateTime) " +
                                $"VALUES((SELECT id FROM Premises WHERE Name = '{dgvExcel.Rows[i].Cells["房产名称"].Value}'), " +
                                $"'{dgvExcel.Rows[i].Cells["工程编号"].Value}', " +
                                $"'{dgvExcel.Rows[i].Cells["工程名称"].Value}', " +
                                $"(CASE WHEN '{dgvExcel.Rows[i].Cells["工程类型"].Value}' = '' THEN 0 ELSE (SELECT id FROM Types WHERE Name = '{dgvExcel.Rows[i].Cells["工程类型"].Value}') END), " +
                                $"'{dgvExcel.Rows[i].Cells["工程内容"].Value}', " +
                                $"{dgvExcel.Rows[i].Cells["计划金额"].Value}, " +
                                $"'{dgvExcel.Rows[i].Cells["可研批复"].Value}', " +
                                $"'{dgvExcel.Rows[i].Cells["初始批复"].Value}', " +
                                $"'{dgvExcel.Rows[i].Cells["计划文号"].Value}', " +
                                $"'{dgvExcel.Rows[i].Cells["开工时间"].Value}', " +
                                $"'{dgvExcel.Rows[i].Cells["竣工时间"].Value}', " +
                                $"(CASE WHEN '{dgvExcel.Rows[i].Cells["中标单位"].Value}' = '' THEN 0 ELSE (SELECT id FROM Tenders WHERE Name = '{dgvExcel.Rows[i].Cells["中标单位"].Value}') END), " +
                                $"'{dgvExcel.Rows[i].Cells["形象进度"].Value}', " +
                                $"'{dgvExcel.Rows[i].Cells["收集整理"].Value}', " +
                                $"'{dgvExcel.Rows[i].Cells["立卷检查"].Value}', " +
                                $"'{dgvExcel.Rows[i].Cells["验收合格"].Value}', " +
                                $"''," +
                                $"{dgvExcel.Rows[i].Cells["合同金额"].Value}, " +
                                $"{dgvExcel.Rows[i].Cells["实际发生额"].Value}, " +
                                $"{dgvExcel.Rows[i].Cells["合同支付金额"].Value}, " +
                                $"{dgvExcel.Rows[i].Cells["合同欠款金额"].Value}, " +
                                $"'{dgvExcel.Rows[i].Cells["质保金支付时间"].Value}', " +
                                $"{AppSetter.Current_User.id}, NOW())"))
                            {
                                bFalse = false;
                                intProjectsFalse++;
                            }
                            else
                            {
                                intProjectsTrue++;
                            }
                        }
                        else
                        {
                            intProjectsFalse++;
                        }

                        if (bFalse)
                        {
                            //分包数据
                            ds = Class.DB_Works.DataSetCmd($"SELECT Partitions.id FROM Partitions LEFT JOIN Projects ON Projects.id = Partitions.Projects_id WHERE Projects.Name = '{dgvExcel.Rows[i].Cells["工程名称"].Value}'");

                            if (ds.Tables[0].Rows.Count == 0)
                            {
                                if (!Class.DB_Works.ExecuteCmd(
                                $"INSERT INTO Partitions(Projects_id, Constructors_id, Amount, Amount_Arrear, Amount_Pay, Management, Account, Users_id, DateTime) " +
                                $"VALUES(CASE WHEN '{dgvExcel.Rows[i].Cells["工程编号"].Value}' = '' THEN (SELECT id FROM Projects WHERE Name = '{dgvExcel.Rows[i].Cells["工程名称"].Value}') ELSE (SELECT id FROM Projects WHERE OrderID = '{dgvExcel.Rows[i].Cells["工程编号"].Value}') END, " +
                                $"CASE WHEN '{dgvExcel.Rows[i].Cells["施工单位"].Value}' = '' THEN 0 ELSE (SELECT id FROM Constructors WHERE Name = '{dgvExcel.Rows[i].Cells["施工单位"].Value}') END, " +
                                $"{dgvExcel.Rows[i].Cells["分包金额"].Value}, " +
                                $"{dgvExcel.Rows[i].Cells["分包欠款金额"].Value}, " +
                                $"{dgvExcel.Rows[i].Cells["分包支付金额"].Value}, " +
                                $"{dgvExcel.Rows[i].Cells["管理费"].Value}, " +
                                $"'{dgvExcel.Rows[i].Cells["是否挂账"].Value}', " +
                                $"{AppSetter.Current_User.id}, NOW())"))
                                {
                                    intPartitionsFalse++;
                                }
                                else
                                {
                                    intPartitionsTrue++;
                                }
                            }
                            else
                            {
                                intPartitionsFalse++;
                            }
                        }
                    }
                }

                tspbImport.PerformStep();
            }

            Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '导入', '【导入信息】导入成功房产数据【{intPremisesTrue}】条，导入失败房产数据【{intPremisesFalse}】条，导入成功工程数据【{intProjectsTrue}】条，导入失败工程数据【{intProjectsFalse}】条，导入成功分包数据【{intPartitionsTrue}】条，导入失败分包数据【{intPartitionsFalse}】条。', NOW())");

            Class.Public.Sys_MsgBox($"导入成功房产数据【{intPremisesTrue}】条，导入失败房产数据【{intPremisesFalse}】条。\r导入成功工程数据【{intProjectsTrue}】条，导入失败工程数据【{intProjectsFalse}】条。\r导入成功分包数据【{intPartitionsTrue}】条，导入失败分包数据【{intPartitionsFalse}】条。");

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
                else
                {
                    dgvExcel.Rows[i].Cells[0].Style.BackColor = Color.White;
                }

                //房产编号
                if (dgvExcel.Rows[i].Cells[1].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[1].Style.BackColor = Color.White;
                }

                //建筑年代
                

                //建筑层数
                if (dgvExcel.Rows[i].Cells[3].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[3].Style.BackColor = Color.White;
                }

                //建筑结构
                if (dgvExcel.Rows[i].Cells[4].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[4].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[4].Style.BackColor = Color.White;
                }

                //建筑面积
                if (!Class.Public.IsNumber(dgvExcel.Rows[i].Cells[5].Value.ToString()))
                {
                    dgvExcel.Rows[i].Cells[5].Value = 0;
                }

                //建筑用途
                if (dgvExcel.Rows[i].Cells[6].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[6].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[6].Style.BackColor = Color.White;
                }

                //资产原值
                if (!Class.Public.IsNumber(dgvExcel.Rows[i].Cells[7].Value.ToString()))
                {
                    dgvExcel.Rows[i].Cells[7].Value = 0;
                }

                //资产编码
                if (dgvExcel.Rows[i].Cells[8].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[8].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[8].Style.BackColor = Color.White;
                }

                //设备编码
                if (dgvExcel.Rows[i].Cells[9].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[9].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[9].Style.BackColor = Color.White;
                }

                //地区
                if (dgvExcel.Rows[i].Cells[10].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[10].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[10].Style.BackColor = Color.White;
                }

                //工程编号
                if (dgvExcel.Rows[i].Cells[11].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[11].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[11].Style.BackColor = Color.White;
                }

                //工程名称
                if (dgvExcel.Rows[i].Cells[12].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[12].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[12].Style.BackColor = Color.White;
                }

                //工程类型
                if (dgvExcel.Rows[i].Cells[13].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[13].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[13].Style.BackColor = Color.White;
                }

                //工程内容

                //工程年份
                if (dgvExcel.Rows[i].Cells[15].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[15].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[15].Style.BackColor = Color.White;
                }

                //计划金额
                if (!Class.Public.IsNumber(dgvExcel.Rows[i].Cells[16].Value.ToString()))
                {
                    dgvExcel.Rows[i].Cells[16].Value = 0;
                }

                //可研批复
                if (dgvExcel.Rows[i].Cells[17].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[17].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[17].Style.BackColor = Color.White;
                }

                //初始批复
                if (dgvExcel.Rows[i].Cells[18].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[18].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[18].Style.BackColor = Color.White;
                }

                //计划文号
                if (dgvExcel.Rows[i].Cells[19].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[19].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[19].Style.BackColor = Color.White;
                }

                //开工时间
                try
                {
                    if (!string.IsNullOrEmpty(dgvExcel.Rows[i].Cells[20].Value.ToString()))
                    {
                        Convert.ToDateTime(dgvExcel.Rows[i].Cells[20].Value);
                        
                    }
                    else
                    {
                        dgvExcel.Rows[i].Cells[20].Value = "0001-01-01";
                    }

                    dgvExcel.Rows[i].Cells[20].Style.BackColor = Color.White;
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[20].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //竣工时间
                try
                {
                    if (!string.IsNullOrEmpty(dgvExcel.Rows[i].Cells[21].Value.ToString()))
                    {
                        Convert.ToDateTime(dgvExcel.Rows[i].Cells[21].Value);
                    }
                    else
                    {
                        dgvExcel.Rows[i].Cells[21].Value = "0000-01-01";
                    }

                    dgvExcel.Rows[i].Cells[21].Style.BackColor = Color.White;
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[21].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //中标单位
                if (dgvExcel.Rows[i].Cells[22].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[22].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[22].Style.BackColor = Color.White;
                }

                //形象进度
                if (!Class.Public.IsNumber(dgvExcel.Rows[i].Cells[23].Value.ToString()))
                {
                    dgvExcel.Rows[i].Cells[23].Value = 0;
                }

                //合同金额
                if (!Class.Public.IsNumber(dgvExcel.Rows[i].Cells[24].Value.ToString()))
                {
                    dgvExcel.Rows[i].Cells[24].Value = 0;
                }

                //实际发生额
                if (!Class.Public.IsNumber(dgvExcel.Rows[i].Cells[25].Value.ToString()))
                {
                    dgvExcel.Rows[i].Cells[25].Value = 0;
                }

                //合同支付金额
                if (!Class.Public.IsNumber(dgvExcel.Rows[i].Cells[26].Value.ToString()))
                {
                    dgvExcel.Rows[i].Cells[26].Value = 0;
                }

                //合同欠款金额
                if (!Class.Public.IsNumber(dgvExcel.Rows[i].Cells[27].Value.ToString()))
                {
                    dgvExcel.Rows[i].Cells[27].Value = 0;
                }

                //质保金支付时间
                if (!string.IsNullOrEmpty(dgvExcel.Rows[i].Cells[28].Value.ToString()))
                {
                    Convert.ToDateTime(dgvExcel.Rows[i].Cells[28].Value);
                }
                else
                {
                    dgvExcel.Rows[i].Cells[28].Value = "0000-01-01";
                }

                //施工单位
                if (dgvExcel.Rows[i].Cells[29].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[29].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[29].Style.BackColor = Color.White;
                }

                //负责人
                if (dgvExcel.Rows[i].Cells[30].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[30].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[30].Style.BackColor = Color.White;
                }

                //联系方式
                if (dgvExcel.Rows[i].Cells[31].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[31].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[31].Style.BackColor = Color.White;
                }

                //分包金额
                if (!Class.Public.IsNumber(dgvExcel.Rows[i].Cells[32].Value.ToString()))
                {
                    dgvExcel.Rows[i].Cells[32].Value = 0;
                }

                //分包支付金额
                if (!Class.Public.IsNumber(dgvExcel.Rows[i].Cells[33].Value.ToString()))
                {
                    dgvExcel.Rows[i].Cells[33].Value = 0;
                }

                //分包欠款金额
                if (!Class.Public.IsNumber(dgvExcel.Rows[i].Cells[34].Value.ToString()))
                {
                    dgvExcel.Rows[i].Cells[34].Value = 0;
                }

                //管理费
                if (!Class.Public.IsNumber(dgvExcel.Rows[i].Cells[35].Value.ToString()))
                {
                    dgvExcel.Rows[i].Cells[35].Value = 0;
                }

                //是否挂账
                if (dgvExcel.Rows[i].Cells[36].Value.ToString().Length > 5)
                {
                    dgvExcel.Rows[i].Cells[36].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[36].Style.BackColor = Color.White;
                }

                //收集整理
                if (dgvExcel.Rows[i].Cells[37].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[37].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[37].Style.BackColor = Color.White;
                }

                //立卷检查
                if (dgvExcel.Rows[i].Cells[38].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[38].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[38].Style.BackColor = Color.White;
                }

                //验收合格
                if (dgvExcel.Rows[i].Cells[39].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[39].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    dgvExcel.Rows[i].Cells[39].Style.BackColor = Color.White;
                }
            }
        }
    }
}
