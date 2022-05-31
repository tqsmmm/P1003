using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System;
using System.Windows.Forms;
using System.Text;
using BorderStyle = NPOI.SS.UserModel.BorderStyle;
using HorizontalAlignment = NPOI.SS.UserModel.HorizontalAlignment;
using NPOI.SS.Util;

namespace 后勤工程管理系统.Class
{
    internal class Excel
    {
        public static DataTable ExcelToTable(string file)
        {
            DataTable dt = new DataTable();

            IWorkbook workbook;
            string fileExt = Path.GetExtension(file).ToLower();

            try
            {
                using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    switch (fileExt)
                    {
                        case ".xlsx":
                            workbook = new XSSFWorkbook(fs); break;
                        case ".xls":
                            workbook = new HSSFWorkbook(fs); break;
                        default:
                            workbook = null; break;
                    }

                    if (workbook == null)
                    {
                        return null;
                    }

                    ISheet sheet = workbook.GetSheetAt(0);

                    //表头  
                    IRow header = sheet.GetRow(sheet.FirstRowNum);
                    List<int> columns = new List<int>();

                    for (int i = 0; i < header.LastCellNum; i++)
                    {
                        object obj = GetValueType(header.GetCell(i));

                        if (obj == null || string.IsNullOrEmpty(obj.ToString()))
                        {
                            dt.Columns.Add(new DataColumn("Columns" + i.ToString()));
                        }
                        else
                        {
                            dt.Columns.Add(new DataColumn(obj.ToString()));
                        }

                        columns.Add(i);
                    }

                    //数据
                    for (int i = sheet.FirstRowNum + 1; i <= sheet.LastRowNum; i++)
                    {
                        DataRow dr = dt.NewRow();
                        bool hasValue = false;

                        foreach (int j in columns)
                        {
                            if (columns.Count == 40)
                            {
                                //日期判断
                                if (j == 20 || j == 21 || j == 28)
                                {
                                    try
                                    {
                                        if (sheet.GetRow(i).GetCell(j) != null)
                                        {
                                            dr[j] = sheet.GetRow(i).GetCell(j).DateCellValue.ToString("yyyy-MM-dd");
                                        }
                                        else
                                        {
                                            dr[j] = "0001-01-01";
                                        } 
                                    }
                                    catch
                                    {
                                        dr[j] = "0001-01-01";
                                    }
                                }
                                //货币判断
                                else if (j == 5 || j == 7 || j == 16 || j == 24 || j == 25 || j == 26 || j == 27 || j == 32 || j == 33 || j == 34 || j == 35)
                                {
                                    try
                                    {
                                        if (sheet.GetRow(i).GetCell(j) != null)
                                        {
                                            dr[j] = sheet.GetRow(i).GetCell(j).NumericCellValue;
                                        }
                                        else
                                        {
                                            dr[j] = 0;
                                        }
                                    }
                                    catch
                                    {
                                        dr[j] = 0;
                                    }
                                }
                                else
                                {
                                    dr[j] = GetValueType(sheet.GetRow(i).GetCell(j));
                                }
                            }
                            else if (columns.Count == 11)
                            {
                                dr[j] = GetValueType(sheet.GetRow(i).GetCell(j));
                            }

                            if (dr[j] != null && !string.IsNullOrEmpty(dr[j].ToString()))
                            {
                                if (dr[j].ToString().Substring(0, 1) == "=")
                                {
                                    switch (sheet.GetRow(i).GetCell(j).CachedFormulaResultType)
                                    {
                                        case CellType.String:
                                            dr[j] = sheet.GetRow(i).GetCell(j).StringCellValue;
                                            break;
                                        case CellType.Numeric:
                                            dr[j] = sheet.GetRow(i).GetCell(j).NumericCellValue;
                                            break;
                                        case CellType.Formula:
                                            dr[j] = sheet.GetRow(i).GetCell(j).RichStringCellValue;
                                            break;
                                    }
                                }

                                hasValue = true;
                            }
                        }

                        if (hasValue)
                        {
                            dt.Rows.Add(dr);
                        }
                    }
                }

                return dt;
            }
            catch (Exception Ex)
            {
                Public.Sys_MsgBox(Ex.Message);

                return null;
            }
        }

        private static ICellStyle DateStyle(IWorkbook workbook)
        {
            var cellStyle = workbook.CreateCellStyle();//样式

            var font = workbook.CreateFont();
            font.IsBold = false; // 粗体
            font.FontName = "宋体";

            font.FontHeightInPoints = 11;

            cellStyle.Alignment = HorizontalAlignment.Center; // 水平居中
            cellStyle.VerticalAlignment = VerticalAlignment.Center; // 垂直居中

            cellStyle.SetFont(font);

            cellStyle.BorderTop = BorderStyle.Thin;
            cellStyle.BorderBottom = BorderStyle.Thin;
            cellStyle.BorderLeft = BorderStyle.Thin;
            cellStyle.BorderRight = BorderStyle.Thin;
            cellStyle.WrapText = true;//内容自动换行，避免存在换行符的内容合并成单行

            //设置数据显示格式
            IDataFormat dataFormatCustom = workbook.CreateDataFormat();
            cellStyle.DataFormat = dataFormatCustom.GetFormat("yyyy-MM-dd");

            return cellStyle;
        }


        /// <summary>
        /// 获取单元格类型
        /// </summary>
        /// <param name="cell">目标单元格</param>
        /// <returns></returns>
        private static object GetValueType(ICell cell)
        {
            if (cell == null)
            {
                return null;
            }

            switch (cell.CellType)
            {
                case CellType.Blank:
                    return null;
                case CellType.Boolean:
                    return cell.BooleanCellValue;
                case CellType.Numeric:
                    return cell.NumericCellValue;
                case CellType.String:
                    return cell.StringCellValue;
                case CellType.Error:
                    return cell.ErrorCellValue;
                case CellType.Formula:
                default:
                    return "=" + cell.CellFormula;
            }
        }

        /// <summary>
        /// Datable导出成Excel(xlsx)
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="file">导出路径(包括文件名与扩展名)</param>
        public static bool TableToExcel(DataTable dt, string file)
        {
            IWorkbook workbook = new HSSFWorkbook();

            string fileExt = Path.GetExtension(file).ToLower();

            if (workbook == null)
            {
                return false;
            }

            ISheet sheet = string.IsNullOrEmpty(dt.TableName) ? workbook.CreateSheet("sheet0") : workbook.CreateSheet(dt.TableName);

            sheet.AddValidationData(SetColumnsComplete());
            sheet.AddValidationData(SetColumnsTypes());
            sheet.AddValidationData(SetColumnsYesNo());

            //表头  
            IRow row = sheet.CreateRow(0);
            row.HeightInPoints = 30f;

            // 标题及内容单元格样式
            var headCellStyle = CreateCellStyle(workbook, true);
            var contentCellStyle = CreateCellStyle(workbook, false);

            //日期单元格样式
            var datestyle = DateStyle(workbook);

            // 每列列宽字典
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                ICell cell = row.CreateCell(i);
                cell.SetCellValue(dt.Columns[i].Caption);

                sheet.GetRow(0).GetCell(i).CellStyle = headCellStyle;

                dic.Add(i, Encoding.Default.GetBytes(cell.StringCellValue).Length * 256 + 200);
            }

            //数据  
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                IRow row1 = sheet.CreateRow(i + 1);

                // 行高，避免自动换行的内容将行高撑开
                //row1.HeightInPoints = 30f;

                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    ICell cell = row1.CreateCell(j);

                    if (dt.Columns.Count == 40)
                    {
                        if (j == 20 || j == 21 || j == 28)
                        {
                            cell.SetCellValue(Convert.ToDateTime(dt.Rows[i][j]).ToString("yyyy-MM-dd"));

                            cell.CellStyle = datestyle;
                        }
                        else
                        {
                            cell.SetCellValue(dt.Rows[i][j].ToString());

                            cell.CellStyle = contentCellStyle;
                        }
                    }
                    else
                    {
                        cell.SetCellValue(dt.Rows[i][j].ToString());

                        cell.CellStyle = contentCellStyle;
                    }

                    int length = Encoding.Default.GetBytes(cell.StringCellValue).Length * 256 + 200;
                    length = length > 15000 ? 15000 : length;

                    // 若比已存在列宽更宽则替换，Excel限制最大宽度为15000
                    if (dic[j] < length)
                    {
                        dic[j] = length;
                    }
                }
            }

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                sheet.SetColumnWidth(i, dic[i]);
            }

            //转为字节数组  
            MemoryStream stream = new MemoryStream();
            workbook.Write(stream);
            var buf = stream.ToArray();

            if (File.Exists(file))
            {
                try
                {
                    //覆盖Excel文件  
                    using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Write))
                    {
                        fs.Write(buf, 0, buf.Length);
                        fs.Flush();
                    }
                }
                catch (Exception Ex)
                {
                    Public.Sys_MsgBox(Ex.Message);

                    return false;
                }
            }
            else
            {
                //新建Excel文件  
                using (FileStream fs = new FileStream(file, FileMode.CreateNew, FileAccess.Write))
                {
                    fs.Write(buf, 0, buf.Length);
                    fs.Flush();
                }
            }

            return true;
        }

        /// <summary>
        /// 单元格样式
        /// </summary>
        /// <param name="workbook"></param>
        /// <param name="isHead"></param>
        /// <returns></returns>
        private static ICellStyle CreateCellStyle(IWorkbook workbook, bool isHead)
        {
            var cellStyle = workbook.CreateCellStyle();

            var font = workbook.CreateFont();
            font.IsBold = isHead; // 粗体
            font.FontName = "宋体";

            if (isHead)
            {
                font.FontHeightInPoints = 12;

                cellStyle.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Yellow.Index;
                cellStyle.FillPattern = FillPattern.SolidForeground;
            }
            else
            {
                font.FontHeightInPoints = 11;
            }

            cellStyle.Alignment = HorizontalAlignment.Center; // 水平居中
            cellStyle.VerticalAlignment = VerticalAlignment.Center; // 垂直居中

            cellStyle.SetFont(font);

            cellStyle.BorderTop = BorderStyle.Thin;
            cellStyle.BorderBottom = BorderStyle.Thin;
            cellStyle.BorderLeft = BorderStyle.Thin;
            cellStyle.BorderRight = BorderStyle.Thin;
            cellStyle.WrapText = true;//内容自动换行，避免存在换行符的内容合并成单行

            return cellStyle;
        }

        public static DataTable GetDgvToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            // 列强制转换
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                //if (dgv.Columns[i].Visible)
                //{
                DataColumn dc = new DataColumn(dgv.Columns[i].Name.ToString())
                {
                    Caption = dgv.Columns[i].HeaderText
                };
                dt.Columns.Add(dc);
                //}
            }

            // 循环行
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();

                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    //if (dgv.Columns[j].Visible)
                    //{
                    dr[j] = Convert.ToString(dgv.Rows[i].Cells[j].Value);
                    //}
                }

                dt.Rows.Add(dr);
            }
            return dt;
        }

        private static HSSFDataValidation SetColumnsComplete()
        {
            //设置生成下拉框的行和列
            CellRangeAddressList cellComplete = new CellRangeAddressList(0, 65535, 36, 38);

            //设置 下拉框内容
            DVConstraint constraint = DVConstraint.CreateExplicitListConstraint(new string[] { "完成", "未完成" });

            //绑定下拉框和作用区域，并设置错误提示信息
            HSSFDataValidation dataValidate = new HSSFDataValidation(cellComplete, constraint);
            dataValidate.CreateErrorBox("输入不合法", "请输入下拉列表中的值！");
            dataValidate.ShowPromptBox = true;

            return dataValidate;
        }

        private static HSSFDataValidation SetColumnsYesNo()
        {
            //设置生成下拉框的行和列
            CellRangeAddressList cellComplete = new CellRangeAddressList(0, 65535, 35, 35);

            //设置 下拉框内容
            DVConstraint constraint = DVConstraint.CreateExplicitListConstraint(new string[] { "是", "否" });

            //绑定下拉框和作用区域，并设置错误提示信息
            HSSFDataValidation dataValidate = new HSSFDataValidation(cellComplete, constraint);
            dataValidate.CreateErrorBox("输入不合法", "请输入下拉列表中的值！");
            dataValidate.ShowPromptBox = true;

            return dataValidate;
        }

        private static HSSFDataValidation SetColumnsTypes()
        {
            DataSet Ds = DB_Works.DataSetCmd("SELECT Name FROM Types");

            string[] strTypes = new string[Ds.Tables[0].Rows.Count];

            for (int i = 0; i < strTypes.Length; i++)
            {
                strTypes[i] = Ds.Tables[0].Rows[i][0].ToString();
            }

            //设置生成下拉框的行和列
            CellRangeAddressList cellComplete = new CellRangeAddressList(0, 65535, 12, 12);

            //设置 下拉框内容
            DVConstraint constraint = DVConstraint.CreateExplicitListConstraint(strTypes);

            //绑定下拉框和作用区域，并设置错误提示信息
            HSSFDataValidation dataValidate = new HSSFDataValidation(cellComplete, constraint);
            dataValidate.CreateErrorBox("输入不合法", "请输入下拉列表中的值！");
            dataValidate.ShowPromptBox = true;

            return dataValidate;
        }
    }
}
