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
            MarginLeft = 15;   //��Ԫ����������߿�ļ��

            TextFont = new Font("����", 12);
            TitleFont = new Font("����", 16);
            LineHeight = 30;
        }

        public void Draw(Graphics WarrantGraphic)
        {
            //����ע������Ϊֽ�Ż�������
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

            DrawSingleWarrant(WarrantGraphic, new Point(65, 70));
            DrawSingleWarrant(WarrantGraphic, new Point(65, 600));
        }

        private void DrawSingleWarrant(Graphics WarrantGraphic, System.Drawing.Point WarrantSite)
        {
            System.Drawing.Point WarrantBodySite = new Point();

            WarrantBodySite.X = WarrantSite.X;
            WarrantBodySite.Y = WarrantSite.Y + 70;

            WarrantGraphic.DrawString("��ʯ����ҵó���������ι�˾", TextFont, Brushes.Black, new PointF(WarrantSite.X + 240, WarrantSite.Y));
            WarrantGraphic.DrawString("����ҽ������ƾ֤", TitleFont, Brushes.Black, new PointF(WarrantSite.X + 270, WarrantSite.Y + 30));
            //��һ��
            WarrantGraphic.DrawString("�������ڣ�", TextFont, Brushes.Black, new PointF(WarrantBodySite.X, WarrantBodySite.Y));
            WarrantGraphic.DrawString(BaoXiaoDan.BXDate.ToShortDateString(), TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 90, WarrantBodySite.Y));
            WarrantGraphic.DrawString("��λ��Ԫ", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 300, WarrantBodySite.Y));
            WarrantGraphic.DrawString("�������ţ�", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 500, WarrantBodySite.Y));
            WarrantGraphic.DrawString(BaoXiaoDan.BXDId.ToString(), TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 580, WarrantBodySite.Y));

            //�ڶ���
            WarrantGraphic.DrawString("����", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + MarginLeft, WarrantBodySite.Y + LineHeight));
            WarrantGraphic.DrawString(BaoXiaoDan.Name, TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 100 + MarginLeft, WarrantBodySite.Y + LineHeight));
            WarrantGraphic.DrawString("ҽ����", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 210 + MarginLeft, WarrantBodySite.Y + LineHeight));
            WarrantGraphic.DrawString(BaoXiaoDan.YBH, TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 300 + MarginLeft, WarrantBodySite.Y + LineHeight));
            WarrantGraphic.DrawString("��Ա���", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 440 + MarginLeft, WarrantBodySite.Y + LineHeight));
            WarrantGraphic.DrawString(BaoXiaoDan.PsnType, TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 550 + MarginLeft, WarrantBodySite.Y + LineHeight));

            //��������
            WarrantGraphic.DrawString("���﷽ʽ", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + MarginLeft, WarrantBodySite.Y + 2 * LineHeight));
            WarrantGraphic.DrawString("ҽҩ��", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 100 + MarginLeft, WarrantBodySite.Y + 2 * LineHeight));
            WarrantGraphic.DrawString("��˾����", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 210 + MarginLeft, WarrantBodySite.Y + 2 * LineHeight));
            WarrantGraphic.DrawString("������", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 300 + MarginLeft, WarrantBodySite.Y + 2 * LineHeight));
            WarrantGraphic.DrawString("ͳ�����", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 400 + MarginLeft, WarrantBodySite.Y + 2 * LineHeight));
            WarrantGraphic.DrawString("�����Է�", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 500 + MarginLeft, WarrantBodySite.Y + 2 * LineHeight));
            WarrantGraphic.DrawString("�����Ը�", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 600 + MarginLeft, WarrantBodySite.Y + 2 * LineHeight));

            //��������
            for (int i = 0; i < WarrantTable.Rows.Count; i++)
            {
                WarrantGraphic.DrawString(WarrantTable.Rows[i]["���﷽ʽ"].ToString(), TextFont, Brushes.Black, new PointF(WarrantBodySite.X + MarginLeft, WarrantBodySite.Y + (i + 3) * LineHeight));
                WarrantGraphic.DrawString(WarrantTable.Rows[i]["ҽҩ��"].ToString(), TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 100 + MarginLeft, WarrantBodySite.Y + (i + 3) * LineHeight));
                WarrantGraphic.DrawString(WarrantTable.Rows[i]["��˾����"].ToString(), TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 210 + MarginLeft, WarrantBodySite.Y + (i + 3) * LineHeight));
                WarrantGraphic.DrawString(WarrantTable.Rows[i]["������"].ToString(), TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 300 + MarginLeft, WarrantBodySite.Y + (i + 3) * LineHeight));
                WarrantGraphic.DrawString(WarrantTable.Rows[i]["ͳ�����"].ToString(), TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 400 + MarginLeft, WarrantBodySite.Y + (i + 3) * LineHeight));
                WarrantGraphic.DrawString(WarrantTable.Rows[i]["�����Է�"].ToString(), TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 500 + MarginLeft, WarrantBodySite.Y + (i + 3) * LineHeight));
                WarrantGraphic.DrawString(WarrantTable.Rows[i]["�����Ը�"].ToString(), TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 600 + MarginLeft, WarrantBodySite.Y + (i + 3) * LineHeight));
            }

            //��������
            WarrantGraphic.DrawString("����������", TextFont, Brushes.Black, new PointF(WarrantBodySite.X, WarrantBodySite.Y + 9 * LineHeight));
            WarrantGraphic.DrawString(BaoXiaoDan.AttNumber.ToString(), TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 90, WarrantBodySite.Y + 9 * LineHeight));
            WarrantGraphic.DrawString("��ƣ�", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 320, WarrantBodySite.Y + 9 * LineHeight));
            WarrantGraphic.DrawString(BaoXiaoDan.Accountant, TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 380, WarrantBodySite.Y + 9 * LineHeight));
            WarrantGraphic.DrawString("����", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 540, WarrantBodySite.Y + 9 * LineHeight));

            //���α������
            WarrantGraphic.DrawString("���α�����", TextFont, Brushes.Black, new PointF(WarrantBodySite.X, WarrantBodySite.Y + 10 * LineHeight));
            WarrantGraphic.DrawString(BaoXiaoDan.BXJE.ToString(), new Font("����", 14, FontStyle.Bold), Brushes.Black, new PointF(WarrantBodySite.X + 120, WarrantBodySite.Y + 10 * LineHeight));
            WarrantGraphic.DrawString("������ǩ�֣�", TextFont, Brushes.Black, new PointF(WarrantBodySite.X + 450, WarrantBodySite.Y + 10 * LineHeight));
            WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X + 540, WarrantBodySite.Y + 11 * LineHeight), new PointF(WarrantBodySite.X + 690, WarrantBodySite.Y + 11 * LineHeight));
            WarrantGraphic.DrawString("��ע��������ۼơ�ֵδ���������κϼơ�ֵ��", TextFont, Brushes.Black, new PointF(WarrantBodySite.X, WarrantBodySite.Y + 11 * LineHeight));

            //���������е����»�����
            WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X, WarrantBodySite.Y + 20), new PointF(WarrantBodySite.X + 700, WarrantBodySite.Y + 20));
            WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X, WarrantBodySite.Y + 20 + LineHeight), new PointF(WarrantBodySite.X + 700, WarrantBodySite.Y + 20 + LineHeight));
            //���������л�����
            WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X, WarrantBodySite.Y + 20), new PointF(WarrantBodySite.X, WarrantBodySite.Y + 20 + LineHeight));
            WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X + 100, WarrantBodySite.Y + 20), new PointF(WarrantBodySite.X + 100, WarrantBodySite.Y + 20 + LineHeight));
            WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X + 210, WarrantBodySite.Y + 20), new PointF(WarrantBodySite.X + 210, WarrantBodySite.Y + 20 + LineHeight));
            WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X + 300, WarrantBodySite.Y + 20), new PointF(WarrantBodySite.X + 300, WarrantBodySite.Y + 20 + LineHeight));
            WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X + 440, WarrantBodySite.Y + 20), new PointF(WarrantBodySite.X + 440, WarrantBodySite.Y + 20 + LineHeight));
            WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X + 540, WarrantBodySite.Y + 20), new PointF(WarrantBodySite.X + 540, WarrantBodySite.Y + 20 + LineHeight));
            WarrantGraphic.DrawLine(Pens.Black, new PointF(WarrantBodySite.X + 700, WarrantBodySite.Y + 20), new PointF(WarrantBodySite.X + 700, WarrantBodySite.Y + 20 + LineHeight));


            //Ϊ���񻭺��ߺ�����
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