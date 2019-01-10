using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kruskal_Algorithm
{
    public partial class Kruskal : MetroFramework.Forms.MetroForm
    {
        private bool bittiMi;
        private List<DataPoint> listeDP;
        private List<Cluster> listeKüme;
        private List<DPLimit> listeLimit;
        private List<Color> listeRenk;
        private long noktaSayısı;
        private long kümeSayısı;
        private Point cursor;
        private Point[] points = new Point[99999];
        private int k = 0;
        private double distance;
        private double[] sortedArray = new double[99999];
        private List<double> sortedList;
        double resultX,resultY,standartsapmaX = 0,standartsapmaY=0;
        public Kruskal()
        {
            InitializeComponent();

            InitializeVariables();
        }
        private void Kruskal_Load(object sender, EventArgs e)
        {

        }

        private void InitializeVariables()
        {
            listeKüme = new List<Cluster>();
            listeDP = new List<DataPoint>();
            listeLimit = new List<DPLimit>();
            listeRenk = new List<Color>();
            listeRenk.Add(Color.Yellow);
            listeRenk.Add(Color.Red);
            listeRenk.Add(Color.Black);
            listeRenk.Add(Color.Teal);
            listeRenk.Add(Color.Gray);
            listeRenk.Add(Color.Orange);
            listeRenk.Add(Color.Navy);
            listeRenk.Add(Color.Pink);
            listeRenk.Add(Color.Azure);
            listeRenk.Add(Color.Chocolate);
            listeRenk.Add(Color.Turquoise);
            listeRenk.Add(Color.DarkGreen);
        }

        private void CreateDataPoints()
        {
            listeDP = new List<DataPoint>();
            listeKüme = new List<Cluster>();
            listeLimit = new List<DPLimit>();

            Random rand = new Random();
            for (int i = 0; i < noktaSayısı; i++)
            {
                int xPoint = rand.Next(panel_draw.Size.Width);
                int yPoint = rand.Next(panel_draw.Size.Height);

                DataPoint dataPoint = new DataPoint(i + 1, xPoint, yPoint, null);
                listeDP.Add(dataPoint);
            }
        }

        private void CreateClustersWithImproving()
        {
            listeKüme = new List<Cluster>();
            int XCenter = 0;
            int YCenter = 0;
            foreach (DataPoint dataPoint in listeDP)
            {
                int xdis = (dataPoint.XPoint - XCenter);
                int ydis = (dataPoint.YPoint - YCenter);
                int tot = (xdis * xdis + ydis * ydis);
                double distance = Math.Sqrt(tot);
                dataPoint.Distace = distance;
            }

            sortedList = new List<double>();

            foreach (DataPoint pointDistnace in listeDP)
            {
                distance = pointDistnace.Distace;
                sortedList.Add(distance);
            }

            sortedArray = sortedList.ToArray();
            Heap heap = new Heap();
            heap.PerformHeapSort(sortedArray);

            for (int i = 0; i < kümeSayısı; i++)
            {
                int index = Convert.ToInt16(listeDP.Count / (kümeSayısı * 2) * (2 * i + 1));
                int xPoint = listeDP[index].XPoint;
                int yPoint = listeDP[index].YPoint;
                Cluster cluster = new Cluster(i + 1, xPoint, yPoint, listeRenk[i]);
                listeKüme.Add(cluster);
            }
        }

        private void CreateClusters()
        {
            listeKüme = new List<Cluster>();
            Random rand = new Random();
            for (int i = 0; i < kümeSayısı; i++)
            {
                int xPoint = rand.Next(panel_draw.Size.Width);
                int yPoint = rand.Next(panel_draw.Size.Height);

                Cluster cluster = new Cluster(i + 1, xPoint, yPoint, listeRenk[i]);
                listeKüme.Add(cluster);
            }
        }

        private void PaintInPanel()
        {
            Graphics g;
            g = panel_draw.CreateGraphics();
            Pen p = new Pen(Color.Coral, 2);
            foreach (DataPoint dataPoint in listeDP)
            {
                if (dataPoint.Cluster != null)
                {
                    p.Color = dataPoint.Cluster.ColorOfPoint;
                    p.Width = 6;
                }

                Rectangle rect = new Rectangle(dataPoint.XPoint, dataPoint.YPoint, 20, 20);
                g.DrawEllipse(p, rect);
                g.FillEllipse(Brushes.Fuchsia, dataPoint.XPoint, dataPoint.YPoint, 20 ,20);
                g.DrawString(dataPoint.Number.ToString(), new Font("Times New Roman", 8), Brushes.DarkCyan, dataPoint.XPoint+5, dataPoint.YPoint+3);
            }
            foreach (Cluster cluster in listeKüme)
            {
                Rectangle rect = new Rectangle(cluster.XPoint, cluster.YPoint, 20, 20);
                p.Color = cluster.ColorOfPoint;
                g.DrawRectangle(p, rect);
                g.FillRectangle(Brushes.YellowGreen, cluster.XPoint, cluster.YPoint, 20, 20);
                g.DrawString("MERKEZ", new Font("Times New Roman", 8), Brushes.Firebrick, cluster.XPoint, cluster.YPoint);
                
            }
        }
        private void Reset()
        {
            noktaSayısı = Convert.ToInt64(txt_numbers.Text);
            CreateDataPoints();
            panel_draw.Invalidate();
        }
        private void InitializeCluster()
        {
            kümeSayısı = Convert.ToInt64(clusterCount.Value);
            CreateClusters();
            SetClustersOfDataPointsRandomly();
            panel_draw.Invalidate();
        }
        private void SetClustersOfDataPointsRandomly()
        {
            Random rand = new Random();
            foreach (DataPoint dataPoint in listeDP)
            {
                dataPoint.Cluster = listeKüme[rand.Next((int)kümeSayısı)];
            }
        }
        private void InitializeClusterWithImproving()
        {
            kümeSayısı = Convert.ToInt64(clusterCount.Value);

            CreateClustersWithImproving();

            SetClustersOfDataPointsRandomly();
        }
        private void AssignDataPointsToCloserCluster()
        {
            foreach (DataPoint dataPoint in listeDP)
            {
                Cluster nearestCluster = null;
                double distance = 999999999999;
                foreach (Cluster cluster in listeKüme)
                {
                    double tempDistance = GetDistance(dataPoint, cluster);
                    if (tempDistance < distance)
                    {
                        nearestCluster = cluster;
                        distance = tempDistance;
                    }
                }
                dataPoint.Cluster = nearestCluster;
            }
            panel_draw.Invalidate();
        }
        private void CalculateCenterOfEachCluster()
        {
            foreach (DataPoint dataPoint in listeDP)
            {
                dataPoint.Cluster.XTotal += dataPoint.XPoint;
                dataPoint.Cluster.YTotal += dataPoint.YPoint;
                dataPoint.Cluster.TotalDataPoints++;
            }

            bool isSame = true;
            foreach (Cluster cluster in listeKüme)
            {
                if (cluster.TotalDataPoints > 0)
                {
                    cluster.setXPoint(Convert.ToInt16(cluster.XTotal / cluster.TotalDataPoints));
                    cluster.setYPoint(Convert.ToInt16(cluster.YTotal / cluster.TotalDataPoints));
                    if (!(cluster.XPoint == cluster.OldXPoint &&
                        cluster.YPoint == cluster.OldYPoint &&
                        cluster.OldTotalDataPoints == cluster.OldTotalDataPoints))
                    {
                        isSame = false;
                    }
                    cluster.SetToDefaultTotal();
                }
               
            }

            if (isSame)
            {
                bittiMi = true;
            }
            panel_draw.Invalidate();
        }
        private double GetDistance(DataPoint dataPoint, Cluster cluster)
        {
            int xdis = (dataPoint.XPoint - cluster.XPoint);
            int ydis = (dataPoint.YPoint - cluster.YPoint);
            int tot = (xdis * xdis + ydis * ydis);
            double distance = Math.Sqrt(tot);
            return distance;
        }
        private void FintTheResult()
        {
            bittiMi = false;
            while (!bittiMi)
            {
                AssignDataPointsToCloserCluster();
                CalculateCenterOfEachCluster();
            }
        }

        private void panel_draw_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawEllipse();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            listeKüme.Clear();
            listeDP.Clear();
            listeLimit.Clear();
            txt_numbers.Text = "";
            clusterCount.Value = 0;
            k = 0;
            statistics.Text = "";
            standartsapmaX = 0;
            standartsapmaY = 0;
            panel_draw.Invalidate();
        }

        private void btn_cluster_Click(object sender, EventArgs e)
        {
            try
            {
                InitializeClusterWithImproving();
                panel_draw.Invalidate();
                InitializeCluster();
                AssignDataPointsToCloserCluster();
                CalculateCenterOfEachCluster();
                FintTheResult();
                statistics.Text = "";
                CalculateStandartDeviation();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! ");
            }
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            try
            {
                Reset();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Nokta Sayısını Giriniz.");
            }
        }

        private void txt_numbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void panel_draw_Paint(object sender, PaintEventArgs e)
        {
            PaintInPanel();
        }

        public void drawEllipse()
        {
            Graphics g = panel_draw.CreateGraphics();
            Pen p = new Pen(Color.Coral, 2);
            cursor = panel_draw.PointToClient(Cursor.Position);
            listeDP = new List<DataPoint>();
            listeKüme = new List<Cluster>();
            listeLimit = new List<DPLimit>();            
            try
            {
                k++;
                g.DrawEllipse(p, cursor.X - 10, cursor.Y - 10, 20, 20);
                g.FillEllipse(Brushes.Fuchsia, cursor.X - 10, cursor.Y - 10, 20, 20);
                points[k] = new Point(cursor.X, cursor.Y);
                g.DrawString(k.ToString(), new Font("Times New Roman", 9), Brushes.Black, new Point(cursor.X - 5, cursor.Y - 5));
                for (int i = 1; i < k + 1; i++)
                {
                    DataPoint dp = new DataPoint(i, points[i].X, points[i].Y, null);
                    listeDP.Add(dp);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Bu kadar yeter");
                panel_draw.Invalidate();
                if (k == 1000000) k = 0;
            }
        }

        public void CalculateStandartDeviation()
        {
            foreach (DataPoint dataPoint in listeDP)
            {
                dataPoint.Cluster.XTotal += dataPoint.XPoint;
                dataPoint.Cluster.YTotal += dataPoint.YPoint;
                dataPoint.Cluster.TotalDataPoints++;
            }

            string finistext = "KÜMELEME BİTTİ" + Environment.NewLine;
            if (clusterCount.Value == 0) finistext = "KÜMELEME İŞLEMİ YOK";
            statistics.Text = finistext + "\n";
            foreach (Cluster cluster in listeKüme)
            {
                resultX = Convert.ToDouble(cluster.XPoint) / Convert.ToDouble(cluster.TotalDataPoints);
                resultY = Convert.ToDouble(cluster.YPoint) / Convert.ToDouble(cluster.TotalDataPoints); 
                standartsapmaX += (Convert.ToDouble(cluster.XPoint) -resultX)* (Convert.ToDouble(cluster.XPoint) - resultX);
                standartsapmaY += (Convert.ToDouble(cluster.YPoint) - resultY)* (Convert.ToDouble(cluster.YPoint) - resultY);        
                
                string resultStrig ="KÜME NUMARASI [" + cluster.Number + "]" +Environment.NewLine
                    +"KÜME RENGİ (" + cluster.ColorOfPoint.ToString() + ")" +Environment.NewLine+
                    cluster.TotalDataPoints.ToString() + " Adet Nokta Mevcut" + Environment.NewLine
                    +"Orta Noktası: "+ "(" + cluster.XPoint + " ; " + cluster.YPoint+ ")" +Environment.NewLine
                     + "Standart Sapma: (" + Math.Round(Math.Sqrt(standartsapmaX / (Convert.ToDouble(cluster.TotalDataPoints) -1)), 3)+
                    "   ,   " + Math.Round(Math.Sqrt(standartsapmaY / (Convert.ToDouble(cluster.TotalDataPoints) -1)), 3) + ")" +Environment.NewLine+
                    " **************** " + Environment.NewLine + "\n";


                statistics.AppendText(resultStrig);                
            }
        }
    } 
}
