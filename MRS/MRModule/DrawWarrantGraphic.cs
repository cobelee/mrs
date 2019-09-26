using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace MRS.MRModule
{
    public class DrawWarrantGraphic
    {
        public MRS.Model.BXD BaoXiaoDan;
        public MRS.Model.BXWarrantTable WarrantTable;
        private Font TextFont, TitleFont;
        private float LineHeight;
        private int MarginTop, MarginLeft;

        public DrawWarrantGraphic()
        {
            InitDrawWarrantGraphic();
        }

        private void InitDrawWarrantGraphic()
        {
            BaoXiaoDan = new MRS.Model.BXD();
            WarrantTable = new MRS.Model.BXWarrantTable();
            //WarrantSite = new Point();

            MarginTop = 0;
            MarginLeft = 15;   //单元格内字与左边框的间距

            TextFont = new Font("宋体", 12);
            TitleFont = new Font("黑体", 16);
            LineHeight = 30;
        }

        public void Draw(Graphics WarrantGraphic)
        {
            //下面注销部分为纸张画方格线
            //for (int i = 0; i < 12; i++)
            //{
            //    WarrantGraphic.DrawLine(Pens.Blue, new Point(0, i * 100), new Point(800, i * 100));
            //    WarrantGraphic.DrawLine(Pens.Blue, new Point(i * 100, 0), new Point(i * 100, 1200));
            //}

            //for (int i = 0; i < 120; i++)
            //{
            //    if (i % 10 != 0)
            //    {
            //        WarrantGraphic.DrawLine(Pens.YellowGreen, new Point(0, i * 10), new Point(800, i * 10));
            //        WarrantGraphic.DrawLine(Pens.YellowGreen, new Point(i * 10, 0), new Point(i * 10, 1200));
            //    }
            //}

            // 一张纸打印上下两联，自2019年9月26日后，改为只打印一联。
            DrawSingleWarrant(WarrantGraphic, new Point(65, 70));
            //DrawSingleWarrant(WarrantGraphic, new Point(65, 600));
        }

        private void DrawSingleWarrant(Graphics WarrantGraphic, System.Drawing.Point WarrantSite)
        {
            System.Drawing.Point WarrantBodySite = new Point();

            WarrantBodySite.X = WarrantSite.X;
            WarrantBodySite.Y = WarrantSite.Y + 70;

            WarrantGraphic.DrawString("镇海石化工业贸易有限责任公司", TextFont, Brushes.Black, new PointF(WarrantSite.X + 240, WarrantSite.Y));
            WarrantGraphic.DrawString("补充医保报销凭证", TitleFont, Brushes.Black, new PointF(WarrantSite.X + 270, WarrantSite.Y + 30));
            //第一行
            WarrantGraphic.DrawString("报销日期：", TextFont, Brushes.Black, new PointF(WarrantBodySite.X, WarrantBodySite.Y));
            WarrantGraphic.DrawString(BaoXiaoDan.BXDate.ToShortDateString(), TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 90, WarrantBodySite.Y));
            WarrantGraphic.DrawString("单位：元", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 300, WarrantBodySite.Y));
            WarrantGraphic.DrawString("报销单号：", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 500, WarrantBodySite.Y));
            WarrantGraphic.DrawString(BaoXiaoDan.BXDId.ToString(), TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 580, WarrantBodySite.Y));

            //第二行
            WarrantGraphic.DrawString("姓名", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + MarginLeft, WarrantBodySite.Y + LineHeight));
            WarrantGraphic.DrawString(BaoXiaoDan.Name, TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 100 + MarginLeft, WarrantBodySite.Y + LineHeight));
            WarrantGraphic.DrawString("医保号", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 210 + MarginLeft, WarrantBodySite.Y + LineHeight));
            WarrantGraphic.DrawString(BaoXiaoDan.YBH, TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 300 + MarginLeft, WarrantBodySite.Y + LineHeight));
            WarrantGraphic.DrawString("人员类别", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 440 + MarginLeft, WarrantBodySite.Y + LineHeight));
            WarrantGraphic.DrawString(BaoXiaoDan.PsnType, TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 550 + MarginLeft, WarrantBodySite.Y + LineHeight));

            //表格列名
            WarrantGraphic.DrawString("就诊方式", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + MarginLeft, WarrantBodySite.Y + 2 * LineHeight));
            WarrantGraphic.DrawString("医药费", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 100 + MarginLeft, WarrantBodySite.Y + 2 * LineHeight));
            WarrantGraphic.DrawString("公司补助", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 210 + MarginLeft, WarrantBodySite.Y + 2 * LineHeight));
            WarrantGraphic.DrawString("自理费", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 300 + MarginLeft, WarrantBodySite.Y + 2 * LineHeight));
            WarrantGraphic.DrawString("统筹基金", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 400 + MarginLeft, WarrantBodySite.Y + 2 * LineHeight));
            WarrantGraphic.DrawString("个人自费", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 500 + MarginLeft, WarrantBodySite.Y + 2 * LineHeight));
            WarrantGraphic.DrawString("个人自付", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 600 + MarginLeft, WarrantBodySite.Y + 2 * LineHeight));

            //表格内容
            for (int i = 0; i < WarrantTable.Rows.Count; i++)
            {
                WarrantGraphic.DrawString(WarrantTable.Rows[i]["就诊方式"].ToString(), TextFont, Brushes.Black, new PointF(WarrantBodySite.X + MarginLeft, WarrantBodySite.Y + (i + 3) * LineHeight));
                WarrantGraphic.DrawString(WarrantTable.Rows[i]["医药费"].ToString(), TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 100 + MarginLeft, WarrantBodySite.Y + (i + 3) * LineHeight));
                WarrantGraphic.DrawString(WarrantTable.Rows[i]["公司补助"].ToString(), TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 210 + MarginLeft, WarrantBodySite.Y + (i + 3) * LineHeight));
                WarrantGraphic.DrawString(WarrantTable.Rows[i]["自理费"].ToString(), TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 300 + MarginLeft, WarrantBodySite.Y + (i + 3) * LineHeight));
                WarrantGraphic.DrawString(WarrantTable.Rows[i]["统筹基金"].ToString(), TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 400 + MarginLeft, WarrantBodySite.Y + (i + 3) * LineHeight));
                WarrantGraphic.DrawString(WarrantTable.Rows[i]["个人自费"].ToString(), TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 500 + MarginLeft, WarrantBodySite.Y + (i + 3) * LineHeight));
                WarrantGraphic.DrawString(WarrantTable.Rows[i]["个人自付"].ToString(), TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 600 + MarginLeft, WarrantBodySite.Y + (i + 3) * LineHeight));
            }

            //附件张数
            WarrantGraphic.DrawString("附件张数：", TextFont, Brushes.Black, new PointF(WarrantBodySite.X, WarrantBodySite.Y + 9 * LineHeight));
            WarrantGraphic.DrawString(BaoXiaoDan.AttNumber.ToString(), TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 90, WarrantBodySite.Y + 9 * LineHeight));
            WarrantGraphic.DrawString("会计：", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 320, WarrantBodySite.Y + 9 * LineHeight));
            WarrantGraphic.DrawString(BaoXiaoDan.Accountant, TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 380, WarrantBodySite.Y + 9 * LineHeight));
            WarrantGraphic.DrawString("出纳", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 540, WarrantBodySite.Y + 9 * LineHeight));

            //本次报销金额
            WarrantGraphic.DrawString("本次报销金额：", TextFont, Brushes.Black, new PointF(WarrantBodySite.X, WarrantBodySite.Y + 10 * LineHeight));
            WarrantGraphic.DrawString(BaoXiaoDan.BXJE.ToString(), new Font("宋体", 14, FontStyle.Bold), Brushes.Black, new PointF(WarrantBodySite.X + 120, WarrantBodySite.Y + 10 * LineHeight));
            WarrantGraphic.DrawString("报销人签字：", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 450, WarrantBodySite.Y + 10 * LineHeight));
            WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X + 540, WarrantBodySite.Y + 11 * LineHeight), new PointF(WarrantBodySite.X + 690, WarrantBodySite.Y + 11 * LineHeight));
            WarrantGraphic.DrawString("备注：“年度累计”值未包含“本次合计”值。", TextFont, Brushes.Black, new PointF(WarrantBodySite.X, WarrantBodySite.Y + 11 * LineHeight));

            //给姓名这行的上下画横线
            WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X, WarrantBodySite.Y + 20), new PointF(WarrantBodySite.X + 700, WarrantBodySite.Y + 20));
            WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X, WarrantBodySite.Y + 20 + LineHeight), new PointF(WarrantBodySite.X + 700, WarrantBodySite.Y + 20 + LineHeight));
            //给姓名这行画竖线
            WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X, WarrantBodySite.Y + 20), new PointF(WarrantBodySite.X, WarrantBodySite.Y + 20 + LineHeight));
            WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X + 100, WarrantBodySite.Y + 20), new PointF(WarrantBodySite.X + 100, WarrantBodySite.Y + 20 + LineHeight));
            WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X + 210, WarrantBodySite.Y + 20), new PointF(WarrantBodySite.X + 210, WarrantBodySite.Y + 20 + LineHeight));
            WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X + 300, WarrantBodySite.Y + 20), new PointF(WarrantBodySite.X + 300, WarrantBodySite.Y + 20 + LineHeight));
            WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X + 440, WarrantBodySite.Y + 20), new PointF(WarrantBodySite.X + 440, WarrantBodySite.Y + 20 + LineHeight));
            WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X + 540, WarrantBodySite.Y + 20), new PointF(WarrantBodySite.X + 540, WarrantBodySite.Y + 20 + LineHeight));
            WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X + 700, WarrantBodySite.Y + 20), new PointF(WarrantBodySite.X + 700, WarrantBodySite.Y + 20 + LineHeight));


            //为表格画横线和竖线
            for (int i = 0; i <= WarrantTable.Rows.Count; i++)
            {
                WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X, WarrantBodySite.Y + 20 + (i + 2) * LineHeight), new PointF(WarrantBodySite.X + 700, WarrantBodySite.Y + 20 + (i + 2) * LineHeight));

                WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X, WarrantBodySite.Y + 20 + (i + 1) * LineHeight), new PointF(WarrantBodySite.X, WarrantBodySite.Y + 20 + (i + 2) * LineHeight));
                WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X + 100, WarrantBodySite.Y + 20 + (i + 1) * LineHeight), new PointF(WarrantBodySite.X + 100, WarrantBodySite.Y + 20 + (i + 2) * LineHeight));
                WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X + 210, WarrantBodySite.Y + 20 + (i + 1) * LineHeight), new PointF(WarrantBodySite.X + 210, WarrantBodySite.Y + 20 + (i + 2) * LineHeight));
                WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X + 300, WarrantBodySite.Y + 20 + (i + 1) * LineHeight), new PointF(WarrantBodySite.X + 300, WarrantBodySite.Y + 20 + (i + 2) * LineHeight));
                WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X + 400, WarrantBodySite.Y + 20 + (i + 1) * LineHeight), new PointF(WarrantBodySite.X + 400, WarrantBodySite.Y + 20 + (i + 2) * LineHeight));
                WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X + 500, WarrantBodySite.Y + 20 + (i + 1) * LineHeight), new PointF(WarrantBodySite.X + 500, WarrantBodySite.Y + 20 + (i + 2) * LineHeight));
                WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X + 600, WarrantBodySite.Y + 20 + (i + 1) * LineHeight), new PointF(WarrantBodySite.X + 600, WarrantBodySite.Y + 20 + (i + 2) * LineHeight));
                WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X + 700, WarrantBodySite.Y + 20 + (i + 1) * LineHeight), new PointF(WarrantBodySite.X + 700, WarrantBodySite.Y + 20 + (i + 2) * LineHeight));

            }
        }
    }
}
