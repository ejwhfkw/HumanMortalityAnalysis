namespace SurvivalAnalysis
{
    partial class MainForm
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.inputDataTableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hypothesisComboBox = new System.Windows.Forms.ComboBox();
            this.hypothesisLabel = new System.Windows.Forms.Label();
            this.ageGroupComboBox = new System.Windows.Forms.ComboBox();
            this.ageGroupLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.causeOfDeathComboBox = new System.Windows.Forms.ComboBox();
            this.ageGroupTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.annualInterpolatedAgeGroupRadioButton = new System.Windows.Forms.RadioButton();
            this.quinquennialAgeGroupRadioButton = new System.Windows.Forms.RadioButton();
            this.annualAgeGroupRadioButton = new System.Windows.Forms.RadioButton();
            this.territoryLabel = new System.Windows.Forms.Label();
            this.causeOfDeathLabel = new System.Windows.Forms.Label();
            this.settlementCategoryLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.territoryComboBox = new System.Windows.Forms.ComboBox();
            this.settlementCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.inputDataTableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.performSecondComputationalExperimentButton = new System.Windows.Forms.Button();
            this.calculateDataForNewbornLifeExpectancyPlotsButton = new System.Windows.Forms.Button();
            this.calculateDataForLifeExpectancyTableButton = new System.Windows.Forms.Button();
            this.calculateDataForMortalityTableButton = new System.Windows.Forms.Button();
            this.calculateDataForLifeExpectancyPlotsButton = new System.Windows.Forms.Button();
            this.performFirstComputationalExperimentButton = new System.Windows.Forms.Button();
            this.outputDataTabControl = new System.Windows.Forms.TabControl();
            this.mortalityTableTabPage = new System.Windows.Forms.TabPage();
            this.mortalityTableTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lifeExpectancyFormsPlot = new ScottPlot.FormsPlot();
            this.mortalityTableDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.survivalProbabilityFormsPlot = new ScottPlot.FormsPlot();
            this.lifeExpectancyTableTabPage = new System.Windows.Forms.TabPage();
            this.lifeExpectancyTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lifeExpectancyPlotsTabPage = new System.Windows.Forms.TabPage();
            this.plotsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lifeExpectancySurvivalFunctionFormsPlot = new ScottPlot.FormsPlot();
            this.lifeExpectancyDisctributionFunctionFormsPlot = new ScottPlot.FormsPlot();
            this.lifeExpectancyDistributionDensityFunctionFormsPlot = new ScottPlot.FormsPlot();
            this.lifeExpectancyRiskFunctionFormsPlot = new ScottPlot.FormsPlot();
            this.comparePlotsCheckBox = new System.Windows.Forms.CheckBox();
            this.computationalExperimentTabPage = new System.Windows.Forms.TabPage();
            this.computationalExperimentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.computationalExperimentFormsPlot = new ScottPlot.FormsPlot();
            this.computationalExperimentTextBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
            this.inputDataTableLayoutPanel1.SuspendLayout();
            this.ageGroupTypeGroupBox.SuspendLayout();
            this.inputDataTableLayoutPanel2.SuspendLayout();
            this.outputDataTabControl.SuspendLayout();
            this.mortalityTableTabPage.SuspendLayout();
            this.mortalityTableTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mortalityTableDataGridView)).BeginInit();
            this.lifeExpectancyTableTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lifeExpectancyTableDataGridView)).BeginInit();
            this.lifeExpectancyPlotsTabPage.SuspendLayout();
            this.plotsTableLayoutPanel.SuspendLayout();
            this.computationalExperimentTabPage.SuspendLayout();
            this.computationalExperimentTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.mainTableLayoutPanel.Controls.Add(this.inputDataTableLayoutPanel1, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.inputDataTableLayoutPanel2, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.outputDataTabControl, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.infoLabel, 0, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 402F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 342F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(1078, 809);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // inputDataTableLayoutPanel1
            // 
            this.inputDataTableLayoutPanel1.ColumnCount = 2;
            this.inputDataTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.inputDataTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.inputDataTableLayoutPanel1.Controls.Add(this.hypothesisComboBox, 1, 7);
            this.inputDataTableLayoutPanel1.Controls.Add(this.hypothesisLabel, 0, 7);
            this.inputDataTableLayoutPanel1.Controls.Add(this.ageGroupComboBox, 1, 6);
            this.inputDataTableLayoutPanel1.Controls.Add(this.ageGroupLabel, 0, 6);
            this.inputDataTableLayoutPanel1.Controls.Add(this.yearLabel, 0, 1);
            this.inputDataTableLayoutPanel1.Controls.Add(this.causeOfDeathComboBox, 1, 5);
            this.inputDataTableLayoutPanel1.Controls.Add(this.ageGroupTypeGroupBox, 0, 0);
            this.inputDataTableLayoutPanel1.Controls.Add(this.territoryLabel, 0, 2);
            this.inputDataTableLayoutPanel1.Controls.Add(this.causeOfDeathLabel, 0, 5);
            this.inputDataTableLayoutPanel1.Controls.Add(this.settlementCategoryLabel, 0, 3);
            this.inputDataTableLayoutPanel1.Controls.Add(this.sexLabel, 0, 4);
            this.inputDataTableLayoutPanel1.Controls.Add(this.yearComboBox, 1, 1);
            this.inputDataTableLayoutPanel1.Controls.Add(this.territoryComboBox, 1, 2);
            this.inputDataTableLayoutPanel1.Controls.Add(this.settlementCategoryComboBox, 1, 3);
            this.inputDataTableLayoutPanel1.Controls.Add(this.sexComboBox, 1, 4);
            this.inputDataTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputDataTableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.inputDataTableLayoutPanel1.Name = "inputDataTableLayoutPanel1";
            this.inputDataTableLayoutPanel1.RowCount = 8;
            this.inputDataTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.inputDataTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.inputDataTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.inputDataTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.inputDataTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.inputDataTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.inputDataTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.inputDataTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputDataTableLayoutPanel1.Size = new System.Drawing.Size(371, 396);
            this.inputDataTableLayoutPanel1.TabIndex = 0;
            // 
            // hypothesisComboBox
            // 
            this.hypothesisComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hypothesisComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hypothesisComboBox.FormattingEnabled = true;
            this.hypothesisComboBox.Location = new System.Drawing.Point(114, 359);
            this.hypothesisComboBox.Name = "hypothesisComboBox";
            this.hypothesisComboBox.Size = new System.Drawing.Size(254, 24);
            this.hypothesisComboBox.TabIndex = 16;
            // 
            // hypothesisLabel
            // 
            this.hypothesisLabel.AutoSize = true;
            this.hypothesisLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hypothesisLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hypothesisLabel.Location = new System.Drawing.Point(3, 356);
            this.hypothesisLabel.Name = "hypothesisLabel";
            this.hypothesisLabel.Size = new System.Drawing.Size(105, 40);
            this.hypothesisLabel.TabIndex = 15;
            this.hypothesisLabel.Text = "Предпол. для интерполяции";
            this.hypothesisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ageGroupComboBox
            // 
            this.ageGroupComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ageGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ageGroupComboBox.FormattingEnabled = true;
            this.ageGroupComboBox.Location = new System.Drawing.Point(114, 319);
            this.ageGroupComboBox.Name = "ageGroupComboBox";
            this.ageGroupComboBox.Size = new System.Drawing.Size(254, 24);
            this.ageGroupComboBox.TabIndex = 14;
            this.ageGroupComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // ageGroupLabel
            // 
            this.ageGroupLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ageGroupLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ageGroupLabel.Location = new System.Drawing.Point(3, 316);
            this.ageGroupLabel.Name = "ageGroupLabel";
            this.ageGroupLabel.Size = new System.Drawing.Size(105, 40);
            this.ageGroupLabel.TabIndex = 13;
            this.ageGroupLabel.Text = "Возрастная группа";
            this.ageGroupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearLabel
            // 
            this.yearLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yearLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yearLabel.Location = new System.Drawing.Point(3, 116);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(105, 40);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Год";
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // causeOfDeathComboBox
            // 
            this.causeOfDeathComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.causeOfDeathComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.causeOfDeathComboBox.DropDownWidth = 1000;
            this.causeOfDeathComboBox.FormattingEnabled = true;
            this.causeOfDeathComboBox.Location = new System.Drawing.Point(114, 279);
            this.causeOfDeathComboBox.Name = "causeOfDeathComboBox";
            this.causeOfDeathComboBox.Size = new System.Drawing.Size(254, 24);
            this.causeOfDeathComboBox.TabIndex = 12;
            this.causeOfDeathComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // ageGroupTypeGroupBox
            // 
            this.inputDataTableLayoutPanel1.SetColumnSpan(this.ageGroupTypeGroupBox, 2);
            this.ageGroupTypeGroupBox.Controls.Add(this.annualInterpolatedAgeGroupRadioButton);
            this.ageGroupTypeGroupBox.Controls.Add(this.quinquennialAgeGroupRadioButton);
            this.ageGroupTypeGroupBox.Controls.Add(this.annualAgeGroupRadioButton);
            this.ageGroupTypeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ageGroupTypeGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ageGroupTypeGroupBox.Name = "ageGroupTypeGroupBox";
            this.ageGroupTypeGroupBox.Size = new System.Drawing.Size(365, 110);
            this.ageGroupTypeGroupBox.TabIndex = 0;
            this.ageGroupTypeGroupBox.TabStop = false;
            this.ageGroupTypeGroupBox.Text = "Тип возрастных групп";
            // 
            // annualInterpolatedAgeGroupRadioButton
            // 
            this.annualInterpolatedAgeGroupRadioButton.AutoSize = true;
            this.annualInterpolatedAgeGroupRadioButton.Location = new System.Drawing.Point(10, 80);
            this.annualInterpolatedAgeGroupRadioButton.Name = "annualInterpolatedAgeGroupRadioButton";
            this.annualInterpolatedAgeGroupRadioButton.Size = new System.Drawing.Size(251, 21);
            this.annualInterpolatedAgeGroupRadioButton.TabIndex = 2;
            this.annualInterpolatedAgeGroupRadioButton.TabStop = true;
            this.annualInterpolatedAgeGroupRadioButton.Text = "Однолетние интерполированные";
            this.annualInterpolatedAgeGroupRadioButton.UseVisualStyleBackColor = true;
            this.annualInterpolatedAgeGroupRadioButton.CheckedChanged += new System.EventHandler(this.annualInterpolatedAgeGroupRadioButton_CheckedChanged);
            // 
            // quinquennialAgeGroupRadioButton
            // 
            this.quinquennialAgeGroupRadioButton.AutoSize = true;
            this.quinquennialAgeGroupRadioButton.Location = new System.Drawing.Point(10, 50);
            this.quinquennialAgeGroupRadioButton.Name = "quinquennialAgeGroupRadioButton";
            this.quinquennialAgeGroupRadioButton.Size = new System.Drawing.Size(109, 21);
            this.quinquennialAgeGroupRadioButton.TabIndex = 1;
            this.quinquennialAgeGroupRadioButton.TabStop = true;
            this.quinquennialAgeGroupRadioButton.Text = "Пятилетние";
            this.quinquennialAgeGroupRadioButton.UseVisualStyleBackColor = true;
            this.quinquennialAgeGroupRadioButton.CheckedChanged += new System.EventHandler(this.quinquennialAgeGroupRadioButton_CheckedChanged);
            // 
            // annualAgeGroupRadioButton
            // 
            this.annualAgeGroupRadioButton.AutoSize = true;
            this.annualAgeGroupRadioButton.Location = new System.Drawing.Point(10, 20);
            this.annualAgeGroupRadioButton.Name = "annualAgeGroupRadioButton";
            this.annualAgeGroupRadioButton.Size = new System.Drawing.Size(111, 21);
            this.annualAgeGroupRadioButton.TabIndex = 0;
            this.annualAgeGroupRadioButton.TabStop = true;
            this.annualAgeGroupRadioButton.Text = "Однолетние";
            this.annualAgeGroupRadioButton.UseVisualStyleBackColor = true;
            this.annualAgeGroupRadioButton.CheckedChanged += new System.EventHandler(this.annualAgeGroupRadioButton_CheckedChanged);
            // 
            // territoryLabel
            // 
            this.territoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.territoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.territoryLabel.Location = new System.Drawing.Point(3, 156);
            this.territoryLabel.Name = "territoryLabel";
            this.territoryLabel.Size = new System.Drawing.Size(105, 40);
            this.territoryLabel.TabIndex = 5;
            this.territoryLabel.Text = "Территория";
            this.territoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // causeOfDeathLabel
            // 
            this.causeOfDeathLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.causeOfDeathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.causeOfDeathLabel.Location = new System.Drawing.Point(3, 276);
            this.causeOfDeathLabel.Name = "causeOfDeathLabel";
            this.causeOfDeathLabel.Size = new System.Drawing.Size(105, 40);
            this.causeOfDeathLabel.TabIndex = 11;
            this.causeOfDeathLabel.Text = "Причина смерти";
            this.causeOfDeathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settlementCategoryLabel
            // 
            this.settlementCategoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settlementCategoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settlementCategoryLabel.Location = new System.Drawing.Point(3, 196);
            this.settlementCategoryLabel.Name = "settlementCategoryLabel";
            this.settlementCategoryLabel.Size = new System.Drawing.Size(105, 40);
            this.settlementCategoryLabel.TabIndex = 7;
            this.settlementCategoryLabel.Text = "Категория поселения";
            this.settlementCategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sexLabel
            // 
            this.sexLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sexLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sexLabel.Location = new System.Drawing.Point(3, 236);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(105, 40);
            this.sexLabel.TabIndex = 9;
            this.sexLabel.Text = "Пол";
            this.sexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearComboBox
            // 
            this.yearComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(114, 119);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(254, 24);
            this.yearComboBox.TabIndex = 4;
            this.yearComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // territoryComboBox
            // 
            this.territoryComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.territoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.territoryComboBox.DropDownWidth = 325;
            this.territoryComboBox.FormattingEnabled = true;
            this.territoryComboBox.Location = new System.Drawing.Point(114, 159);
            this.territoryComboBox.Name = "territoryComboBox";
            this.territoryComboBox.Size = new System.Drawing.Size(254, 24);
            this.territoryComboBox.TabIndex = 6;
            this.territoryComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // settlementCategoryComboBox
            // 
            this.settlementCategoryComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settlementCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settlementCategoryComboBox.FormattingEnabled = true;
            this.settlementCategoryComboBox.Location = new System.Drawing.Point(114, 199);
            this.settlementCategoryComboBox.Name = "settlementCategoryComboBox";
            this.settlementCategoryComboBox.Size = new System.Drawing.Size(254, 24);
            this.settlementCategoryComboBox.TabIndex = 8;
            this.settlementCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // sexComboBox
            // 
            this.sexComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Location = new System.Drawing.Point(114, 239);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(254, 24);
            this.sexComboBox.TabIndex = 10;
            this.sexComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // inputDataTableLayoutPanel2
            // 
            this.inputDataTableLayoutPanel2.ColumnCount = 1;
            this.inputDataTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputDataTableLayoutPanel2.Controls.Add(this.performSecondComputationalExperimentButton, 0, 5);
            this.inputDataTableLayoutPanel2.Controls.Add(this.calculateDataForNewbornLifeExpectancyPlotsButton, 0, 2);
            this.inputDataTableLayoutPanel2.Controls.Add(this.calculateDataForLifeExpectancyTableButton, 0, 1);
            this.inputDataTableLayoutPanel2.Controls.Add(this.calculateDataForMortalityTableButton, 0, 0);
            this.inputDataTableLayoutPanel2.Controls.Add(this.calculateDataForLifeExpectancyPlotsButton, 0, 3);
            this.inputDataTableLayoutPanel2.Controls.Add(this.performFirstComputationalExperimentButton, 0, 4);
            this.inputDataTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputDataTableLayoutPanel2.Location = new System.Drawing.Point(3, 405);
            this.inputDataTableLayoutPanel2.Name = "inputDataTableLayoutPanel2";
            this.inputDataTableLayoutPanel2.RowCount = 6;
            this.inputDataTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.inputDataTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.inputDataTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.inputDataTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.inputDataTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.inputDataTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputDataTableLayoutPanel2.Size = new System.Drawing.Size(371, 336);
            this.inputDataTableLayoutPanel2.TabIndex = 0;
            // 
            // performSecondComputationalExperimentButton
            // 
            this.performSecondComputationalExperimentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.performSecondComputationalExperimentButton.Location = new System.Drawing.Point(3, 283);
            this.performSecondComputationalExperimentButton.Name = "performSecondComputationalExperimentButton";
            this.performSecondComputationalExperimentButton.Size = new System.Drawing.Size(365, 50);
            this.performSecondComputationalExperimentButton.TabIndex = 22;
            this.performSecondComputationalExperimentButton.Text = "Подобрать предположение для интерполяции (вычислительный эксперимент №2)";
            this.performSecondComputationalExperimentButton.UseVisualStyleBackColor = true;
            this.performSecondComputationalExperimentButton.Click += new System.EventHandler(this.performSecondComputationalExperimentButton_Click);
            // 
            // calculateDataForNewbornLifeExpectancyPlotsButton
            // 
            this.calculateDataForNewbornLifeExpectancyPlotsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculateDataForNewbornLifeExpectancyPlotsButton.Location = new System.Drawing.Point(3, 115);
            this.calculateDataForNewbornLifeExpectancyPlotsButton.Name = "calculateDataForNewbornLifeExpectancyPlotsButton";
            this.calculateDataForNewbornLifeExpectancyPlotsButton.Size = new System.Drawing.Size(365, 50);
            this.calculateDataForNewbornLifeExpectancyPlotsButton.TabIndex = 19;
            this.calculateDataForNewbornLifeExpectancyPlotsButton.Text = "Построить графики функциональных характеристик продолжительности жизни новорожден" +
    "ного";
            this.calculateDataForNewbornLifeExpectancyPlotsButton.UseVisualStyleBackColor = true;
            this.calculateDataForNewbornLifeExpectancyPlotsButton.Click += new System.EventHandler(this.calculateDataForNewbornLifeExpectancyPlotsButton_Click);
            // 
            // calculateDataForLifeExpectancyTableButton
            // 
            this.calculateDataForLifeExpectancyTableButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculateDataForLifeExpectancyTableButton.Location = new System.Drawing.Point(3, 59);
            this.calculateDataForLifeExpectancyTableButton.Name = "calculateDataForLifeExpectancyTableButton";
            this.calculateDataForLifeExpectancyTableButton.Size = new System.Drawing.Size(365, 50);
            this.calculateDataForLifeExpectancyTableButton.TabIndex = 18;
            this.calculateDataForLifeExpectancyTableButton.Text = "Построить таблицу ожидаемой продолжительности предстоящей жизни человека по причи" +
    "нам смерти";
            this.calculateDataForLifeExpectancyTableButton.UseVisualStyleBackColor = true;
            this.calculateDataForLifeExpectancyTableButton.Click += new System.EventHandler(this.calculateDataForLifeExpectancyTableButton_Click);
            // 
            // calculateDataForMortalityTableButton
            // 
            this.calculateDataForMortalityTableButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculateDataForMortalityTableButton.Location = new System.Drawing.Point(3, 3);
            this.calculateDataForMortalityTableButton.Name = "calculateDataForMortalityTableButton";
            this.calculateDataForMortalityTableButton.Size = new System.Drawing.Size(365, 50);
            this.calculateDataForMortalityTableButton.TabIndex = 17;
            this.calculateDataForMortalityTableButton.Text = "Построить таблицу смертности";
            this.calculateDataForMortalityTableButton.UseVisualStyleBackColor = true;
            this.calculateDataForMortalityTableButton.Click += new System.EventHandler(this.calculateDataForMortalityTableButton_Click);
            // 
            // calculateDataForLifeExpectancyPlotsButton
            // 
            this.calculateDataForLifeExpectancyPlotsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculateDataForLifeExpectancyPlotsButton.Location = new System.Drawing.Point(3, 171);
            this.calculateDataForLifeExpectancyPlotsButton.Name = "calculateDataForLifeExpectancyPlotsButton";
            this.calculateDataForLifeExpectancyPlotsButton.Size = new System.Drawing.Size(365, 50);
            this.calculateDataForLifeExpectancyPlotsButton.TabIndex = 20;
            this.calculateDataForLifeExpectancyPlotsButton.Text = "Построить графики функциональных характеристик остаточной продолжительности жизни" +
    "";
            this.calculateDataForLifeExpectancyPlotsButton.UseVisualStyleBackColor = true;
            this.calculateDataForLifeExpectancyPlotsButton.Click += new System.EventHandler(this.calculateDataForLifeExpectancyPlotsButton_Click);
            // 
            // performFirstComputationalExperimentButton
            // 
            this.performFirstComputationalExperimentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.performFirstComputationalExperimentButton.Location = new System.Drawing.Point(3, 227);
            this.performFirstComputationalExperimentButton.Name = "performFirstComputationalExperimentButton";
            this.performFirstComputationalExperimentButton.Size = new System.Drawing.Size(365, 50);
            this.performFirstComputationalExperimentButton.TabIndex = 21;
            this.performFirstComputationalExperimentButton.Text = "Сравнить опытную таблицу смертности с эталонной (вычислительный эксперимент №1)";
            this.performFirstComputationalExperimentButton.UseVisualStyleBackColor = true;
            this.performFirstComputationalExperimentButton.Click += new System.EventHandler(this.performFirstComputationalExperimentButton_Click);
            // 
            // outputDataTabControl
            // 
            this.outputDataTabControl.Controls.Add(this.mortalityTableTabPage);
            this.outputDataTabControl.Controls.Add(this.lifeExpectancyTableTabPage);
            this.outputDataTabControl.Controls.Add(this.lifeExpectancyPlotsTabPage);
            this.outputDataTabControl.Controls.Add(this.computationalExperimentTabPage);
            this.outputDataTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputDataTabControl.Location = new System.Drawing.Point(380, 3);
            this.outputDataTabControl.Name = "outputDataTabControl";
            this.mainTableLayoutPanel.SetRowSpan(this.outputDataTabControl, 3);
            this.outputDataTabControl.SelectedIndex = 0;
            this.outputDataTabControl.Size = new System.Drawing.Size(695, 803);
            this.outputDataTabControl.TabIndex = 3;
            this.outputDataTabControl.TabStop = false;
            // 
            // mortalityTableTabPage
            // 
            this.mortalityTableTabPage.Controls.Add(this.mortalityTableTableLayoutPanel);
            this.mortalityTableTabPage.Location = new System.Drawing.Point(4, 25);
            this.mortalityTableTabPage.Name = "mortalityTableTabPage";
            this.mortalityTableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mortalityTableTabPage.Size = new System.Drawing.Size(687, 774);
            this.mortalityTableTabPage.TabIndex = 0;
            this.mortalityTableTabPage.Text = "Таблица смертности";
            this.mortalityTableTabPage.UseVisualStyleBackColor = true;
            // 
            // mortalityTableTableLayoutPanel
            // 
            this.mortalityTableTableLayoutPanel.ColumnCount = 2;
            this.mortalityTableTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mortalityTableTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mortalityTableTableLayoutPanel.Controls.Add(this.lifeExpectancyFormsPlot, 1, 1);
            this.mortalityTableTableLayoutPanel.Controls.Add(this.mortalityTableDataGridView, 0, 0);
            this.mortalityTableTableLayoutPanel.Controls.Add(this.survivalProbabilityFormsPlot, 0, 1);
            this.mortalityTableTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mortalityTableTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.mortalityTableTableLayoutPanel.Name = "mortalityTableTableLayoutPanel";
            this.mortalityTableTableLayoutPanel.RowCount = 2;
            this.mortalityTableTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mortalityTableTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mortalityTableTableLayoutPanel.Size = new System.Drawing.Size(681, 768);
            this.mortalityTableTableLayoutPanel.TabIndex = 1;
            // 
            // lifeExpectancyFormsPlot
            // 
            this.lifeExpectancyFormsPlot.BackColor = System.Drawing.Color.Transparent;
            this.lifeExpectancyFormsPlot.Dock = System.Windows.Forms.DockStyle.Top;
            this.lifeExpectancyFormsPlot.Location = new System.Drawing.Point(344, 460);
            this.lifeExpectancyFormsPlot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lifeExpectancyFormsPlot.Name = "lifeExpectancyFormsPlot";
            this.lifeExpectancyFormsPlot.Size = new System.Drawing.Size(333, 250);
            this.lifeExpectancyFormsPlot.TabIndex = 2;
            this.lifeExpectancyFormsPlot.TabStop = false;
            // 
            // mortalityTableDataGridView
            // 
            this.mortalityTableDataGridView.AllowUserToAddRows = false;
            this.mortalityTableDataGridView.AllowUserToDeleteRows = false;
            this.mortalityTableDataGridView.AllowUserToResizeRows = false;
            this.mortalityTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mortalityTableDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mortalityTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mortalityTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.mortalityTableTableLayoutPanel.SetColumnSpan(this.mortalityTableDataGridView, 2);
            this.mortalityTableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mortalityTableDataGridView.Location = new System.Drawing.Point(3, 3);
            this.mortalityTableDataGridView.Name = "mortalityTableDataGridView";
            this.mortalityTableDataGridView.ReadOnly = true;
            this.mortalityTableDataGridView.RowHeadersVisible = false;
            this.mortalityTableDataGridView.RowHeadersWidth = 51;
            this.mortalityTableDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mortalityTableDataGridView.RowTemplate.Height = 24;
            this.mortalityTableDataGridView.Size = new System.Drawing.Size(675, 450);
            this.mortalityTableDataGridView.TabIndex = 0;
            this.mortalityTableDataGridView.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "x";
            this.Column1.HeaderText = "x";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "lx_original";
            this.Column2.HeaderText = "lx исх.";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "lx";
            this.Column3.HeaderText = "lx";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "dx";
            this.Column4.HeaderText = "dx";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Lxxx";
            this.Column5.HeaderText = "Lx";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Tx";
            this.Column6.HeaderText = "Tx";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "px";
            this.Column7.HeaderText = "px";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "qx";
            this.Column8.HeaderText = "qx";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "ex";
            this.Column9.HeaderText = "ex";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // survivalProbabilityFormsPlot
            // 
            this.survivalProbabilityFormsPlot.BackColor = System.Drawing.Color.Transparent;
            this.survivalProbabilityFormsPlot.Dock = System.Windows.Forms.DockStyle.Top;
            this.survivalProbabilityFormsPlot.Location = new System.Drawing.Point(4, 460);
            this.survivalProbabilityFormsPlot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.survivalProbabilityFormsPlot.Name = "survivalProbabilityFormsPlot";
            this.survivalProbabilityFormsPlot.Size = new System.Drawing.Size(332, 250);
            this.survivalProbabilityFormsPlot.TabIndex = 1;
            this.survivalProbabilityFormsPlot.TabStop = false;
            // 
            // lifeExpectancyTableTabPage
            // 
            this.lifeExpectancyTableTabPage.Controls.Add(this.lifeExpectancyTableDataGridView);
            this.lifeExpectancyTableTabPage.Location = new System.Drawing.Point(4, 25);
            this.lifeExpectancyTableTabPage.Name = "lifeExpectancyTableTabPage";
            this.lifeExpectancyTableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.lifeExpectancyTableTabPage.Size = new System.Drawing.Size(687, 774);
            this.lifeExpectancyTableTabPage.TabIndex = 1;
            this.lifeExpectancyTableTabPage.Text = "Таблица ожидаемой продолжительности предстоящей жизни человека по причинам смерти" +
    "";
            this.lifeExpectancyTableTabPage.UseVisualStyleBackColor = true;
            // 
            // lifeExpectancyTableDataGridView
            // 
            this.lifeExpectancyTableDataGridView.AllowUserToAddRows = false;
            this.lifeExpectancyTableDataGridView.AllowUserToDeleteRows = false;
            this.lifeExpectancyTableDataGridView.AllowUserToResizeRows = false;
            this.lifeExpectancyTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lifeExpectancyTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lifeExpectancyTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.lifeExpectancyTableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lifeExpectancyTableDataGridView.Location = new System.Drawing.Point(3, 3);
            this.lifeExpectancyTableDataGridView.Name = "lifeExpectancyTableDataGridView";
            this.lifeExpectancyTableDataGridView.ReadOnly = true;
            this.lifeExpectancyTableDataGridView.RowHeadersVisible = false;
            this.lifeExpectancyTableDataGridView.RowHeadersWidth = 51;
            this.lifeExpectancyTableDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lifeExpectancyTableDataGridView.RowTemplate.Height = 24;
            this.lifeExpectancyTableDataGridView.Size = new System.Drawing.Size(681, 768);
            this.lifeExpectancyTableDataGridView.TabIndex = 0;
            this.lifeExpectancyTableDataGridView.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "НаименованиеПричиныСмерти";
            this.dataGridViewTextBoxColumn1.HeaderText = "Причина смерти";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "qx";
            this.dataGridViewTextBoxColumn2.HeaderText = "qx";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ex";
            this.dataGridViewTextBoxColumn3.HeaderText = "ex";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // lifeExpectancyPlotsTabPage
            // 
            this.lifeExpectancyPlotsTabPage.Controls.Add(this.plotsTableLayoutPanel);
            this.lifeExpectancyPlotsTabPage.Location = new System.Drawing.Point(4, 25);
            this.lifeExpectancyPlotsTabPage.Name = "lifeExpectancyPlotsTabPage";
            this.lifeExpectancyPlotsTabPage.Size = new System.Drawing.Size(687, 774);
            this.lifeExpectancyPlotsTabPage.TabIndex = 2;
            this.lifeExpectancyPlotsTabPage.Text = "Графики функциональных характеристик продолжительности жизни новорожденного";
            this.lifeExpectancyPlotsTabPage.UseVisualStyleBackColor = true;
            // 
            // plotsTableLayoutPanel
            // 
            this.plotsTableLayoutPanel.ColumnCount = 2;
            this.plotsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.plotsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.plotsTableLayoutPanel.Controls.Add(this.lifeExpectancySurvivalFunctionFormsPlot, 0, 1);
            this.plotsTableLayoutPanel.Controls.Add(this.lifeExpectancyDisctributionFunctionFormsPlot, 1, 1);
            this.plotsTableLayoutPanel.Controls.Add(this.lifeExpectancyDistributionDensityFunctionFormsPlot, 0, 2);
            this.plotsTableLayoutPanel.Controls.Add(this.lifeExpectancyRiskFunctionFormsPlot, 1, 2);
            this.plotsTableLayoutPanel.Controls.Add(this.comparePlotsCheckBox, 0, 0);
            this.plotsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.plotsTableLayoutPanel.Name = "plotsTableLayoutPanel";
            this.plotsTableLayoutPanel.RowCount = 3;
            this.plotsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.plotsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.plotsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.plotsTableLayoutPanel.Size = new System.Drawing.Size(687, 774);
            this.plotsTableLayoutPanel.TabIndex = 0;
            // 
            // lifeExpectancySurvivalFunctionFormsPlot
            // 
            this.lifeExpectancySurvivalFunctionFormsPlot.BackColor = System.Drawing.Color.Transparent;
            this.lifeExpectancySurvivalFunctionFormsPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lifeExpectancySurvivalFunctionFormsPlot.Location = new System.Drawing.Point(4, 44);
            this.lifeExpectancySurvivalFunctionFormsPlot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lifeExpectancySurvivalFunctionFormsPlot.Name = "lifeExpectancySurvivalFunctionFormsPlot";
            this.lifeExpectancySurvivalFunctionFormsPlot.Size = new System.Drawing.Size(335, 250);
            this.lifeExpectancySurvivalFunctionFormsPlot.TabIndex = 0;
            this.lifeExpectancySurvivalFunctionFormsPlot.TabStop = false;
            // 
            // lifeExpectancyDisctributionFunctionFormsPlot
            // 
            this.lifeExpectancyDisctributionFunctionFormsPlot.BackColor = System.Drawing.Color.Transparent;
            this.lifeExpectancyDisctributionFunctionFormsPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lifeExpectancyDisctributionFunctionFormsPlot.Location = new System.Drawing.Point(347, 44);
            this.lifeExpectancyDisctributionFunctionFormsPlot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lifeExpectancyDisctributionFunctionFormsPlot.Name = "lifeExpectancyDisctributionFunctionFormsPlot";
            this.lifeExpectancyDisctributionFunctionFormsPlot.Size = new System.Drawing.Size(336, 250);
            this.lifeExpectancyDisctributionFunctionFormsPlot.TabIndex = 0;
            this.lifeExpectancyDisctributionFunctionFormsPlot.TabStop = false;
            // 
            // lifeExpectancyDistributionDensityFunctionFormsPlot
            // 
            this.lifeExpectancyDistributionDensityFunctionFormsPlot.BackColor = System.Drawing.Color.Transparent;
            this.lifeExpectancyDistributionDensityFunctionFormsPlot.Dock = System.Windows.Forms.DockStyle.Top;
            this.lifeExpectancyDistributionDensityFunctionFormsPlot.Location = new System.Drawing.Point(4, 302);
            this.lifeExpectancyDistributionDensityFunctionFormsPlot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lifeExpectancyDistributionDensityFunctionFormsPlot.Name = "lifeExpectancyDistributionDensityFunctionFormsPlot";
            this.lifeExpectancyDistributionDensityFunctionFormsPlot.Size = new System.Drawing.Size(335, 250);
            this.lifeExpectancyDistributionDensityFunctionFormsPlot.TabIndex = 0;
            this.lifeExpectancyDistributionDensityFunctionFormsPlot.TabStop = false;
            // 
            // lifeExpectancyRiskFunctionFormsPlot
            // 
            this.lifeExpectancyRiskFunctionFormsPlot.BackColor = System.Drawing.Color.Transparent;
            this.lifeExpectancyRiskFunctionFormsPlot.Dock = System.Windows.Forms.DockStyle.Top;
            this.lifeExpectancyRiskFunctionFormsPlot.Location = new System.Drawing.Point(347, 302);
            this.lifeExpectancyRiskFunctionFormsPlot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lifeExpectancyRiskFunctionFormsPlot.Name = "lifeExpectancyRiskFunctionFormsPlot";
            this.lifeExpectancyRiskFunctionFormsPlot.Size = new System.Drawing.Size(336, 250);
            this.lifeExpectancyRiskFunctionFormsPlot.TabIndex = 0;
            this.lifeExpectancyRiskFunctionFormsPlot.TabStop = false;
            // 
            // comparePlotsCheckBox
            // 
            this.comparePlotsCheckBox.AutoSize = true;
            this.plotsTableLayoutPanel.SetColumnSpan(this.comparePlotsCheckBox, 2);
            this.comparePlotsCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comparePlotsCheckBox.Location = new System.Drawing.Point(3, 3);
            this.comparePlotsCheckBox.Name = "comparePlotsCheckBox";
            this.comparePlotsCheckBox.Size = new System.Drawing.Size(681, 34);
            this.comparePlotsCheckBox.TabIndex = 0;
            this.comparePlotsCheckBox.Text = "Добавить графики к сравнению";
            this.comparePlotsCheckBox.UseVisualStyleBackColor = true;
            // 
            // computationalExperimentTabPage
            // 
            this.computationalExperimentTabPage.Controls.Add(this.computationalExperimentTableLayoutPanel);
            this.computationalExperimentTabPage.Location = new System.Drawing.Point(4, 25);
            this.computationalExperimentTabPage.Name = "computationalExperimentTabPage";
            this.computationalExperimentTabPage.Size = new System.Drawing.Size(687, 774);
            this.computationalExperimentTabPage.TabIndex = 3;
            this.computationalExperimentTabPage.Text = "Вычислительный эксперимент";
            this.computationalExperimentTabPage.UseVisualStyleBackColor = true;
            // 
            // computationalExperimentTableLayoutPanel
            // 
            this.computationalExperimentTableLayoutPanel.ColumnCount = 1;
            this.computationalExperimentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.computationalExperimentTableLayoutPanel.Controls.Add(this.computationalExperimentFormsPlot, 0, 0);
            this.computationalExperimentTableLayoutPanel.Controls.Add(this.computationalExperimentTextBox, 0, 1);
            this.computationalExperimentTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computationalExperimentTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.computationalExperimentTableLayoutPanel.Name = "computationalExperimentTableLayoutPanel";
            this.computationalExperimentTableLayoutPanel.RowCount = 2;
            this.computationalExperimentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.computationalExperimentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.computationalExperimentTableLayoutPanel.Size = new System.Drawing.Size(687, 774);
            this.computationalExperimentTableLayoutPanel.TabIndex = 0;
            // 
            // computationalExperimentFormsPlot
            // 
            this.computationalExperimentFormsPlot.BackColor = System.Drawing.Color.Transparent;
            this.computationalExperimentFormsPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computationalExperimentFormsPlot.Location = new System.Drawing.Point(4, 4);
            this.computationalExperimentFormsPlot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.computationalExperimentFormsPlot.Name = "computationalExperimentFormsPlot";
            this.computationalExperimentFormsPlot.Size = new System.Drawing.Size(679, 456);
            this.computationalExperimentFormsPlot.TabIndex = 0;
            this.computationalExperimentFormsPlot.TabStop = false;
            // 
            // computationalExperimentTextBox
            // 
            this.computationalExperimentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computationalExperimentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.computationalExperimentTextBox.Location = new System.Drawing.Point(3, 467);
            this.computationalExperimentTextBox.Multiline = true;
            this.computationalExperimentTextBox.Name = "computationalExperimentTextBox";
            this.computationalExperimentTextBox.ReadOnly = true;
            this.computationalExperimentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.computationalExperimentTextBox.Size = new System.Drawing.Size(681, 304);
            this.computationalExperimentTextBox.TabIndex = 1;
            // 
            // infoLabel
            // 
            this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoLabel.Location = new System.Drawing.Point(3, 759);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(371, 50);
            this.infoLabel.TabIndex = 23;
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1078, 809);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программное обеспечение оценки и анализа показателей смертности населения России";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.inputDataTableLayoutPanel1.ResumeLayout(false);
            this.inputDataTableLayoutPanel1.PerformLayout();
            this.ageGroupTypeGroupBox.ResumeLayout(false);
            this.ageGroupTypeGroupBox.PerformLayout();
            this.inputDataTableLayoutPanel2.ResumeLayout(false);
            this.outputDataTabControl.ResumeLayout(false);
            this.mortalityTableTabPage.ResumeLayout(false);
            this.mortalityTableTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mortalityTableDataGridView)).EndInit();
            this.lifeExpectancyTableTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lifeExpectancyTableDataGridView)).EndInit();
            this.lifeExpectancyPlotsTabPage.ResumeLayout(false);
            this.plotsTableLayoutPanel.ResumeLayout(false);
            this.plotsTableLayoutPanel.PerformLayout();
            this.computationalExperimentTabPage.ResumeLayout(false);
            this.computationalExperimentTableLayoutPanel.ResumeLayout(false);
            this.computationalExperimentTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabPage lifeExpectancyPlotsTabPage;

        private System.Windows.Forms.TabPage lifeExpectancyTableTabPage;

        private System.Windows.Forms.TabPage mortalityTableTabPage;

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.DataGridView lifeExpectancyTableDataGridView;

        private System.Windows.Forms.TabControl outputDataTabControl;

        private System.Windows.Forms.ComboBox ageGroupComboBox;

        private System.Windows.Forms.Label ageGroupLabel;

        private System.Windows.Forms.TableLayoutPanel inputDataTableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel inputDataTableLayoutPanel2;

        private System.Windows.Forms.DataGridView mortalityTableDataGridView;

        private System.Windows.Forms.Button calculateDataForMortalityTableButton;

        private System.Windows.Forms.ComboBox causeOfDeathComboBox;

        private System.Windows.Forms.ComboBox settlementCategoryComboBox;
        private System.Windows.Forms.ComboBox sexComboBox;

        private System.Windows.Forms.ComboBox territoryComboBox;

        private System.Windows.Forms.ComboBox yearComboBox;

        private System.Windows.Forms.Label causeOfDeathLabel;

        private System.Windows.Forms.Label sexLabel;

        private System.Windows.Forms.Label settlementCategoryLabel;

        private System.Windows.Forms.Label territoryLabel;

        public System.Windows.Forms.Label yearLabel;

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;

        #endregion

        private System.Windows.Forms.TableLayoutPanel plotsTableLayoutPanel;
        private ScottPlot.FormsPlot lifeExpectancySurvivalFunctionFormsPlot;
        private System.Windows.Forms.Button calculateDataForLifeExpectancyPlotsButton;
        private System.Windows.Forms.Button calculateDataForNewbornLifeExpectancyPlotsButton;
        private ScottPlot.FormsPlot lifeExpectancyDisctributionFunctionFormsPlot;
        private ScottPlot.FormsPlot lifeExpectancyDistributionDensityFunctionFormsPlot;
        private ScottPlot.FormsPlot lifeExpectancyRiskFunctionFormsPlot;
        private System.Windows.Forms.Button calculateDataForLifeExpectancyTableButton;
        private System.Windows.Forms.TableLayoutPanel mortalityTableTableLayoutPanel;
        private ScottPlot.FormsPlot survivalProbabilityFormsPlot;
        private ScottPlot.FormsPlot lifeExpectancyFormsPlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.CheckBox comparePlotsCheckBox;
        private System.Windows.Forms.GroupBox ageGroupTypeGroupBox;
        private System.Windows.Forms.RadioButton quinquennialAgeGroupRadioButton;
        private System.Windows.Forms.RadioButton annualAgeGroupRadioButton;
        private System.Windows.Forms.Label hypothesisLabel;
        private System.Windows.Forms.ComboBox hypothesisComboBox;
        private System.Windows.Forms.RadioButton annualInterpolatedAgeGroupRadioButton;
        private System.Windows.Forms.Button performSecondComputationalExperimentButton;
        private System.Windows.Forms.TabPage computationalExperimentTabPage;
        private System.Windows.Forms.TableLayoutPanel computationalExperimentTableLayoutPanel;
        private ScottPlot.FormsPlot computationalExperimentFormsPlot;
        private System.Windows.Forms.TextBox computationalExperimentTextBox;
        private System.Windows.Forms.Button performFirstComputationalExperimentButton;
    }
}
