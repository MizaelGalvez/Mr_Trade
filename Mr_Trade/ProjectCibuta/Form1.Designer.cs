﻿namespace MT_project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.DetecciondeMovimiento = new System.Windows.Forms.Timer(this.components);
            this.layoutnavegacion = new System.Windows.Forms.TableLayoutPanel();
            this.layouttodascamaras = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.videoSourcePlayer4 = new AForge.Controls.VideoSourcePlayer();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.videoSourcePlayer3 = new AForge.Controls.VideoSourcePlayer();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.videoSourcePlayer5 = new AForge.Controls.VideoSourcePlayer();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.videoSourcePlayer2 = new AForge.Controls.VideoSourcePlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DesvincularTodo = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.cambioResolucion = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Horario = new System.Windows.Forms.Button();
            this.Estrategia = new System.Windows.Forms.Button();
            this.layoutnavegacion.SuspendLayout();
            this.layouttodascamaras.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tableLayoutPanel19.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetecciondeMovimiento
            // 
            this.DetecciondeMovimiento.Enabled = true;
            this.DetecciondeMovimiento.Interval = 10;
            this.DetecciondeMovimiento.Tick += new System.EventHandler(this.DeteccionMovimiento);
            // 
            // layoutnavegacion
            // 
            this.layoutnavegacion.ColumnCount = 2;
            this.layoutnavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.layoutnavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutnavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.layoutnavegacion.Controls.Add(this.layouttodascamaras, 1, 0);
            this.layoutnavegacion.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.layoutnavegacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutnavegacion.Location = new System.Drawing.Point(0, 0);
            this.layoutnavegacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.layoutnavegacion.Name = "layoutnavegacion";
            this.layoutnavegacion.RowCount = 1;
            this.layoutnavegacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutnavegacion.Size = new System.Drawing.Size(393, 228);
            this.layoutnavegacion.TabIndex = 13;
            // 
            // layouttodascamaras
            // 
            this.layouttodascamaras.ColumnCount = 2;
            this.layouttodascamaras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.55393F));
            this.layouttodascamaras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.44607F));
            this.layouttodascamaras.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.layouttodascamaras.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.layouttodascamaras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layouttodascamaras.Location = new System.Drawing.Point(174, 2);
            this.layouttodascamaras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.layouttodascamaras.Name = "layouttodascamaras";
            this.layouttodascamaras.RowCount = 1;
            this.layouttodascamaras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layouttodascamaras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.layouttodascamaras.Size = new System.Drawing.Size(217, 224);
            this.layouttodascamaras.TabIndex = 13;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel14, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(107, 220);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 2;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Controls.Add(this.tableLayoutPanel11, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.tableLayoutPanel19, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(103, 216);
            this.tableLayoutPanel14.TabIndex = 14;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel12, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(2, 110);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(47, 104);
            this.tableLayoutPanel11.TabIndex = 20;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Controls.Add(this.pictureBox4, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.videoSourcePlayer4, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 3;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.79922F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.109873F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(43, 100);
            this.tableLayoutPanel12.TabIndex = 12;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(2, 89);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 1);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // videoSourcePlayer4
            // 
            this.videoSourcePlayer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.videoSourcePlayer4.Location = new System.Drawing.Point(2, 2);
            this.videoSourcePlayer4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.videoSourcePlayer4.Name = "videoSourcePlayer4";
            this.videoSourcePlayer4.Size = new System.Drawing.Size(39, 83);
            this.videoSourcePlayer4.TabIndex = 0;
            this.videoSourcePlayer4.Text = "videoSourcePlayer4";
            this.videoSourcePlayer4.VideoSource = null;
            this.videoSourcePlayer4.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer4_NewFrame);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(53, 110);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(48, 104);
            this.tableLayoutPanel8.TabIndex = 19;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.pictureBox3, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.videoSourcePlayer3, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.8F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.109091F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(44, 100);
            this.tableLayoutPanel9.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(2, 89);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 1);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // videoSourcePlayer3
            // 
            this.videoSourcePlayer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.videoSourcePlayer3.Location = new System.Drawing.Point(2, 2);
            this.videoSourcePlayer3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.videoSourcePlayer3.Name = "videoSourcePlayer3";
            this.videoSourcePlayer3.Size = new System.Drawing.Size(40, 83);
            this.videoSourcePlayer3.TabIndex = 0;
            this.videoSourcePlayer3.Text = "videoSourcePlayer3";
            this.videoSourcePlayer3.VideoSource = null;
            this.videoSourcePlayer3.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer3_NewFrame);
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 1;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.Controls.Add(this.tableLayoutPanel15, 0, 0);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel19.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 1;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(47, 104);
            this.tableLayoutPanel19.TabIndex = 14;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 1;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(43, 100);
            this.tableLayoutPanel15.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.videoSourcePlayer1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.79922F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.109873F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(39, 96);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(2, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 1);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(2, 2);
            this.videoSourcePlayer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(35, 80);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            this.videoSourcePlayer1.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer1_NewFrame_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(53, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(48, 104);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel13, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(44, 100);
            this.tableLayoutPanel10.TabIndex = 19;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Controls.Add(this.pictureBox5, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.videoSourcePlayer5, 0, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 3;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.79922F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.109873F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(40, 96);
            this.tableLayoutPanel13.TabIndex = 13;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Location = new System.Drawing.Point(2, 86);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 1);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // videoSourcePlayer5
            // 
            this.videoSourcePlayer5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.videoSourcePlayer5.Location = new System.Drawing.Point(2, 2);
            this.videoSourcePlayer5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.videoSourcePlayer5.Name = "videoSourcePlayer5";
            this.videoSourcePlayer5.Size = new System.Drawing.Size(36, 80);
            this.videoSourcePlayer5.TabIndex = 0;
            this.videoSourcePlayer5.Text = "videoSourcePlayer5";
            this.videoSourcePlayer5.VideoSource = null;
            this.videoSourcePlayer5.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer5_NewFrame);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(113, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(102, 220);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.pictureBox2, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.videoSourcePlayer2, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.79922F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.109873F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(98, 216);
            this.tableLayoutPanel6.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(2, 191);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 2);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // videoSourcePlayer2
            // 
            this.videoSourcePlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.videoSourcePlayer2.Location = new System.Drawing.Point(2, 2);
            this.videoSourcePlayer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.videoSourcePlayer2.Name = "videoSourcePlayer2";
            this.videoSourcePlayer2.Size = new System.Drawing.Size(94, 185);
            this.videoSourcePlayer2.TabIndex = 0;
            this.videoSourcePlayer2.Text = "videoSourcePlayer2";
            this.videoSourcePlayer2.VideoSource = null;
            this.videoSourcePlayer2.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer2_NewFrame_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.DesvincularTodo, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.Home, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cambioResolucion, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.button2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.Horario, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.Estrategia, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(168, 224);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // DesvincularTodo
            // 
            this.DesvincularTodo.BackColor = System.Drawing.Color.Black;
            this.DesvincularTodo.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.DesvincularTodo.FlatAppearance.BorderSize = 3;
            this.DesvincularTodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.DesvincularTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DesvincularTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesvincularTodo.ForeColor = System.Drawing.Color.Red;
            this.DesvincularTodo.Location = new System.Drawing.Point(2, 187);
            this.DesvincularTodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DesvincularTodo.Name = "DesvincularTodo";
            this.DesvincularTodo.Size = new System.Drawing.Size(164, 29);
            this.DesvincularTodo.TabIndex = 5;
            this.DesvincularTodo.Text = "PAUSAR";
            this.DesvincularTodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DesvincularTodo.UseVisualStyleBackColor = false;
            this.DesvincularTodo.Click += new System.EventHandler(this.DesvincularTodo_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Black;
            this.Home.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.Home.FlatAppearance.BorderSize = 3;
            this.Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.Lime;
            this.Home.Location = new System.Drawing.Point(2, 2);
            this.Home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(164, 32);
            this.Home.TabIndex = 1;
            this.Home.Text = "INICIO";
            this.Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // cambioResolucion
            // 
            this.cambioResolucion.BackColor = System.Drawing.Color.DarkOrange;
            this.cambioResolucion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cambioResolucion.FlatAppearance.BorderSize = 3;
            this.cambioResolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.cambioResolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cambioResolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambioResolucion.ForeColor = System.Drawing.Color.Black;
            this.cambioResolucion.Location = new System.Drawing.Point(2, 39);
            this.cambioResolucion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cambioResolucion.Name = "cambioResolucion";
            this.cambioResolucion.Size = new System.Drawing.Size(164, 32);
            this.cambioResolucion.TabIndex = 2;
            this.cambioResolucion.Text = "Resolución";
            this.cambioResolucion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cambioResolucion.UseVisualStyleBackColor = false;
            this.cambioResolucion.Click += new System.EventHandler(this.cambioResolucion_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(2, 76);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 32);
            this.button2.TabIndex = 3;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Horario
            // 
            this.Horario.BackColor = System.Drawing.Color.DarkOrange;
            this.Horario.Enabled = false;
            this.Horario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Horario.FlatAppearance.BorderSize = 3;
            this.Horario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.Horario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Horario.ForeColor = System.Drawing.Color.Black;
            this.Horario.Location = new System.Drawing.Point(2, 113);
            this.Horario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Horario.Name = "Horario";
            this.Horario.Size = new System.Drawing.Size(164, 32);
            this.Horario.TabIndex = 4;
            this.Horario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Horario.UseVisualStyleBackColor = false;
            this.Horario.Click += new System.EventHandler(this.button3_Click);
            // 
            // Estrategia
            // 
            this.Estrategia.BackColor = System.Drawing.Color.Black;
            this.Estrategia.Enabled = false;
            this.Estrategia.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Estrategia.FlatAppearance.BorderSize = 4;
            this.Estrategia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Estrategia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estrategia.ForeColor = System.Drawing.Color.Black;
            this.Estrategia.Location = new System.Drawing.Point(2, 150);
            this.Estrategia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Estrategia.Name = "Estrategia";
            this.Estrategia.Size = new System.Drawing.Size(164, 32);
            this.Estrategia.TabIndex = 0;
            this.Estrategia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Estrategia.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(393, 228);
            this.Controls.Add(this.layoutnavegacion);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(188, 267);
            this.Name = "Form1";
            this.Text = "MrT";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.layoutnavegacion.ResumeLayout(false);
            this.layouttodascamaras.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer DetecciondeMovimiento;
        private System.Windows.Forms.TableLayoutPanel layoutnavegacion;
        private System.Windows.Forms.TableLayoutPanel layouttodascamaras;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Estrategia;
        private System.Windows.Forms.Button DesvincularTodo;
        private System.Windows.Forms.Button cambioResolucion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Horario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.PictureBox pictureBox4;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer4;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.PictureBox pictureBox5;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer5;
        private System.Windows.Forms.Label label1;
    }
}

