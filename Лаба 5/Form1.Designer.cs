namespace Лаба_5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGridViewFCFS = new System.Windows.Forms.DataGridView();
            this.NameProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExecutionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppearanceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSystemTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LostTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReactivityRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PenaltyRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OKButtonMFQ = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.MeanPenaltyRatioMFQ = new System.Windows.Forms.Label();
            this.MeanReactivityRatioMFQ = new System.Windows.Forms.Label();
            this.MeanLostTimeMFQ = new System.Windows.Forms.Label();
            this.MeanTotalSystemTimeMFQ = new System.Windows.Forms.Label();
            this.NumberProcessesMFQ = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RestrictionMFQ = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ProcessesListBoxMFQ = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MeanPenaltyRatioFCFS = new System.Windows.Forms.Label();
            this.MeanReactivityRatioFCFS = new System.Windows.Forms.Label();
            this.MeanLostTimeFCFS = new System.Windows.Forms.Label();
            this.MeanTotalSystemTimeFCFS = new System.Windows.Forms.Label();
            this.StartFCFSButton = new System.Windows.Forms.Button();
            this.OKButtonFCFS = new System.Windows.Forms.Button();
            this.NumberProcessesFCFS = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RestrictionFCFS = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ProcessesListBoxFCFS = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DataGridViewMFQ = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartMFQButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberQuanta_Q = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFCFS)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberProcessesMFQ)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestrictionMFQ)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberProcessesFCFS)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestrictionFCFS)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMFQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberQuanta_Q)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewFCFS
            // 
            this.DataGridViewFCFS.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGridViewFCFS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewFCFS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameProcess,
            this.ExecutionTime,
            this.AppearanceTime,
            this.TotalSystemTime,
            this.LostTime,
            this.ReactivityRatio,
            this.PenaltyRatio});
            this.DataGridViewFCFS.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGridViewFCFS.Location = new System.Drawing.Point(3, 3);
            this.DataGridViewFCFS.Name = "DataGridViewFCFS";
            this.DataGridViewFCFS.RowHeadersVisible = false;
            this.DataGridViewFCFS.Size = new System.Drawing.Size(847, 199);
            this.DataGridViewFCFS.TabIndex = 0;
            // 
            // NameProcess
            // 
            this.NameProcess.HeaderText = "Процесс";
            this.NameProcess.Name = "NameProcess";
            // 
            // ExecutionTime
            // 
            this.ExecutionTime.HeaderText = "Время выполнения";
            this.ExecutionTime.Name = "ExecutionTime";
            // 
            // AppearanceTime
            // 
            this.AppearanceTime.HeaderText = "Время появления";
            this.AppearanceTime.Name = "AppearanceTime";
            // 
            // TotalSystemTime
            // 
            this.TotalSystemTime.HeaderText = "Общее время в системе";
            this.TotalSystemTime.Name = "TotalSystemTime";
            // 
            // LostTime
            // 
            this.LostTime.HeaderText = "Потерянное время";
            this.LostTime.Name = "LostTime";
            // 
            // ReactivityRatio
            // 
            this.ReactivityRatio.HeaderText = "Отношение реактивности";
            this.ReactivityRatio.Name = "ReactivityRatio";
            // 
            // PenaltyRatio
            // 
            this.PenaltyRatio.HeaderText = "Штрафное отношение";
            this.PenaltyRatio.Name = "PenaltyRatio";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(861, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NumberQuanta_Q);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.StartMFQButton);
            this.tabPage1.Controls.Add(this.OKButtonMFQ);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.NumberProcessesMFQ);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(853, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MFQ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OKButtonMFQ
            // 
            this.OKButtonMFQ.Location = new System.Drawing.Point(294, 33);
            this.OKButtonMFQ.Name = "OKButtonMFQ";
            this.OKButtonMFQ.Size = new System.Drawing.Size(75, 23);
            this.OKButtonMFQ.TabIndex = 4;
            this.OKButtonMFQ.Text = "OK";
            this.OKButtonMFQ.UseVisualStyleBackColor = true;
            this.OKButtonMFQ.Click += new System.EventHandler(this.OKButtonMFQ_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.MeanPenaltyRatioMFQ);
            this.groupBox5.Controls.Add(this.MeanReactivityRatioMFQ);
            this.groupBox5.Controls.Add(this.MeanLostTimeMFQ);
            this.groupBox5.Controls.Add(this.MeanTotalSystemTimeMFQ);
            this.groupBox5.Location = new System.Drawing.Point(427, 192);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(420, 127);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Средние значения";
            // 
            // MeanPenaltyRatioMFQ
            // 
            this.MeanPenaltyRatioMFQ.AutoSize = true;
            this.MeanPenaltyRatioMFQ.Location = new System.Drawing.Point(6, 105);
            this.MeanPenaltyRatioMFQ.Name = "MeanPenaltyRatioMFQ";
            this.MeanPenaltyRatioMFQ.Size = new System.Drawing.Size(120, 13);
            this.MeanPenaltyRatioMFQ.TabIndex = 3;
            this.MeanPenaltyRatioMFQ.Text = "Штрафное отношение:";
            // 
            // MeanReactivityRatioMFQ
            // 
            this.MeanReactivityRatioMFQ.AutoSize = true;
            this.MeanReactivityRatioMFQ.Location = new System.Drawing.Point(6, 77);
            this.MeanReactivityRatioMFQ.Name = "MeanReactivityRatioMFQ";
            this.MeanReactivityRatioMFQ.Size = new System.Drawing.Size(140, 13);
            this.MeanReactivityRatioMFQ.TabIndex = 2;
            this.MeanReactivityRatioMFQ.Text = "Отношение реактивности:";
            // 
            // MeanLostTimeMFQ
            // 
            this.MeanLostTimeMFQ.AutoSize = true;
            this.MeanLostTimeMFQ.Location = new System.Drawing.Point(6, 52);
            this.MeanLostTimeMFQ.Name = "MeanLostTimeMFQ";
            this.MeanLostTimeMFQ.Size = new System.Drawing.Size(106, 13);
            this.MeanLostTimeMFQ.TabIndex = 1;
            this.MeanLostTimeMFQ.Text = "Потерянное время:";
            // 
            // MeanTotalSystemTimeMFQ
            // 
            this.MeanTotalSystemTimeMFQ.AutoSize = true;
            this.MeanTotalSystemTimeMFQ.Location = new System.Drawing.Point(6, 26);
            this.MeanTotalSystemTimeMFQ.Name = "MeanTotalSystemTimeMFQ";
            this.MeanTotalSystemTimeMFQ.Size = new System.Drawing.Size(253, 13);
            this.MeanTotalSystemTimeMFQ.TabIndex = 0;
            this.MeanTotalSystemTimeMFQ.Text = "Общее время прыбывания процесса в системе:";
            // 
            // NumberProcessesMFQ
            // 
            this.NumberProcessesMFQ.Location = new System.Drawing.Point(210, 18);
            this.NumberProcessesMFQ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberProcessesMFQ.Name = "NumberProcessesMFQ";
            this.NumberProcessesMFQ.Size = new System.Drawing.Size(53, 20);
            this.NumberProcessesMFQ.TabIndex = 1;
            this.NumberProcessesMFQ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RestrictionMFQ);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ProcessesListBoxMFQ);
            this.groupBox2.Location = new System.Drawing.Point(427, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 168);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Установите ограничение на максимальное время выполнения каждого процесса";
            // 
            // RestrictionMFQ
            // 
            this.RestrictionMFQ.Location = new System.Drawing.Point(220, 37);
            this.RestrictionMFQ.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RestrictionMFQ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RestrictionMFQ.Name = "RestrictionMFQ";
            this.RestrictionMFQ.Size = new System.Drawing.Size(53, 20);
            this.RestrictionMFQ.TabIndex = 5;
            this.RestrictionMFQ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ограничение";
            // 
            // ProcessesListBoxMFQ
            // 
            this.ProcessesListBoxMFQ.FormattingEnabled = true;
            this.ProcessesListBoxMFQ.Location = new System.Drawing.Point(6, 37);
            this.ProcessesListBoxMFQ.Name = "ProcessesListBoxMFQ";
            this.ProcessesListBoxMFQ.Size = new System.Drawing.Size(120, 121);
            this.ProcessesListBoxMFQ.TabIndex = 1;
            this.ProcessesListBoxMFQ.SelectedIndexChanged += new System.EventHandler(this.ProcessesListBoxMFQ_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество работающих процессов";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.StartFCFSButton);
            this.tabPage3.Controls.Add(this.OKButtonFCFS);
            this.tabPage3.Controls.Add(this.NumberProcessesFCFS);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(853, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "FCFS";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.MeanPenaltyRatioFCFS);
            this.groupBox4.Controls.Add(this.MeanReactivityRatioFCFS);
            this.groupBox4.Controls.Add(this.MeanLostTimeFCFS);
            this.groupBox4.Controls.Add(this.MeanTotalSystemTimeFCFS);
            this.groupBox4.Location = new System.Drawing.Point(425, 191);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(420, 127);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Средние значения";
            // 
            // MeanPenaltyRatioFCFS
            // 
            this.MeanPenaltyRatioFCFS.AutoSize = true;
            this.MeanPenaltyRatioFCFS.Location = new System.Drawing.Point(6, 105);
            this.MeanPenaltyRatioFCFS.Name = "MeanPenaltyRatioFCFS";
            this.MeanPenaltyRatioFCFS.Size = new System.Drawing.Size(120, 13);
            this.MeanPenaltyRatioFCFS.TabIndex = 3;
            this.MeanPenaltyRatioFCFS.Text = "Штрафное отношение:";
            // 
            // MeanReactivityRatioFCFS
            // 
            this.MeanReactivityRatioFCFS.AutoSize = true;
            this.MeanReactivityRatioFCFS.Location = new System.Drawing.Point(6, 77);
            this.MeanReactivityRatioFCFS.Name = "MeanReactivityRatioFCFS";
            this.MeanReactivityRatioFCFS.Size = new System.Drawing.Size(140, 13);
            this.MeanReactivityRatioFCFS.TabIndex = 2;
            this.MeanReactivityRatioFCFS.Text = "Отношение реактивности:";
            // 
            // MeanLostTimeFCFS
            // 
            this.MeanLostTimeFCFS.AutoSize = true;
            this.MeanLostTimeFCFS.Location = new System.Drawing.Point(6, 52);
            this.MeanLostTimeFCFS.Name = "MeanLostTimeFCFS";
            this.MeanLostTimeFCFS.Size = new System.Drawing.Size(106, 13);
            this.MeanLostTimeFCFS.TabIndex = 1;
            this.MeanLostTimeFCFS.Text = "Потерянное время:";
            // 
            // MeanTotalSystemTimeFCFS
            // 
            this.MeanTotalSystemTimeFCFS.AutoSize = true;
            this.MeanTotalSystemTimeFCFS.Location = new System.Drawing.Point(6, 26);
            this.MeanTotalSystemTimeFCFS.Name = "MeanTotalSystemTimeFCFS";
            this.MeanTotalSystemTimeFCFS.Size = new System.Drawing.Size(253, 13);
            this.MeanTotalSystemTimeFCFS.TabIndex = 0;
            this.MeanTotalSystemTimeFCFS.Text = "Общее время прыбывания процесса в системе:";
            // 
            // StartFCFSButton
            // 
            this.StartFCFSButton.Location = new System.Drawing.Point(11, 116);
            this.StartFCFSButton.Name = "StartFCFSButton";
            this.StartFCFSButton.Size = new System.Drawing.Size(202, 58);
            this.StartFCFSButton.TabIndex = 8;
            this.StartFCFSButton.Text = "Запустить алгоритм";
            this.StartFCFSButton.UseVisualStyleBackColor = true;
            this.StartFCFSButton.Click += new System.EventHandler(this.StartFCFSButton_Click);
            // 
            // OKButtonFCFS
            // 
            this.OKButtonFCFS.Location = new System.Drawing.Point(285, 20);
            this.OKButtonFCFS.Name = "OKButtonFCFS";
            this.OKButtonFCFS.Size = new System.Drawing.Size(75, 23);
            this.OKButtonFCFS.TabIndex = 7;
            this.OKButtonFCFS.Text = "OK";
            this.OKButtonFCFS.UseVisualStyleBackColor = true;
            this.OKButtonFCFS.Click += new System.EventHandler(this.OKButtonFCFS_Click);
            // 
            // NumberProcessesFCFS
            // 
            this.NumberProcessesFCFS.Location = new System.Drawing.Point(212, 20);
            this.NumberProcessesFCFS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberProcessesFCFS.Name = "NumberProcessesFCFS";
            this.NumberProcessesFCFS.Size = new System.Drawing.Size(53, 20);
            this.NumberProcessesFCFS.TabIndex = 6;
            this.NumberProcessesFCFS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Количество работающих процессов";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RestrictionFCFS);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ProcessesListBoxFCFS);
            this.groupBox3.Location = new System.Drawing.Point(425, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 168);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Установите ограничение на максимальное время выполнения каждого процесса";
            // 
            // RestrictionFCFS
            // 
            this.RestrictionFCFS.Location = new System.Drawing.Point(220, 37);
            this.RestrictionFCFS.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RestrictionFCFS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RestrictionFCFS.Name = "RestrictionFCFS";
            this.RestrictionFCFS.Size = new System.Drawing.Size(53, 20);
            this.RestrictionFCFS.TabIndex = 5;
            this.RestrictionFCFS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ограничение";
            // 
            // ProcessesListBoxFCFS
            // 
            this.ProcessesListBoxFCFS.FormattingEnabled = true;
            this.ProcessesListBoxFCFS.Location = new System.Drawing.Point(6, 37);
            this.ProcessesListBoxFCFS.Name = "ProcessesListBoxFCFS";
            this.ProcessesListBoxFCFS.Size = new System.Drawing.Size(120, 121);
            this.ProcessesListBoxFCFS.TabIndex = 1;
            this.ProcessesListBoxFCFS.SelectedIndexChanged += new System.EventHandler(this.ProcessesListBoxFCFS_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DataGridViewMFQ);
            this.tabPage2.Controls.Add(this.DataGridViewFCFS);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(853, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Результаты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DataGridViewMFQ
            // 
            this.DataGridViewMFQ.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGridViewMFQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMFQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.DataGridViewMFQ.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridViewMFQ.Location = new System.Drawing.Point(3, 208);
            this.DataGridViewMFQ.Name = "DataGridViewMFQ";
            this.DataGridViewMFQ.RowHeadersVisible = false;
            this.DataGridViewMFQ.Size = new System.Drawing.Size(847, 213);
            this.DataGridViewMFQ.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Процесс";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Время выполнения";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Время появления";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Общее время в системе";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Потерянное время";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Отношение реактивности";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Штрафное отношение";
            this.Column8.Name = "Column8";
            // 
            // StartMFQButton
            // 
            this.StartMFQButton.Location = new System.Drawing.Point(9, 116);
            this.StartMFQButton.Name = "StartMFQButton";
            this.StartMFQButton.Size = new System.Drawing.Size(202, 58);
            this.StartMFQButton.TabIndex = 11;
            this.StartMFQButton.Text = "Запустить алгоритм";
            this.StartMFQButton.UseVisualStyleBackColor = true;
            this.StartMFQButton.Click += new System.EventHandler(this.StartMFQButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Количество квантов Q";
            // 
            // NumberQuanta_Q
            // 
            this.NumberQuanta_Q.Location = new System.Drawing.Point(210, 50);
            this.NumberQuanta_Q.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumberQuanta_Q.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberQuanta_Q.Name = "NumberQuanta_Q";
            this.NumberQuanta_Q.Size = new System.Drawing.Size(53, 20);
            this.NumberQuanta_Q.TabIndex = 13;
            this.NumberQuanta_Q.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Алгоритмы планирования";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFCFS)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberProcessesMFQ)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestrictionMFQ)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberProcessesFCFS)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestrictionFCFS)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMFQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberQuanta_Q)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewFCFS;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown RestrictionMFQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ProcessesListBoxMFQ;
        private System.Windows.Forms.Button OKButtonMFQ;
        private System.Windows.Forms.NumericUpDown NumberProcessesMFQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button OKButtonFCFS;
        private System.Windows.Forms.NumericUpDown NumberProcessesFCFS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown RestrictionFCFS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ProcessesListBoxFCFS;
        private System.Windows.Forms.Button StartFCFSButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExecutionTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppearanceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSystemTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LostTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReactivityRatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PenaltyRatio;
        private System.Windows.Forms.DataGridView DataGridViewMFQ;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label MeanPenaltyRatioFCFS;
        private System.Windows.Forms.Label MeanReactivityRatioFCFS;
        private System.Windows.Forms.Label MeanLostTimeFCFS;
        private System.Windows.Forms.Label MeanTotalSystemTimeFCFS;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label MeanPenaltyRatioMFQ;
        private System.Windows.Forms.Label MeanReactivityRatioMFQ;
        private System.Windows.Forms.Label MeanLostTimeMFQ;
        private System.Windows.Forms.Label MeanTotalSystemTimeMFQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button StartMFQButton;
        private System.Windows.Forms.NumericUpDown NumberQuanta_Q;
        private System.Windows.Forms.Label label2;
    }
}

