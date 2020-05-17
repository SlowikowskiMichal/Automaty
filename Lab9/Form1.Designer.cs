using System;
using System.Windows.Forms;

namespace Lab9
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
            this.menuTabControl = new System.Windows.Forms.TabControl();
            this.executionTabPage = new System.Windows.Forms.TabPage();
            this.executionGroupBox = new System.Windows.Forms.GroupBox();
            this.executionButtonsPanel = new System.Windows.Forms.Panel();
            this.nextStepCAButton = new System.Windows.Forms.Button();
            this.stopCAButton = new System.Windows.Forms.Button();
            this.runCAButton = new System.Windows.Forms.Button();
            this.nucleaGroupBox = new System.Windows.Forms.GroupBox();
            this.nucleaInTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.nucleaInTimeButtonPanel = new System.Windows.Forms.Panel();
            this.clearInTimeNucleaButton = new System.Windows.Forms.Button();
            this.addInTimeNucleaButton = new System.Windows.Forms.Button();
            this.delayNucleonsInTimePanel = new System.Windows.Forms.Panel();
            this.delayNucleaInTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.delayNucleaInTimeLabel = new System.Windows.Forms.Label();
            this.nucleaInTimeListBox = new System.Windows.Forms.ListBox();
            this.nucleaButtonPanel = new System.Windows.Forms.Panel();
            this.clearNucleaButton = new System.Windows.Forms.Button();
            this.addNucleaButton = new System.Windows.Forms.Button();
            this.rectangleExecutionOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.rotationModeRectGroupBox = new System.Windows.Forms.GroupBox();
            this.randomRotationRectRadioButton = new System.Windows.Forms.RadioButton();
            this.sameRotationRectRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ratioSecondRectNumeric = new System.Windows.Forms.NumericUpDown();
            this.ratioFirstRectNumeric = new System.Windows.Forms.NumericUpDown();
            this.ratioRectLabel = new System.Windows.Forms.Label();
            this.rotationRectNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rotationRectLabel = new System.Windows.Forms.Label();
            this.classicExecutionOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.deadRulesLabel = new System.Windows.Forms.Label();
            this.aliveRulesTextBox = new System.Windows.Forms.TextBox();
            this.deadRulesTextBox = new System.Windows.Forms.TextBox();
            this.aliveRulesLlabel = new System.Windows.Forms.Label();
            this.modeExecutionGroupBox = new System.Windows.Forms.GroupBox();
            this.classicModeExecutionRadioButton = new System.Windows.Forms.RadioButton();
            this.squareModeExecutionRadioButton = new System.Windows.Forms.RadioButton();
            this.circleModeExecutionRadioButton = new System.Windows.Forms.RadioButton();
            this.nucleonNumberPanel = new System.Windows.Forms.Panel();
            this.nucleonAmountLabel = new System.Windows.Forms.Label();
            this.countNucleonIdValueLabel = new System.Windows.Forms.Label();
            this.countNucleonTextLabel = new System.Windows.Forms.Label();
            this.nucleonAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.optionsTabPage = new System.Windows.Forms.TabPage();
            this.simulationOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.NeighborhoodCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.randomThresholdTextBox = new System.Windows.Forms.TextBox();
            this.randomThresholdLabel = new System.Windows.Forms.Label();
            this.randomNeighborhoodLabel = new System.Windows.Forms.Label();
            this.boundaryLabel = new System.Windows.Forms.Label();
            this.boundaryComboBox = new System.Windows.Forms.ComboBox();
            this.neighborhoodLabel = new System.Windows.Forms.Label();
            this.randomNeighborhoodComboBox = new System.Windows.Forms.ComboBox();
            this.gridOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.xCellTextBox = new System.Windows.Forms.TextBox();
            this.yCellTextBox = new System.Windows.Forms.TextBox();
            this.xNumberLabel = new System.Windows.Forms.Label();
            this.yNumberLabel = new System.Windows.Forms.Label();
            this.resizeGridButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.gridViewGroupBox = new System.Windows.Forms.GroupBox();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.gridCheckBox = new System.Windows.Forms.CheckBox();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.menuTabControl.SuspendLayout();
            this.executionTabPage.SuspendLayout();
            this.executionGroupBox.SuspendLayout();
            this.executionButtonsPanel.SuspendLayout();
            this.nucleaGroupBox.SuspendLayout();
            this.nucleaInTimeGroupBox.SuspendLayout();
            this.nucleaInTimeButtonPanel.SuspendLayout();
            this.delayNucleonsInTimePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayNucleaInTimeNumeric)).BeginInit();
            this.nucleaButtonPanel.SuspendLayout();
            this.rectangleExecutionOptionsGroupBox.SuspendLayout();
            this.rotationModeRectGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratioSecondRectNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratioFirstRectNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationRectNumericUpDown)).BeginInit();
            this.classicExecutionOptionsGroupBox.SuspendLayout();
            this.modeExecutionGroupBox.SuspendLayout();
            this.nucleonNumberPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nucleonAmountNumericUpDown)).BeginInit();
            this.optionsTabPage.SuspendLayout();
            this.simulationOptionsGroupBox.SuspendLayout();
            this.gridOptionsGroupBox.SuspendLayout();
            this.gridViewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
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
            this.gridPanel.Size = new System.Drawing.Size(870, 1022);
            this.gridPanel.TabIndex = 0;
            // 
            // gridPictureBox
            // 
            this.gridPictureBox.Location = new System.Drawing.Point(4, 4);
            this.gridPictureBox.Name = "gridPictureBox";
            this.gridPictureBox.Size = new System.Drawing.Size(528, 424);
            this.gridPictureBox.TabIndex = 0;
            this.gridPictureBox.TabStop = false;
            this.gridPictureBox.Click += new System.EventHandler(this.gridPictureBox_Click);
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
            this.splitContainer.Size = new System.Drawing.Size(1131, 1022);
            this.splitContainer.SplitterDistance = 870;
            this.splitContainer.TabIndex = 58;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.menuTabControl);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(257, 1022);
            this.settingsPanel.TabIndex = 58;
            // 
            // menuTabControl
            // 
            this.menuTabControl.Controls.Add(this.executionTabPage);
            this.menuTabControl.Controls.Add(this.optionsTabPage);
            this.menuTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuTabControl.Location = new System.Drawing.Point(0, 0);
            this.menuTabControl.Name = "menuTabControl";
            this.menuTabControl.SelectedIndex = 0;
            this.menuTabControl.Size = new System.Drawing.Size(257, 1022);
            this.menuTabControl.TabIndex = 58;
            // 
            // executionTabPage
            // 
            this.executionTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.executionTabPage.Controls.Add(this.executionGroupBox);
            this.executionTabPage.Controls.Add(this.nucleaGroupBox);
            this.executionTabPage.Location = new System.Drawing.Point(4, 25);
            this.executionTabPage.Name = "executionTabPage";
            this.executionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.executionTabPage.Size = new System.Drawing.Size(249, 993);
            this.executionTabPage.TabIndex = 1;
            this.executionTabPage.Text = "Egzekucja";
            // 
            // executionGroupBox
            // 
            this.executionGroupBox.AutoSize = true;
            this.executionGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.executionGroupBox.Controls.Add(this.executionButtonsPanel);
            this.executionGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.executionGroupBox.Location = new System.Drawing.Point(3, 686);
            this.executionGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.executionGroupBox.Name = "executionGroupBox";
            this.executionGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.executionGroupBox.Size = new System.Drawing.Size(243, 86);
            this.executionGroupBox.TabIndex = 57;
            this.executionGroupBox.TabStop = false;
            this.executionGroupBox.Text = "Egzekucja";
            // 
            // executionButtonsPanel
            // 
            this.executionButtonsPanel.Controls.Add(this.nextStepCAButton);
            this.executionButtonsPanel.Controls.Add(this.stopCAButton);
            this.executionButtonsPanel.Controls.Add(this.runCAButton);
            this.executionButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.executionButtonsPanel.Location = new System.Drawing.Point(4, 19);
            this.executionButtonsPanel.Name = "executionButtonsPanel";
            this.executionButtonsPanel.Size = new System.Drawing.Size(235, 63);
            this.executionButtonsPanel.TabIndex = 58;
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
            // nucleaGroupBox
            // 
            this.nucleaGroupBox.AutoSize = true;
            this.nucleaGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nucleaGroupBox.Controls.Add(this.nucleaInTimeGroupBox);
            this.nucleaGroupBox.Controls.Add(this.nucleaButtonPanel);
            this.nucleaGroupBox.Controls.Add(this.rectangleExecutionOptionsGroupBox);
            this.nucleaGroupBox.Controls.Add(this.classicExecutionOptionsGroupBox);
            this.nucleaGroupBox.Controls.Add(this.modeExecutionGroupBox);
            this.nucleaGroupBox.Controls.Add(this.nucleonNumberPanel);
            this.nucleaGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nucleaGroupBox.Location = new System.Drawing.Point(3, 3);
            this.nucleaGroupBox.Name = "nucleaGroupBox";
            this.nucleaGroupBox.Size = new System.Drawing.Size(243, 683);
            this.nucleaGroupBox.TabIndex = 58;
            this.nucleaGroupBox.TabStop = false;
            this.nucleaGroupBox.Text = "Zarodki";
            // 
            // nucleaInTimeGroupBox
            // 
            this.nucleaInTimeGroupBox.Controls.Add(this.nucleaInTimeButtonPanel);
            this.nucleaInTimeGroupBox.Controls.Add(this.delayNucleonsInTimePanel);
            this.nucleaInTimeGroupBox.Controls.Add(this.nucleaInTimeListBox);
            this.nucleaInTimeGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nucleaInTimeGroupBox.Location = new System.Drawing.Point(3, 456);
            this.nucleaInTimeGroupBox.Name = "nucleaInTimeGroupBox";
            this.nucleaInTimeGroupBox.Size = new System.Drawing.Size(237, 224);
            this.nucleaInTimeGroupBox.TabIndex = 60;
            this.nucleaInTimeGroupBox.TabStop = false;
            this.nucleaInTimeGroupBox.Text = "Zarodki dodane w czasie";
            // 
            // nucleaInTimeButtonPanel
            // 
            this.nucleaInTimeButtonPanel.Controls.Add(this.clearInTimeNucleaButton);
            this.nucleaInTimeButtonPanel.Controls.Add(this.addInTimeNucleaButton);
            this.nucleaInTimeButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nucleaInTimeButtonPanel.Location = new System.Drawing.Point(3, 156);
            this.nucleaInTimeButtonPanel.Name = "nucleaInTimeButtonPanel";
            this.nucleaInTimeButtonPanel.Size = new System.Drawing.Size(231, 54);
            this.nucleaInTimeButtonPanel.TabIndex = 60;
            // 
            // clearInTimeNucleaButton
            // 
            this.clearInTimeNucleaButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.clearInTimeNucleaButton.Location = new System.Drawing.Point(154, 0);
            this.clearInTimeNucleaButton.Name = "clearInTimeNucleaButton";
            this.clearInTimeNucleaButton.Size = new System.Drawing.Size(147, 54);
            this.clearInTimeNucleaButton.TabIndex = 65;
            this.clearInTimeNucleaButton.Text = "Wyczyść listę";
            this.clearInTimeNucleaButton.UseVisualStyleBackColor = true;
            this.clearInTimeNucleaButton.Click += new System.EventHandler(this.clearInTimeNucleaButton_Click);
            // 
            // addInTimeNucleaButton
            // 
            this.addInTimeNucleaButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addInTimeNucleaButton.Location = new System.Drawing.Point(0, 0);
            this.addInTimeNucleaButton.Name = "addInTimeNucleaButton";
            this.addInTimeNucleaButton.Size = new System.Drawing.Size(154, 54);
            this.addInTimeNucleaButton.TabIndex = 64;
            this.addInTimeNucleaButton.Text = "Dodaj w czasie";
            this.addInTimeNucleaButton.UseVisualStyleBackColor = true;
            this.addInTimeNucleaButton.Click += new System.EventHandler(this.addInTimeNucleaButton_Click);
            // 
            // delayNucleonsInTimePanel
            // 
            this.delayNucleonsInTimePanel.Controls.Add(this.delayNucleaInTimeNumeric);
            this.delayNucleonsInTimePanel.Controls.Add(this.delayNucleaInTimeLabel);
            this.delayNucleonsInTimePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.delayNucleonsInTimePanel.Location = new System.Drawing.Point(3, 102);
            this.delayNucleonsInTimePanel.Name = "delayNucleonsInTimePanel";
            this.delayNucleonsInTimePanel.Size = new System.Drawing.Size(231, 54);
            this.delayNucleonsInTimePanel.TabIndex = 61;
            // 
            // delayNucleaInTimeNumeric
            // 
            this.delayNucleaInTimeNumeric.Location = new System.Drawing.Point(110, 19);
            this.delayNucleaInTimeNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.delayNucleaInTimeNumeric.Name = "delayNucleaInTimeNumeric";
            this.delayNucleaInTimeNumeric.Size = new System.Drawing.Size(166, 22);
            this.delayNucleaInTimeNumeric.TabIndex = 1;
            // 
            // delayNucleaInTimeLabel
            // 
            this.delayNucleaInTimeLabel.AutoSize = true;
            this.delayNucleaInTimeLabel.Location = new System.Drawing.Point(17, 21);
            this.delayNucleaInTimeLabel.Name = "delayNucleaInTimeLabel";
            this.delayNucleaInTimeLabel.Size = new System.Drawing.Size(80, 17);
            this.delayNucleaInTimeLabel.TabIndex = 0;
            this.delayNucleaInTimeLabel.Text = "Opóźnienie";
            // 
            // nucleaInTimeListBox
            // 
            this.nucleaInTimeListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nucleaInTimeListBox.FormattingEnabled = true;
            this.nucleaInTimeListBox.HorizontalScrollbar = true;
            this.nucleaInTimeListBox.ItemHeight = 16;
            this.nucleaInTimeListBox.Location = new System.Drawing.Point(3, 18);
            this.nucleaInTimeListBox.Name = "nucleaInTimeListBox";
            this.nucleaInTimeListBox.Size = new System.Drawing.Size(231, 84);
            this.nucleaInTimeListBox.TabIndex = 59;
            // 
            // nucleaButtonPanel
            // 
            this.nucleaButtonPanel.Controls.Add(this.clearNucleaButton);
            this.nucleaButtonPanel.Controls.Add(this.addNucleaButton);
            this.nucleaButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nucleaButtonPanel.Location = new System.Drawing.Point(3, 400);
            this.nucleaButtonPanel.Name = "nucleaButtonPanel";
            this.nucleaButtonPanel.Size = new System.Drawing.Size(237, 56);
            this.nucleaButtonPanel.TabIndex = 63;
            // 
            // clearNucleaButton
            // 
            this.clearNucleaButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.clearNucleaButton.Location = new System.Drawing.Point(157, 0);
            this.clearNucleaButton.Name = "clearNucleaButton";
            this.clearNucleaButton.Size = new System.Drawing.Size(148, 56);
            this.clearNucleaButton.TabIndex = 63;
            this.clearNucleaButton.Text = "Wyczyść obecne zarodki";
            this.clearNucleaButton.UseVisualStyleBackColor = true;
            this.clearNucleaButton.Click += new System.EventHandler(this.clearNucleaButton_Click);
            // 
            // addNucleaButton
            // 
            this.addNucleaButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addNucleaButton.Location = new System.Drawing.Point(0, 0);
            this.addNucleaButton.Name = "addNucleaButton";
            this.addNucleaButton.Size = new System.Drawing.Size(157, 56);
            this.addNucleaButton.TabIndex = 62;
            this.addNucleaButton.Text = "Dodaj natychmiast";
            this.addNucleaButton.UseVisualStyleBackColor = true;
            this.addNucleaButton.Click += new System.EventHandler(this.addNucleaButton_Click);
            // 
            // rectangleExecutionOptionsGroupBox
            // 
            this.rectangleExecutionOptionsGroupBox.Controls.Add(this.rotationModeRectGroupBox);
            this.rectangleExecutionOptionsGroupBox.Controls.Add(this.label1);
            this.rectangleExecutionOptionsGroupBox.Controls.Add(this.ratioSecondRectNumeric);
            this.rectangleExecutionOptionsGroupBox.Controls.Add(this.ratioFirstRectNumeric);
            this.rectangleExecutionOptionsGroupBox.Controls.Add(this.ratioRectLabel);
            this.rectangleExecutionOptionsGroupBox.Controls.Add(this.rotationRectNumericUpDown);
            this.rectangleExecutionOptionsGroupBox.Controls.Add(this.rotationRectLabel);
            this.rectangleExecutionOptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.rectangleExecutionOptionsGroupBox.Location = new System.Drawing.Point(3, 242);
            this.rectangleExecutionOptionsGroupBox.Name = "rectangleExecutionOptionsGroupBox";
            this.rectangleExecutionOptionsGroupBox.Size = new System.Drawing.Size(237, 158);
            this.rectangleExecutionOptionsGroupBox.TabIndex = 60;
            this.rectangleExecutionOptionsGroupBox.TabStop = false;
            this.rectangleExecutionOptionsGroupBox.Text = "Opcje Rozrostu";
            this.rectangleExecutionOptionsGroupBox.Visible = false;
            // 
            // rotationModeRectGroupBox
            // 
            this.rotationModeRectGroupBox.Controls.Add(this.randomRotationRectRadioButton);
            this.rotationModeRectGroupBox.Controls.Add(this.sameRotationRectRadioButton);
            this.rotationModeRectGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.rotationModeRectGroupBox.Location = new System.Drawing.Point(3, 18);
            this.rotationModeRectGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.rotationModeRectGroupBox.Name = "rotationModeRectGroupBox";
            this.rotationModeRectGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.rotationModeRectGroupBox.Size = new System.Drawing.Size(231, 56);
            this.rotationModeRectGroupBox.TabIndex = 58;
            this.rotationModeRectGroupBox.TabStop = false;
            this.rotationModeRectGroupBox.Text = "Tryb wartości";
            // 
            // randomRotationRectRadioButton
            // 
            this.randomRotationRectRadioButton.AutoSize = true;
            this.randomRotationRectRadioButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.randomRotationRectRadioButton.Location = new System.Drawing.Point(107, 19);
            this.randomRotationRectRadioButton.Name = "randomRotationRectRadioButton";
            this.randomRotationRectRadioButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.randomRotationRectRadioButton.Size = new System.Drawing.Size(96, 33);
            this.randomRotationRectRadioButton.TabIndex = 17;
            this.randomRotationRectRadioButton.Text = "Losowy";
            this.randomRotationRectRadioButton.UseVisualStyleBackColor = true;
            // 
            // sameRotationRectRadioButton
            // 
            this.sameRotationRectRadioButton.AutoSize = true;
            this.sameRotationRectRadioButton.Checked = true;
            this.sameRotationRectRadioButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.sameRotationRectRadioButton.Location = new System.Drawing.Point(4, 19);
            this.sameRotationRectRadioButton.Name = "sameRotationRectRadioButton";
            this.sameRotationRectRadioButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.sameRotationRectRadioButton.Size = new System.Drawing.Size(103, 33);
            this.sameRotationRectRadioButton.TabIndex = 18;
            this.sameRotationRectRadioButton.TabStop = true;
            this.sameRotationRectRadioButton.Text = "Wspólny";
            this.sameRotationRectRadioButton.UseVisualStyleBackColor = true;
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
            // ratioSecondRectNumeric
            // 
            this.ratioSecondRectNumeric.Location = new System.Drawing.Point(202, 121);
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
            // ratioFirstRectNumeric
            // 
            this.ratioFirstRectNumeric.Location = new System.Drawing.Point(107, 121);
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
            // ratioRectLabel
            // 
            this.ratioRectLabel.AutoSize = true;
            this.ratioRectLabel.Location = new System.Drawing.Point(18, 126);
            this.ratioRectLabel.Name = "ratioRectLabel";
            this.ratioRectLabel.Size = new System.Drawing.Size(67, 17);
            this.ratioRectLabel.TabIndex = 2;
            this.ratioRectLabel.Text = "Stosunek";
            // 
            // rotationRectNumericUpDown
            // 
            this.rotationRectNumericUpDown.Location = new System.Drawing.Point(107, 86);
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
            // rotationRectLabel
            // 
            this.rotationRectLabel.AutoSize = true;
            this.rotationRectLabel.Location = new System.Drawing.Point(18, 86);
            this.rotationRectLabel.Name = "rotationRectLabel";
            this.rotationRectLabel.Size = new System.Drawing.Size(44, 17);
            this.rotationRectLabel.TabIndex = 0;
            this.rotationRectLabel.Text = "Obrót";
            // 
            // classicExecutionOptionsGroupBox
            // 
            this.classicExecutionOptionsGroupBox.Controls.Add(this.deadRulesLabel);
            this.classicExecutionOptionsGroupBox.Controls.Add(this.aliveRulesTextBox);
            this.classicExecutionOptionsGroupBox.Controls.Add(this.deadRulesTextBox);
            this.classicExecutionOptionsGroupBox.Controls.Add(this.aliveRulesLlabel);
            this.classicExecutionOptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.classicExecutionOptionsGroupBox.Location = new System.Drawing.Point(3, 142);
            this.classicExecutionOptionsGroupBox.Name = "classicExecutionOptionsGroupBox";
            this.classicExecutionOptionsGroupBox.Size = new System.Drawing.Size(237, 100);
            this.classicExecutionOptionsGroupBox.TabIndex = 59;
            this.classicExecutionOptionsGroupBox.TabStop = false;
            this.classicExecutionOptionsGroupBox.Text = "Opcje Rozrostu";
            this.classicExecutionOptionsGroupBox.Visible = false;
            // 
            // deadRulesLabel
            // 
            this.deadRulesLabel.AutoSize = true;
            this.deadRulesLabel.Location = new System.Drawing.Point(24, 67);
            this.deadRulesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deadRulesLabel.Name = "deadRulesLabel";
            this.deadRulesLabel.Size = new System.Drawing.Size(101, 17);
            this.deadRulesLabel.TabIndex = 60;
            this.deadRulesLabel.Text = "Reguła śmierci";
            // 
            // aliveRulesTextBox
            // 
            this.aliveRulesTextBox.Location = new System.Drawing.Point(135, 32);
            this.aliveRulesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.aliveRulesTextBox.Name = "aliveRulesTextBox";
            this.aliveRulesTextBox.Size = new System.Drawing.Size(138, 22);
            this.aliveRulesTextBox.TabIndex = 57;
            this.aliveRulesTextBox.Text = "3";
            this.aliveRulesTextBox.Leave += new System.EventHandler(this.aliveRulesTextBox_TextChanged);
            // 
            // deadRulesTextBox
            // 
            this.deadRulesTextBox.Location = new System.Drawing.Point(135, 64);
            this.deadRulesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.deadRulesTextBox.Name = "deadRulesTextBox";
            this.deadRulesTextBox.Size = new System.Drawing.Size(138, 22);
            this.deadRulesTextBox.TabIndex = 58;
            this.deadRulesTextBox.Text = "0;1;4;5;6;7;8";
            this.deadRulesTextBox.Leave += new System.EventHandler(this.deadRulesTextBox_TextChanged);
            // 
            // aliveRulesLlabel
            // 
            this.aliveRulesLlabel.AutoSize = true;
            this.aliveRulesLlabel.Location = new System.Drawing.Point(24, 32);
            this.aliveRulesLlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aliveRulesLlabel.Name = "aliveRulesLlabel";
            this.aliveRulesLlabel.Size = new System.Drawing.Size(112, 17);
            this.aliveRulesLlabel.TabIndex = 59;
            this.aliveRulesLlabel.Text = "Reguła narodzin";
            // 
            // modeExecutionGroupBox
            // 
            this.modeExecutionGroupBox.Controls.Add(this.classicModeExecutionRadioButton);
            this.modeExecutionGroupBox.Controls.Add(this.squareModeExecutionRadioButton);
            this.modeExecutionGroupBox.Controls.Add(this.circleModeExecutionRadioButton);
            this.modeExecutionGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.modeExecutionGroupBox.Location = new System.Drawing.Point(3, 86);
            this.modeExecutionGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.modeExecutionGroupBox.Name = "modeExecutionGroupBox";
            this.modeExecutionGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.modeExecutionGroupBox.Size = new System.Drawing.Size(237, 56);
            this.modeExecutionGroupBox.TabIndex = 57;
            this.modeExecutionGroupBox.TabStop = false;
            this.modeExecutionGroupBox.Text = "Tryb rozrostu";
            // 
            // classicModeExecutionRadioButton
            // 
            this.classicModeExecutionRadioButton.AutoSize = true;
            this.classicModeExecutionRadioButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.classicModeExecutionRadioButton.Location = new System.Drawing.Point(181, 19);
            this.classicModeExecutionRadioButton.Name = "classicModeExecutionRadioButton";
            this.classicModeExecutionRadioButton.Size = new System.Drawing.Size(92, 33);
            this.classicModeExecutionRadioButton.TabIndex = 19;
            this.classicModeExecutionRadioButton.TabStop = true;
            this.classicModeExecutionRadioButton.Text = "Klasyczny";
            this.classicModeExecutionRadioButton.UseVisualStyleBackColor = true;
            this.classicModeExecutionRadioButton.Visible = false;
            this.classicModeExecutionRadioButton.CheckedChanged += new System.EventHandler(this.executionModeRadioButton_CheckedChanged);
            // 
            // squareModeExecutionRadioButton
            // 
            this.squareModeExecutionRadioButton.AutoSize = true;
            this.squareModeExecutionRadioButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.squareModeExecutionRadioButton.Location = new System.Drawing.Point(77, 19);
            this.squareModeExecutionRadioButton.Name = "squareModeExecutionRadioButton";
            this.squareModeExecutionRadioButton.Size = new System.Drawing.Size(104, 33);
            this.squareModeExecutionRadioButton.TabIndex = 17;
            this.squareModeExecutionRadioButton.TabStop = true;
            this.squareModeExecutionRadioButton.Text = "Prostokątny";
            this.squareModeExecutionRadioButton.UseVisualStyleBackColor = true;
            this.squareModeExecutionRadioButton.CheckedChanged += new System.EventHandler(this.executionModeRadioButton_CheckedChanged);
            // 
            // circleModeExecutionRadioButton
            // 
            this.circleModeExecutionRadioButton.AutoSize = true;
            this.circleModeExecutionRadioButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.circleModeExecutionRadioButton.Location = new System.Drawing.Point(4, 19);
            this.circleModeExecutionRadioButton.Name = "circleModeExecutionRadioButton";
            this.circleModeExecutionRadioButton.Size = new System.Drawing.Size(73, 33);
            this.circleModeExecutionRadioButton.TabIndex = 18;
            this.circleModeExecutionRadioButton.TabStop = true;
            this.circleModeExecutionRadioButton.Text = "Kołowy";
            this.circleModeExecutionRadioButton.UseVisualStyleBackColor = true;
            this.circleModeExecutionRadioButton.CheckedChanged += new System.EventHandler(this.executionModeRadioButton_CheckedChanged);
            // 
            // nucleonNumberPanel
            // 
            this.nucleonNumberPanel.Controls.Add(this.nucleonAmountLabel);
            this.nucleonNumberPanel.Controls.Add(this.countNucleonIdValueLabel);
            this.nucleonNumberPanel.Controls.Add(this.countNucleonTextLabel);
            this.nucleonNumberPanel.Controls.Add(this.nucleonAmountNumericUpDown);
            this.nucleonNumberPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nucleonNumberPanel.Location = new System.Drawing.Point(3, 18);
            this.nucleonNumberPanel.Name = "nucleonNumberPanel";
            this.nucleonNumberPanel.Size = new System.Drawing.Size(237, 68);
            this.nucleonNumberPanel.TabIndex = 64;
            // 
            // nucleonAmountLabel
            // 
            this.nucleonAmountLabel.AutoSize = true;
            this.nucleonAmountLabel.Location = new System.Drawing.Point(18, 9);
            this.nucleonAmountLabel.Name = "nucleonAmountLabel";
            this.nucleonAmountLabel.Size = new System.Drawing.Size(79, 17);
            this.nucleonAmountLabel.TabIndex = 56;
            this.nucleonAmountLabel.Text = "Ilość ziaren";
            // 
            // countNucleonIdValueLabel
            // 
            this.countNucleonIdValueLabel.AutoSize = true;
            this.countNucleonIdValueLabel.Location = new System.Drawing.Point(193, 34);
            this.countNucleonIdValueLabel.Name = "countNucleonIdValueLabel";
            this.countNucleonIdValueLabel.Size = new System.Drawing.Size(16, 17);
            this.countNucleonIdValueLabel.TabIndex = 61;
            this.countNucleonIdValueLabel.Text = "0";
            // 
            // countNucleonTextLabel
            // 
            this.countNucleonTextLabel.AutoSize = true;
            this.countNucleonTextLabel.Location = new System.Drawing.Point(17, 34);
            this.countNucleonTextLabel.Name = "countNucleonTextLabel";
            this.countNucleonTextLabel.Size = new System.Drawing.Size(146, 17);
            this.countNucleonTextLabel.TabIndex = 60;
            this.countNucleonTextLabel.Text = "Całkowita ilość ziaren:";
            // 
            // nucleonAmountNumericUpDown
            // 
            this.nucleonAmountNumericUpDown.Location = new System.Drawing.Point(129, 9);
            this.nucleonAmountNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nucleonAmountNumericUpDown.Name = "nucleonAmountNumericUpDown";
            this.nucleonAmountNumericUpDown.Size = new System.Drawing.Size(144, 22);
            this.nucleonAmountNumericUpDown.TabIndex = 59;
            this.nucleonAmountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // optionsTabPage
            // 
            this.optionsTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.optionsTabPage.Controls.Add(this.simulationOptionsGroupBox);
            this.optionsTabPage.Controls.Add(this.gridOptionsGroupBox);
            this.optionsTabPage.Controls.Add(this.gridViewGroupBox);
            this.optionsTabPage.Location = new System.Drawing.Point(4, 25);
            this.optionsTabPage.Name = "optionsTabPage";
            this.optionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.optionsTabPage.Size = new System.Drawing.Size(319, 993);
            this.optionsTabPage.TabIndex = 0;
            this.optionsTabPage.Text = "Opcje";
            // 
            // simulationOptionsGroupBox
            // 
            this.simulationOptionsGroupBox.Controls.Add(this.NeighborhoodCheckedListBox);
            this.simulationOptionsGroupBox.Controls.Add(this.randomThresholdTextBox);
            this.simulationOptionsGroupBox.Controls.Add(this.randomThresholdLabel);
            this.simulationOptionsGroupBox.Controls.Add(this.randomNeighborhoodLabel);
            this.simulationOptionsGroupBox.Controls.Add(this.boundaryLabel);
            this.simulationOptionsGroupBox.Controls.Add(this.boundaryComboBox);
            this.simulationOptionsGroupBox.Controls.Add(this.neighborhoodLabel);
            this.simulationOptionsGroupBox.Controls.Add(this.randomNeighborhoodComboBox);
            this.simulationOptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.simulationOptionsGroupBox.Location = new System.Drawing.Point(3, 205);
            this.simulationOptionsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.simulationOptionsGroupBox.Name = "simulationOptionsGroupBox";
            this.simulationOptionsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.simulationOptionsGroupBox.Size = new System.Drawing.Size(313, 230);
            this.simulationOptionsGroupBox.TabIndex = 59;
            this.simulationOptionsGroupBox.TabStop = false;
            this.simulationOptionsGroupBox.Text = "Opcje symulacji";
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
            // gridOptionsGroupBox
            // 
            this.gridOptionsGroupBox.Controls.Add(this.xCellTextBox);
            this.gridOptionsGroupBox.Controls.Add(this.yCellTextBox);
            this.gridOptionsGroupBox.Controls.Add(this.xNumberLabel);
            this.gridOptionsGroupBox.Controls.Add(this.yNumberLabel);
            this.gridOptionsGroupBox.Controls.Add(this.resizeGridButton);
            this.gridOptionsGroupBox.Controls.Add(this.clearButton);
            this.gridOptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridOptionsGroupBox.Location = new System.Drawing.Point(3, 89);
            this.gridOptionsGroupBox.Name = "gridOptionsGroupBox";
            this.gridOptionsGroupBox.Size = new System.Drawing.Size(313, 116);
            this.gridOptionsGroupBox.TabIndex = 58;
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
            // gridViewGroupBox
            // 
            this.gridViewGroupBox.Controls.Add(this.zoomTrackBar);
            this.gridViewGroupBox.Controls.Add(this.zoomLabel);
            this.gridViewGroupBox.Controls.Add(this.gridCheckBox);
            this.gridViewGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridViewGroupBox.Location = new System.Drawing.Point(3, 3);
            this.gridViewGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewGroupBox.Name = "gridViewGroupBox";
            this.gridViewGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.gridViewGroupBox.Size = new System.Drawing.Size(313, 86);
            this.gridViewGroupBox.TabIndex = 60;
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
            this.gridCheckBox.Checked = true;
            this.gridCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridCheckBox.Location = new System.Drawing.Point(47, 89);
            this.gridCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.gridCheckBox.Name = "gridCheckBox";
            this.gridCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridCheckBox.Size = new System.Drawing.Size(122, 21);
            this.gridCheckBox.TabIndex = 47;
            this.gridCheckBox.Text = "Generuj siatkę";
            this.gridCheckBox.UseVisualStyleBackColor = true;
            // 
            // Automat2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 1022);
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
            this.menuTabControl.ResumeLayout(false);
            this.executionTabPage.ResumeLayout(false);
            this.executionTabPage.PerformLayout();
            this.executionGroupBox.ResumeLayout(false);
            this.executionButtonsPanel.ResumeLayout(false);
            this.nucleaGroupBox.ResumeLayout(false);
            this.nucleaInTimeGroupBox.ResumeLayout(false);
            this.nucleaInTimeButtonPanel.ResumeLayout(false);
            this.delayNucleonsInTimePanel.ResumeLayout(false);
            this.delayNucleonsInTimePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayNucleaInTimeNumeric)).EndInit();
            this.nucleaButtonPanel.ResumeLayout(false);
            this.rectangleExecutionOptionsGroupBox.ResumeLayout(false);
            this.rectangleExecutionOptionsGroupBox.PerformLayout();
            this.rotationModeRectGroupBox.ResumeLayout(false);
            this.rotationModeRectGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratioSecondRectNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratioFirstRectNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationRectNumericUpDown)).EndInit();
            this.classicExecutionOptionsGroupBox.ResumeLayout(false);
            this.classicExecutionOptionsGroupBox.PerformLayout();
            this.modeExecutionGroupBox.ResumeLayout(false);
            this.modeExecutionGroupBox.PerformLayout();
            this.nucleonNumberPanel.ResumeLayout(false);
            this.nucleonNumberPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nucleonAmountNumericUpDown)).EndInit();
            this.optionsTabPage.ResumeLayout(false);
            this.simulationOptionsGroupBox.ResumeLayout(false);
            this.simulationOptionsGroupBox.PerformLayout();
            this.gridOptionsGroupBox.ResumeLayout(false);
            this.gridOptionsGroupBox.PerformLayout();
            this.gridViewGroupBox.ResumeLayout(false);
            this.gridViewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.PictureBox gridPictureBox;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel settingsPanel;
        private TabControl menuTabControl;
        private TabPage optionsTabPage;
        private GroupBox simulationOptionsGroupBox;
        private CheckedListBox NeighborhoodCheckedListBox;
        private TextBox randomThresholdTextBox;
        private Label randomThresholdLabel;
        private Label randomNeighborhoodLabel;
        private Label boundaryLabel;
        private ComboBox boundaryComboBox;
        private Label neighborhoodLabel;
        private ComboBox randomNeighborhoodComboBox;
        private GroupBox gridOptionsGroupBox;
        private TextBox xCellTextBox;
        private TextBox yCellTextBox;
        private Label xNumberLabel;
        private Label yNumberLabel;
        private Button resizeGridButton;
        private Button clearButton;
        private GroupBox gridViewGroupBox;
        private TrackBar zoomTrackBar;
        private Label zoomLabel;
        private CheckBox gridCheckBox;
        private TabPage executionTabPage;
        private GroupBox executionGroupBox;
        private Panel executionButtonsPanel;
        private Button nextStepCAButton;
        private Button stopCAButton;
        private Button runCAButton;
        private GroupBox rectangleExecutionOptionsGroupBox;
        private Label label1;
        private NumericUpDown ratioSecondRectNumeric;
        private NumericUpDown ratioFirstRectNumeric;
        private Label ratioRectLabel;
        private NumericUpDown rotationRectNumericUpDown;
        private Label rotationRectLabel;
        private GroupBox classicExecutionOptionsGroupBox;
        private Label deadRulesLabel;
        private TextBox aliveRulesTextBox;
        private TextBox deadRulesTextBox;
        private Label aliveRulesLlabel;
        private GroupBox modeExecutionGroupBox;
        private RadioButton classicModeExecutionRadioButton;
        private RadioButton circleModeExecutionRadioButton;
        private RadioButton squareModeExecutionRadioButton;
        private GroupBox rotationModeRectGroupBox;
        private RadioButton randomRotationRectRadioButton;
        private RadioButton sameRotationRectRadioButton;
        private GroupBox nucleaGroupBox;
        private Panel nucleaButtonPanel;
        private Button clearNucleaButton;
        private Button addNucleaButton;
        private NumericUpDown nucleonAmountNumericUpDown;
        private Label nucleonAmountLabel;
        private Panel nucleonNumberPanel;
        private Label countNucleonIdValueLabel;
        private Label countNucleonTextLabel;
        private Button clearInTimeNucleaButton;
        private Button addInTimeNucleaButton;
        private GroupBox nucleaInTimeGroupBox;
        private Panel nucleaInTimeButtonPanel;
        private Panel delayNucleonsInTimePanel;
        private NumericUpDown delayNucleaInTimeNumeric;
        private Label delayNucleaInTimeLabel;
        private ListBox nucleaInTimeListBox;
    }
}

