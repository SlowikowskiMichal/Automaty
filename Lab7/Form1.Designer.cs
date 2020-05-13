using System;
using System.Windows.Forms;

namespace Lab7
{
    partial class Automat2D
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridPanel = new System.Windows.Forms.Panel();
            this.gridPictureBox = new System.Windows.Forms.PictureBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.gridOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.xCellTextBox = new System.Windows.Forms.TextBox();
            this.yCellTextBox = new System.Windows.Forms.TextBox();
            this.xNumberLabel = new System.Windows.Forms.Label();
            this.yNumberLabel = new System.Windows.Forms.Label();
            this.resizeGridButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.executionGroupBox = new System.Windows.Forms.GroupBox();
            this.modeExecutionGroupBox = new System.Windows.Forms.GroupBox();
            this.circleModeExecutionRadioButton = new System.Windows.Forms.RadioButton();
            this.squareModeExecutionRadioButton = new System.Windows.Forms.RadioButton();
            this.nextStepCAButton = new System.Windows.Forms.Button();
            this.stopCAButton = new System.Windows.Forms.Button();
            this.runCAButton = new System.Windows.Forms.Button();
            this.gridViewGroupBox = new System.Windows.Forms.GroupBox();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.gridCheckBox = new System.Windows.Forms.CheckBox();
            this.simulationOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.nucleonAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.currentNucleonIdValueLabel = new System.Windows.Forms.Label();
            this.currenNucleonTextLabel = new System.Windows.Forms.Label();
            this.nucleonAmountLabel = new System.Windows.Forms.Label();
            this.NeighborhoodCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.randomThresholdTextBox = new System.Windows.Forms.TextBox();
            this.randomThresholdLabel = new System.Windows.Forms.Label();
            this.randomNeighborhoodLabel = new System.Windows.Forms.Label();
            this.boundaryLabel = new System.Windows.Forms.Label();
            this.boundaryComboBox = new System.Windows.Forms.ComboBox();
            this.neighborhoodLabel = new System.Windows.Forms.Label();
            this.randomNeighborhoodComboBox = new System.Windows.Forms.ComboBox();
            this.executionButtonsPanel = new System.Windows.Forms.Panel();
            this.classicExecutionOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.rectangleExecutionOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.rotationRectLabel = new System.Windows.Forms.Label();
            this.rotationRectNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ratioRectLabel = new System.Windows.Forms.Label();
            this.ratioFirstRectNumeric = new System.Windows.Forms.NumericUpDown();
            this.ratioSecondRectNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.gridOptionsGroupBox.SuspendLayout();
            this.executionGroupBox.SuspendLayout();
            this.modeExecutionGroupBox.SuspendLayout();
            this.gridViewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            this.simulationOptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nucleonAmountNumericUpDown)).BeginInit();
            this.executionButtonsPanel.SuspendLayout();
            this.rectangleExecutionOptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationRectNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratioFirstRectNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratioSecondRectNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPanel
            // 
            this.gridPanel.AutoScroll = true;
            this.gridPanel.Controls.Add(this.gridPictureBox);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel.Location = new System.Drawing.Point(0, 0);
            this.gridPanel.Margin = new System.Windows.Forms.Padding(4);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(816, 871);
            this.gridPanel.TabIndex = 0;
            // 
            // gridPictureBox
            // 
            this.gridPictureBox.Location = new System.Drawing.Point(4, 4);
            this.gridPictureBox.Name = "gridPictureBox";
            this.gridPictureBox.Size = new System.Drawing.Size(528, 424);
            this.gridPictureBox.TabIndex = 0;
            this.gridPictureBox.TabStop = false;
            this.gridPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridPictureBox_MouseDown_1);
            this.gridPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridPictureBox_MouseDown);
            this.gridPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridPictureBox_MouseUp);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.gridPanel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.settingsPanel);
            this.splitContainer.Size = new System.Drawing.Size(1131, 871);
            this.splitContainer.SplitterDistance = 816;
            this.splitContainer.TabIndex = 58;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.executionGroupBox);
            this.settingsPanel.Controls.Add(this.simulationOptionsGroupBox);
            this.settingsPanel.Controls.Add(this.gridOptionsGroupBox);
            this.settingsPanel.Controls.Add(this.gridViewGroupBox);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(311, 871);
            this.settingsPanel.TabIndex = 58;
            // 
            // gridOptionsGroupBox
            // 
            this.gridOptionsGroupBox.Controls.Add(this.xCellTextBox);
            this.gridOptionsGroupBox.Controls.Add(this.yCellTextBox);
            this.gridOptionsGroupBox.Controls.Add(this.xNumberLabel);
            this.gridOptionsGroupBox.Controls.Add(this.yNumberLabel);
            this.gridOptionsGroupBox.Controls.Add(this.resizeGridButton);
            this.gridOptionsGroupBox.Controls.Add(this.clearButton);
            this.gridOptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridOptionsGroupBox.Location = new System.Drawing.Point(0, 121);
            this.gridOptionsGroupBox.Name = "gridOptionsGroupBox";
            this.gridOptionsGroupBox.Size = new System.Drawing.Size(311, 116);
            this.gridOptionsGroupBox.TabIndex = 52;
            this.gridOptionsGroupBox.TabStop = false;
            this.gridOptionsGroupBox.Text = "Opcje siatki";
            // 
            // xCellTextBox
            // 
            this.xCellTextBox.Location = new System.Drawing.Point(126, 15);
            this.xCellTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.xCellTextBox.Name = "xCellTextBox";
            this.xCellTextBox.Size = new System.Drawing.Size(132, 22);
            this.xCellTextBox.TabIndex = 47;
            // 
            // yCellTextBox
            // 
            this.yCellTextBox.Location = new System.Drawing.Point(126, 47);
            this.yCellTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.yCellTextBox.Name = "yCellTextBox";
            this.yCellTextBox.Size = new System.Drawing.Size(132, 22);
            this.yCellTextBox.TabIndex = 48;
            // 
            // xNumberLabel
            // 
            this.xNumberLabel.AutoSize = true;
            this.xNumberLabel.Location = new System.Drawing.Point(58, 18);
            this.xNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xNumberLabel.Name = "xNumberLabel";
            this.xNumberLabel.Size = new System.Drawing.Size(62, 17);
            this.xNumberLabel.TabIndex = 50;
            this.xNumberLabel.Text = "Kolumny";
            // 
            // yNumberLabel
            // 
            this.yNumberLabel.AutoSize = true;
            this.yNumberLabel.Location = new System.Drawing.Point(58, 50);
            this.yNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yNumberLabel.Name = "yNumberLabel";
            this.yNumberLabel.Size = new System.Drawing.Size(59, 17);
            this.yNumberLabel.TabIndex = 49;
            this.yNumberLabel.Text = "Wiersze";
            // 
            // resizeGridButton
            // 
            this.resizeGridButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resizeGridButton.Location = new System.Drawing.Point(69, 77);
            this.resizeGridButton.Margin = new System.Windows.Forms.Padding(4);
            this.resizeGridButton.Name = "resizeGridButton";
            this.resizeGridButton.Size = new System.Drawing.Size(100, 28);
            this.resizeGridButton.TabIndex = 35;
            this.resizeGridButton.Text = "Zmień Rozmiar";
            this.resizeGridButton.UseVisualStyleBackColor = true;
            this.resizeGridButton.Click += new System.EventHandler(this.resizeGridButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearButton.Location = new System.Drawing.Point(177, 77);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 28);
            this.clearButton.TabIndex = 46;
            this.clearButton.Text = "Wyczyść";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // executionGroupBox
            // 
            this.executionGroupBox.AutoSize = true;
            this.executionGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.executionGroupBox.Controls.Add(this.executionButtonsPanel);
            this.executionGroupBox.Controls.Add(this.rectangleExecutionOptionsGroupBox);
            this.executionGroupBox.Controls.Add(this.classicExecutionOptionsGroupBox);
            this.executionGroupBox.Controls.Add(this.modeExecutionGroupBox);
            this.executionGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.executionGroupBox.Location = new System.Drawing.Point(0, 544);
            this.executionGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.executionGroupBox.Name = "executionGroupBox";
            this.executionGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.executionGroupBox.Size = new System.Drawing.Size(311, 342);
            this.executionGroupBox.TabIndex = 56;
            this.executionGroupBox.TabStop = false;
            this.executionGroupBox.Text = "Egzekucja";
            // 
            // modeExecutionGroupBox
            // 
            this.modeExecutionGroupBox.Controls.Add(this.circleModeExecutionRadioButton);
            this.modeExecutionGroupBox.Controls.Add(this.squareModeExecutionRadioButton);
            this.modeExecutionGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.modeExecutionGroupBox.Location = new System.Drawing.Point(4, 19);
            this.modeExecutionGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.modeExecutionGroupBox.Name = "modeExecutionGroupBox";
            this.modeExecutionGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.modeExecutionGroupBox.Size = new System.Drawing.Size(303, 56);
            this.modeExecutionGroupBox.TabIndex = 57;
            this.modeExecutionGroupBox.TabStop = false;
            this.modeExecutionGroupBox.Text = "Tryb rozrostu";
            // 
            // circleModeExecutionRadioButton
            // 
            this.circleModeExecutionRadioButton.AutoSize = true;
            this.circleModeExecutionRadioButton.Location = new System.Drawing.Point(140, 22);
            this.circleModeExecutionRadioButton.Name = "circleModeExecutionRadioButton";
            this.circleModeExecutionRadioButton.Size = new System.Drawing.Size(73, 21);
            this.circleModeExecutionRadioButton.TabIndex = 18;
            this.circleModeExecutionRadioButton.TabStop = true;
            this.circleModeExecutionRadioButton.Text = "Kołowy";
            this.circleModeExecutionRadioButton.UseVisualStyleBackColor = true;
            // 
            // squareModeExecutionRadioButton
            // 
            this.squareModeExecutionRadioButton.AutoSize = true;
            this.squareModeExecutionRadioButton.Location = new System.Drawing.Point(8, 22);
            this.squareModeExecutionRadioButton.Name = "squareModeExecutionRadioButton";
            this.squareModeExecutionRadioButton.Size = new System.Drawing.Size(104, 21);
            this.squareModeExecutionRadioButton.TabIndex = 17;
            this.squareModeExecutionRadioButton.TabStop = true;
            this.squareModeExecutionRadioButton.Text = "Prostokątny";
            this.squareModeExecutionRadioButton.UseVisualStyleBackColor = true;
            this.squareModeExecutionRadioButton.CheckedChanged += new System.EventHandler(this.executionModeRadioButton_CheckedChanged);
            // 
            // nextStepCAButton
            // 
            this.nextStepCAButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.nextStepCAButton.Location = new System.Drawing.Point(200, 0);
            this.nextStepCAButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextStepCAButton.Name = "nextStepCAButton";
            this.nextStepCAButton.Size = new System.Drawing.Size(100, 63);
            this.nextStepCAButton.TabIndex = 16;
            this.nextStepCAButton.Text = "Następny\r\nKrok";
            this.nextStepCAButton.UseVisualStyleBackColor = true;
            this.nextStepCAButton.Click += new System.EventHandler(this.nextStepCAButton_Click);
            // 
            // stopCAButton
            // 
            this.stopCAButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.stopCAButton.Location = new System.Drawing.Point(100, 0);
            this.stopCAButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopCAButton.Name = "stopCAButton";
            this.stopCAButton.Size = new System.Drawing.Size(100, 63);
            this.stopCAButton.TabIndex = 16;
            this.stopCAButton.Text = "Stop";
            this.stopCAButton.UseVisualStyleBackColor = true;
            this.stopCAButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // runCAButton
            // 
            this.runCAButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.runCAButton.Location = new System.Drawing.Point(0, 0);
            this.runCAButton.Margin = new System.Windows.Forms.Padding(4);
            this.runCAButton.Name = "runCAButton";
            this.runCAButton.Size = new System.Drawing.Size(100, 63);
            this.runCAButton.TabIndex = 16;
            this.runCAButton.Text = "Start";
            this.runCAButton.UseVisualStyleBackColor = true;
            this.runCAButton.Click += new System.EventHandler(this.runCAButton_Click);
            // 
            // gridViewGroupBox
            // 
            this.gridViewGroupBox.Controls.Add(this.zoomTrackBar);
            this.gridViewGroupBox.Controls.Add(this.zoomLabel);
            this.gridViewGroupBox.Controls.Add(this.gridCheckBox);
            this.gridViewGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridViewGroupBox.Location = new System.Drawing.Point(0, 0);
            this.gridViewGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewGroupBox.Name = "gridViewGroupBox";
            this.gridViewGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.gridViewGroupBox.Size = new System.Drawing.Size(311, 121);
            this.gridViewGroupBox.TabIndex = 57;
            this.gridViewGroupBox.TabStop = false;
            this.gridViewGroupBox.Text = "Widok siatki";
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.LargeChange = 10;
            this.zoomTrackBar.Location = new System.Drawing.Point(91, 25);
            this.zoomTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.zoomTrackBar.Maximum = 15;
            this.zoomTrackBar.Minimum = 1;
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Size = new System.Drawing.Size(139, 56);
            this.zoomTrackBar.SmallChange = 10;
            this.zoomTrackBar.TabIndex = 36;
            this.zoomTrackBar.TickFrequency = 0;
            this.zoomTrackBar.Value = 8;
            this.zoomTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zoomTrackBar_MouseUp);
            // 
            // zoomLabel
            // 
            this.zoomLabel.AutoSize = true;
            this.zoomLabel.Location = new System.Drawing.Point(44, 36);
            this.zoomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(48, 17);
            this.zoomLabel.TabIndex = 48;
            this.zoomLabel.Text = "Zoom:";
            // 
            // gridCheckBox
            // 
            this.gridCheckBox.AutoSize = true;
            this.gridCheckBox.Location = new System.Drawing.Point(47, 89);
            this.gridCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.gridCheckBox.Name = "gridCheckBox";
            this.gridCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridCheckBox.Size = new System.Drawing.Size(122, 21);
            this.gridCheckBox.TabIndex = 47;
            this.gridCheckBox.Text = "Generuj siatkę";
            this.gridCheckBox.UseVisualStyleBackColor = true;
            this.gridCheckBox.CheckedChanged += new System.EventHandler(this.gridCheckBox_CheckedChanged);
            // 
            // simulationOptionsGroupBox
            // 
            this.simulationOptionsGroupBox.Controls.Add(this.nucleonAmountNumericUpDown);
            this.simulationOptionsGroupBox.Controls.Add(this.currentNucleonIdValueLabel);
            this.simulationOptionsGroupBox.Controls.Add(this.currenNucleonTextLabel);
            this.simulationOptionsGroupBox.Controls.Add(this.nucleonAmountLabel);
            this.simulationOptionsGroupBox.Controls.Add(this.NeighborhoodCheckedListBox);
            this.simulationOptionsGroupBox.Controls.Add(this.randomThresholdTextBox);
            this.simulationOptionsGroupBox.Controls.Add(this.randomThresholdLabel);
            this.simulationOptionsGroupBox.Controls.Add(this.randomNeighborhoodLabel);
            this.simulationOptionsGroupBox.Controls.Add(this.boundaryLabel);
            this.simulationOptionsGroupBox.Controls.Add(this.boundaryComboBox);
            this.simulationOptionsGroupBox.Controls.Add(this.neighborhoodLabel);
            this.simulationOptionsGroupBox.Controls.Add(this.randomNeighborhoodComboBox);
            this.simulationOptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.simulationOptionsGroupBox.Location = new System.Drawing.Point(0, 237);
            this.simulationOptionsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.simulationOptionsGroupBox.Name = "simulationOptionsGroupBox";
            this.simulationOptionsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.simulationOptionsGroupBox.Size = new System.Drawing.Size(311, 307);
            this.simulationOptionsGroupBox.TabIndex = 56;
            this.simulationOptionsGroupBox.TabStop = false;
            this.simulationOptionsGroupBox.Text = "Opcje symulacji";
            // 
            // nucleonAmountNumericUpDown
            // 
            this.nucleonAmountNumericUpDown.Location = new System.Drawing.Point(131, 231);
            this.nucleonAmountNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nucleonAmountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nucleonAmountNumericUpDown.Name = "nucleonAmountNumericUpDown";
            this.nucleonAmountNumericUpDown.Size = new System.Drawing.Size(144, 22);
            this.nucleonAmountNumericUpDown.TabIndex = 55;
            this.nucleonAmountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nucleonAmountNumericUpDown.ValueChanged += new System.EventHandler(this.nucleonAmountNumericUpDown_ValueChanged);
            // 
            // currentNucleonIdValueLabel
            // 
            this.currentNucleonIdValueLabel.AutoSize = true;
            this.currentNucleonIdValueLabel.Location = new System.Drawing.Point(196, 264);
            this.currentNucleonIdValueLabel.Name = "currentNucleonIdValueLabel";
            this.currentNucleonIdValueLabel.Size = new System.Drawing.Size(16, 17);
            this.currentNucleonIdValueLabel.TabIndex = 54;
            this.currentNucleonIdValueLabel.Text = "0";
            // 
            // currenNucleonTextLabel
            // 
            this.currenNucleonTextLabel.AutoSize = true;
            this.currenNucleonTextLabel.Location = new System.Drawing.Point(20, 264);
            this.currenNucleonTextLabel.Name = "currenNucleonTextLabel";
            this.currenNucleonTextLabel.Size = new System.Drawing.Size(148, 17);
            this.currenNucleonTextLabel.TabIndex = 53;
            this.currenNucleonTextLabel.Text = "Obecny numer ziarna:";
            // 
            // nucleonAmountLabel
            // 
            this.nucleonAmountLabel.AutoSize = true;
            this.nucleonAmountLabel.Location = new System.Drawing.Point(20, 231);
            this.nucleonAmountLabel.Name = "nucleonAmountLabel";
            this.nucleonAmountLabel.Size = new System.Drawing.Size(79, 17);
            this.nucleonAmountLabel.TabIndex = 52;
            this.nucleonAmountLabel.Text = "Ilość ziaren";
            // 
            // NeighborhoodCheckedListBox
            // 
            this.NeighborhoodCheckedListBox.CheckOnClick = true;
            this.NeighborhoodCheckedListBox.FormattingEnabled = true;
            this.NeighborhoodCheckedListBox.Items.AddRange(new object[] {
            "Moore",
            "von Neumann",
            "Hexagonal Left",
            "Hexagonal Right",
            "Hexagonal Random",
            "Pentagonal Left",
            "Pentagonal Right",
            "Pentagonal Top",
            "Pentagonal Bottom",
            "Pentagonal Random",
            "Pseudo - Heksagonal",
            "Rectangle"});
            this.NeighborhoodCheckedListBox.Location = new System.Drawing.Point(109, 104);
            this.NeighborhoodCheckedListBox.Name = "NeighborhoodCheckedListBox";
            this.NeighborhoodCheckedListBox.Size = new System.Drawing.Size(166, 89);
            this.NeighborhoodCheckedListBox.TabIndex = 51;
            this.NeighborhoodCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.NeighborhoodCheckedListBox_ItemCheck);
            // 
            // randomThresholdTextBox
            // 
            this.randomThresholdTextBox.Location = new System.Drawing.Point(131, 196);
            this.randomThresholdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.randomThresholdTextBox.Name = "randomThresholdTextBox";
            this.randomThresholdTextBox.Size = new System.Drawing.Size(144, 22);
            this.randomThresholdTextBox.TabIndex = 49;
            this.randomThresholdTextBox.Leave += new System.EventHandler(this.randomThresholdTextBox_Leave);
            // 
            // randomThresholdLabel
            // 
            this.randomThresholdLabel.AutoSize = true;
            this.randomThresholdLabel.Location = new System.Drawing.Point(20, 196);
            this.randomThresholdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.randomThresholdLabel.Name = "randomThresholdLabel";
            this.randomThresholdLabel.Size = new System.Drawing.Size(102, 17);
            this.randomThresholdLabel.TabIndex = 50;
            this.randomThresholdLabel.Text = "Próg losowości";
            // 
            // randomNeighborhoodLabel
            // 
            this.randomNeighborhoodLabel.AutoSize = true;
            this.randomNeighborhoodLabel.Location = new System.Drawing.Point(20, 76);
            this.randomNeighborhoodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.randomNeighborhoodLabel.Name = "randomNeighborhoodLabel";
            this.randomNeighborhoodLabel.Size = new System.Drawing.Size(70, 17);
            this.randomNeighborhoodLabel.TabIndex = 48;
            this.randomNeighborhoodLabel.Text = "Losowość";
            // 
            // boundaryLabel
            // 
            this.boundaryLabel.Location = new System.Drawing.Point(20, 23);
            this.boundaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.boundaryLabel.Name = "boundaryLabel";
            this.boundaryLabel.Size = new System.Drawing.Size(81, 37);
            this.boundaryLabel.TabIndex = 44;
            this.boundaryLabel.Text = "Warunki brzegowe";
            // 
            // boundaryComboBox
            // 
            this.boundaryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boundaryComboBox.Enabled = false;
            this.boundaryComboBox.FormattingEnabled = true;
            this.boundaryComboBox.Items.AddRange(new object[] {
            "Periodyczne",
            "Odbijające",
            "Ustalone (0)"});
            this.boundaryComboBox.Location = new System.Drawing.Point(109, 23);
            this.boundaryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.boundaryComboBox.Name = "boundaryComboBox";
            this.boundaryComboBox.Size = new System.Drawing.Size(166, 24);
            this.boundaryComboBox.TabIndex = 42;
            this.boundaryComboBox.SelectedIndexChanged += new System.EventHandler(this.boundaryComboBox_SelectedIndexChanged);
            // 
            // neighborhoodLabel
            // 
            this.neighborhoodLabel.AutoSize = true;
            this.neighborhoodLabel.Location = new System.Drawing.Point(20, 147);
            this.neighborhoodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.neighborhoodLabel.Name = "neighborhoodLabel";
            this.neighborhoodLabel.Size = new System.Drawing.Size(79, 17);
            this.neighborhoodLabel.TabIndex = 45;
            this.neighborhoodLabel.Text = "Sąsiedztwo";
            // 
            // randomNeighborhoodComboBox
            // 
            this.randomNeighborhoodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.randomNeighborhoodComboBox.FormattingEnabled = true;
            this.randomNeighborhoodComboBox.Items.AddRange(new object[] {
            "Brak",
            "Włącz/Wyłącz",
            "Kilka Sąsiedztw",
            "Każdy sąsiad"});
            this.randomNeighborhoodComboBox.Location = new System.Drawing.Point(109, 73);
            this.randomNeighborhoodComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.randomNeighborhoodComboBox.Name = "randomNeighborhoodComboBox";
            this.randomNeighborhoodComboBox.Size = new System.Drawing.Size(166, 24);
            this.randomNeighborhoodComboBox.TabIndex = 47;
            this.randomNeighborhoodComboBox.SelectedIndexChanged += new System.EventHandler(this.randomNeighborhoodComboBox_SelectedIndexChanged);
            // 
            // executionButtonsPanel
            // 
            this.executionButtonsPanel.Controls.Add(this.nextStepCAButton);
            this.executionButtonsPanel.Controls.Add(this.stopCAButton);
            this.executionButtonsPanel.Controls.Add(this.runCAButton);
            this.executionButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.executionButtonsPanel.Location = new System.Drawing.Point(4, 275);
            this.executionButtonsPanel.Name = "executionButtonsPanel";
            this.executionButtonsPanel.Size = new System.Drawing.Size(303, 63);
            this.executionButtonsPanel.TabIndex = 58;
            // 
            // classicExecutionOptionsGroupBox
            // 
            this.classicExecutionOptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.classicExecutionOptionsGroupBox.Location = new System.Drawing.Point(4, 75);
            this.classicExecutionOptionsGroupBox.Name = "classicExecutionOptionsGroupBox";
            this.classicExecutionOptionsGroupBox.Size = new System.Drawing.Size(303, 100);
            this.classicExecutionOptionsGroupBox.TabIndex = 59;
            this.classicExecutionOptionsGroupBox.TabStop = false;
            this.classicExecutionOptionsGroupBox.Text = "Opcje Rozrostu";
            this.classicExecutionOptionsGroupBox.Visible = false;
            // 
            // rectangleExecutionOptionsGroupBox
            // 
            this.rectangleExecutionOptionsGroupBox.Controls.Add(this.label1);
            this.rectangleExecutionOptionsGroupBox.Controls.Add(this.ratioSecondRectNumeric);
            this.rectangleExecutionOptionsGroupBox.Controls.Add(this.ratioFirstRectNumeric);
            this.rectangleExecutionOptionsGroupBox.Controls.Add(this.ratioRectLabel);
            this.rectangleExecutionOptionsGroupBox.Controls.Add(this.rotationRectNumericUpDown);
            this.rectangleExecutionOptionsGroupBox.Controls.Add(this.rotationRectLabel);
            this.rectangleExecutionOptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.rectangleExecutionOptionsGroupBox.Location = new System.Drawing.Point(4, 175);
            this.rectangleExecutionOptionsGroupBox.Name = "rectangleExecutionOptionsGroupBox";
            this.rectangleExecutionOptionsGroupBox.Size = new System.Drawing.Size(303, 100);
            this.rectangleExecutionOptionsGroupBox.TabIndex = 60;
            this.rectangleExecutionOptionsGroupBox.TabStop = false;
            this.rectangleExecutionOptionsGroupBox.Text = "Opcje Rozrostu";
            this.rectangleExecutionOptionsGroupBox.Visible = false;
            // 
            // rotationRectLabel
            // 
            this.rotationRectLabel.AutoSize = true;
            this.rotationRectLabel.Location = new System.Drawing.Point(16, 29);
            this.rotationRectLabel.Name = "rotationRectLabel";
            this.rotationRectLabel.Size = new System.Drawing.Size(44, 17);
            this.rotationRectLabel.TabIndex = 0;
            this.rotationRectLabel.Text = "Obrót";
            // 
            // rotationRectNumericUpDown
            // 
            this.rotationRectNumericUpDown.Location = new System.Drawing.Point(105, 29);
            this.rotationRectNumericUpDown.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.rotationRectNumericUpDown.Name = "rotationRectNumericUpDown";
            this.rotationRectNumericUpDown.Size = new System.Drawing.Size(166, 22);
            this.rotationRectNumericUpDown.TabIndex = 1;
            this.rotationRectNumericUpDown.ValueChanged += new System.EventHandler(this.rotationRectNumericUpDown_ValueChanged);
            // 
            // ratioRectLabel
            // 
            this.ratioRectLabel.AutoSize = true;
            this.ratioRectLabel.Location = new System.Drawing.Point(16, 69);
            this.ratioRectLabel.Name = "ratioRectLabel";
            this.ratioRectLabel.Size = new System.Drawing.Size(67, 17);
            this.ratioRectLabel.TabIndex = 2;
            this.ratioRectLabel.Text = "Stosunek";
            // 
            // ratioFirstRectNumeric
            // 
            this.ratioFirstRectNumeric.Location = new System.Drawing.Point(105, 64);
            this.ratioFirstRectNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ratioFirstRectNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ratioFirstRectNumeric.Name = "ratioFirstRectNumeric";
            this.ratioFirstRectNumeric.Size = new System.Drawing.Size(71, 22);
            this.ratioFirstRectNumeric.TabIndex = 3;
            this.ratioFirstRectNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ratioFirstRectNumeric.ValueChanged += new System.EventHandler(this.ratioFirstRectNumeric_ValueChanged);
            // 
            // ratioSecondRectNumeric
            // 
            this.ratioSecondRectNumeric.Location = new System.Drawing.Point(200, 64);
            this.ratioSecondRectNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ratioSecondRectNumeric.Name = "ratioSecondRectNumeric";
            this.ratioSecondRectNumeric.Size = new System.Drawing.Size(71, 22);
            this.ratioSecondRectNumeric.TabIndex = 4;
            this.ratioSecondRectNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ratioSecondRectNumeric.ValueChanged += new System.EventHandler(this.ratioSecondRectNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = ":";
            // 
            // Automat2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 871);
            this.Controls.Add(this.splitContainer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Automat2D";
            this.Text = "Automat2D";
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPictureBox)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.gridOptionsGroupBox.ResumeLayout(false);
            this.gridOptionsGroupBox.PerformLayout();
            this.executionGroupBox.ResumeLayout(false);
            this.modeExecutionGroupBox.ResumeLayout(false);
            this.modeExecutionGroupBox.PerformLayout();
            this.gridViewGroupBox.ResumeLayout(false);
            this.gridViewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            this.simulationOptionsGroupBox.ResumeLayout(false);
            this.simulationOptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nucleonAmountNumericUpDown)).EndInit();
            this.executionButtonsPanel.ResumeLayout(false);
            this.rectangleExecutionOptionsGroupBox.ResumeLayout(false);
            this.rectangleExecutionOptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationRectNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratioFirstRectNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratioSecondRectNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.PictureBox gridPictureBox;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.GroupBox executionGroupBox;
        private System.Windows.Forms.Button nextStepCAButton;
        private System.Windows.Forms.Button stopCAButton;
        private System.Windows.Forms.Button runCAButton;
        private System.Windows.Forms.GroupBox gridViewGroupBox;
        private System.Windows.Forms.TrackBar zoomTrackBar;
        private System.Windows.Forms.Label zoomLabel;
        private System.Windows.Forms.CheckBox gridCheckBox;
        private System.Windows.Forms.GroupBox simulationOptionsGroupBox;
        private System.Windows.Forms.Label boundaryLabel;
        private System.Windows.Forms.ComboBox boundaryComboBox;
        private System.Windows.Forms.Label neighborhoodLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button resizeGridButton;
        private System.Windows.Forms.TextBox randomThresholdTextBox;
        private System.Windows.Forms.Label randomThresholdLabel;
        private System.Windows.Forms.Label randomNeighborhoodLabel;
        private System.Windows.Forms.ComboBox randomNeighborhoodComboBox;
        private System.Windows.Forms.CheckedListBox NeighborhoodCheckedListBox;
        private System.Windows.Forms.GroupBox modeExecutionGroupBox;
        private System.Windows.Forms.RadioButton circleModeExecutionRadioButton;
        private System.Windows.Forms.RadioButton squareModeExecutionRadioButton;
        private GroupBox gridOptionsGroupBox;
        private TextBox xCellTextBox;
        private TextBox yCellTextBox;
        private Label xNumberLabel;
        private Label yNumberLabel;
        private NumericUpDown nucleonAmountNumericUpDown;
        private Label currentNucleonIdValueLabel;
        private Label currenNucleonTextLabel;
        private Label nucleonAmountLabel;
        private Panel executionButtonsPanel;
        private GroupBox rectangleExecutionOptionsGroupBox;
        private Label label1;
        private NumericUpDown ratioSecondRectNumeric;
        private NumericUpDown ratioFirstRectNumeric;
        private Label ratioRectLabel;
        private NumericUpDown rotationRectNumericUpDown;
        private Label rotationRectLabel;
        private GroupBox classicExecutionOptionsGroupBox;
    }
}

