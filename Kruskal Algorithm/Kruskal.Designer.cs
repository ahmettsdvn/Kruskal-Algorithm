namespace Kruskal_Algorithm
{
    partial class Kruskal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kruskal));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.clusterCount = new System.Windows.Forms.NumericUpDown();
            this.btn_random = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cluster = new MaterialSkin.Controls.MaterialFlatButton();
            this.txt_numbers = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statistics = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_draw = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clusterCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.clusterCount);
            this.panel2.Controls.Add(this.btn_random);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_cluster);
            this.panel2.Controls.Add(this.txt_numbers);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 144);
            this.panel2.TabIndex = 5;
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Location = new System.Drawing.Point(164, 47);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 41);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.TabStop = false;
            this.btn_clear.Text = "Temizle";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // clusterCount
            // 
            this.clusterCount.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.clusterCount.Location = new System.Drawing.Point(105, 108);
            this.clusterCount.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.clusterCount.Name = "clusterCount";
            this.clusterCount.Size = new System.Drawing.Size(62, 21);
            this.clusterCount.TabIndex = 2;
            this.clusterCount.TabStop = false;
            this.clusterCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_random
            // 
            this.btn_random.ActiveBorderThickness = 1;
            this.btn_random.ActiveCornerRadius = 20;
            this.btn_random.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(58)))));
            this.btn_random.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.btn_random.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(58)))));
            this.btn_random.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btn_random.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_random.BackgroundImage")));
            this.btn_random.ButtonText = "Nokta Oluştur";
            this.btn_random.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_random.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_random.ForeColor = System.Drawing.Color.Black;
            this.btn_random.IdleBorderThickness = 1;
            this.btn_random.IdleCornerRadius = 20;
            this.btn_random.IdleFillColor = System.Drawing.Color.Silver;
            this.btn_random.IdleForecolor = System.Drawing.Color.SeaShell;
            this.btn_random.IdleLineColor = System.Drawing.Color.White;
            this.btn_random.Location = new System.Drawing.Point(5, 49);
            this.btn_random.Margin = new System.Windows.Forms.Padding(5);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(151, 41);
            this.btn_random.TabIndex = 3;
            this.btn_random.TabStop = false;
            this.btn_random.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Küme Sayısı : ";
            // 
            // btn_cluster
            // 
            this.btn_cluster.AutoSize = true;
            this.btn_cluster.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cluster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cluster.Depth = 0;
            this.btn_cluster.Location = new System.Drawing.Point(174, 101);
            this.btn_cluster.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cluster.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cluster.Name = "btn_cluster";
            this.btn_cluster.Primary = false;
            this.btn_cluster.Size = new System.Drawing.Size(65, 36);
            this.btn_cluster.TabIndex = 1;
            this.btn_cluster.TabStop = false;
            this.btn_cluster.Text = "Kümele";
            this.btn_cluster.UseVisualStyleBackColor = true;
            this.btn_cluster.Click += new System.EventHandler(this.btn_cluster_Click);
            // 
            // txt_numbers
            // 
            this.txt_numbers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_numbers.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_numbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_numbers.HintForeColor = System.Drawing.Color.DarkGray;
            this.txt_numbers.HintText = "Nokta Adeti";
            this.txt_numbers.isPassword = false;
            this.txt_numbers.LineFocusedColor = System.Drawing.Color.Plum;
            this.txt_numbers.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txt_numbers.LineMouseHoverColor = System.Drawing.Color.Plum;
            this.txt_numbers.LineThickness = 2;
            this.txt_numbers.Location = new System.Drawing.Point(61, 6);
            this.txt_numbers.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numbers.Name = "txt_numbers";
            this.txt_numbers.Size = new System.Drawing.Size(179, 34);
            this.txt_numbers.TabIndex = 1;
            this.txt_numbers.TabStop = false;
            this.txt_numbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_numbers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numbers_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adet : ";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.panel3);
            this.groupControl1.Controls.Add(this.panel2);
            this.groupControl1.Location = new System.Drawing.Point(0, 63);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(253, 613);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Menü";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.statistics);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 432);
            this.panel3.TabIndex = 6;
            // 
            // statistics
            // 
            this.statistics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statistics.Cursor = System.Windows.Forms.Cursors.No;
            this.statistics.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statistics.Location = new System.Drawing.Point(6, 52);
            this.statistics.Name = "statistics";
            this.statistics.ReadOnly = true;
            this.statistics.Size = new System.Drawing.Size(233, 375);
            this.statistics.TabIndex = 0;
            this.statistics.TabStop = false;
            this.statistics.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(71, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "İSTATİSTİK";
            // 
            // panel_draw
            // 
            this.panel_draw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_draw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_draw.Location = new System.Drawing.Point(259, 63);
            this.panel_draw.Name = "panel_draw";
            this.panel_draw.Size = new System.Drawing.Size(924, 613);
            this.panel_draw.TabIndex = 1;
            this.panel_draw.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_draw_Paint);
            this.panel_draw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_draw_MouseClick);
            // 
            // Kruskal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1186, 678);
            this.Controls.Add(this.panel_draw);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Kruskal";
            this.Resizable = false;
            this.Text = "Kruskal Algorithm";
            this.Load += new System.EventHandler(this.Kruskal_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clusterCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown clusterCount;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_random;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialFlatButton btn_cluster;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_numbers;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Panel panel_draw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox statistics;
    }
}

