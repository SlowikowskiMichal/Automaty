namespace Lab5
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
            this.executionGroupBox = new System.Windows.Forms.GroupBox();
            this.deadRulesLabel = new System.Windows.Forms.Label();
            this.aliveRulesTextBox = new System.Windows.Forms.TextBox();
            this.deadRulesTextBox = new System.Windows.Forms.TextBox();
            this.nextStepCAButton = new System.Windows.Forms.Button();
            this.stopCAButton = new System.Windows.Forms.Button();
            this.runCAButton = new System.Windows.Forms.Button();
            this.aliveRulesLlabel = new System.Windows.Forms.Label();
            this.gridViewGroupBox = new System.Windows.Forms.GroupBox();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.gridCheckBox = new System.Windows.Forms.CheckBox();
            this.gridOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.NeighborhoodCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.randomThresholdTextBox = new System.Windows.Forms.TextBox();
            this.randomThresholdLabel = new System.Windows.Forms.Label();
            this.randomNeighborhoodLabel = new System.Windows.Forms.Label();
            this.boundaryLabel = new System.Windows.Forms.Label();
            this.xCellTextBox = new System.Windows.Forms.TextBox();
            this.boundaryComboBox = new System.Windows.Forms.ComboBox();
            this.neighborhoodLabel = new System.Windows.Forms.Label();
            this.yCellTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.xNumberLabel = new System.Windows.Forms.Label();
            this.resizeGridButton = new System.Windows.Forms.Button();
            this.yNumberLabel = new System.Windows.Forms.Label();
            this.randomNeighborhoodComboBox = new System.Windows.Forms.ComboBox();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.executionGroupBox.SuspendLayout();
            this.gridViewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            this.gridOptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPanel
            // 
            this.gridPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPanel.AutoScroll = true;
            this.gridPanel.Controls.Add(this.gridPictureBox);
            this.gridPanel.Location = new System.Drawing.Point(0, 0);
            this.gridPanel.Margin = new System.Windows.Forms.Padding(4);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(866, 673);
            this.gridPanel.TabIndex = 0;
            // 
            // gridPictureBox
            // 
            this.gridPictureBox.Location = new System.Drawing.Point(4, 4);
            this.gridPictureBox.Name = "gridPictureBox";
            this.gridPictureBox.Size = new System.Drawing.Size(528, 424);
            this.gridPictureBox.TabIndex = 0;
            this.gridPictureBox.TabStop = false;
            this.gridPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridPictureBox_MouseDown);
            this.gridPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridPictureBox_MouseUp);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.splitContainer.Size = new System.Drawing.Size(1182, 673);
            this.splitContainer.SplitterDistance = 866;
            this.splitContainer.TabIndex = 58;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.executionGroupBox);
            this.settingsPanel.Controls.Add(this.gridViewGroupBox);
            this.settingsPanel.Controls.Add(this.gridOptionsGroupBox);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(312, 673);
            this.settingsPanel.TabIndex = 58;
            // 
            // executionGroupBox
            // 
            this.executionGroupBox.Controls.Add(this.deadRulesLabel);
            this.executionGroupBox.Controls.Add(this.aliveRulesTextBox);
            this.executionGroupBox.Controls.Add(this.deadRulesTextBox);
            this.executionGroupBox.Controls.Add(this.nextStepCAButton);
            this.executionGroupBox.Controls.Add(this.stopCAButton);
            this.executionGroupBox.Controls.Add(this.runCAButton);
            this.executionGroupBox.Controls.Add(this.aliveRulesLlabel);
            this.executionGroupBox.Location = new System.Drawing.Point(18, 488);
            this.executionGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.executionGroupBox.Name = "executionGroupBox";
            this.executionGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.executionGroupBox.Size = new System.Drawing.Size(281, 172);
            this.executionGroupBox.TabIndex = 56;
            this.executionGroupBox.TabStop = false;
            this.executionGroupBox.Text = "Egzekucja";
            // 
            // deadRulesLabel
            // 
            this.deadRulesLabel.AutoSize = true;
            this.deadRulesLabel.Location = new System.Drawing.Point(18, 69);
            this.deadRulesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deadRulesLabel.Name = "deadRulesLabel";
            this.deadRulesLabel.Size = new System.Drawing.Size(101, 17);
            this.deadRulesLabel.TabIndex = 56;
            this.deadRulesLabel.Text = "Reguła śmierci";
            // 
            // aliveRulesTextBox
            // 
            this.aliveRulesTextBox.Location = new System.Drawing.Point(129, 34);
            this.aliveRulesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.aliveRulesTextBox.Name = "aliveRulesTextBox";
            this.aliveRulesTextBox.Size = new System.Drawing.Size(138, 22);
            this.aliveRulesTextBox.TabIndex = 47;
            this.aliveRulesTextBox.Text = "3";
            this.aliveRulesTextBox.Leave += new System.EventHandler(this.aliveRulesTextBox_TextChanged);
            // 
            // deadRulesTextBox
            // 
            this.deadRulesTextBox.Location = new System.Drawing.Point(129, 66);
            this.deadRulesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.deadRulesTextBox.Name = "deadRulesTextBox";
            this.deadRulesTextBox.Size = new System.Drawing.Size(138, 22);
            this.deadRulesTextBox.TabIndex = 48;
            this.deadRulesTextBox.Text = "0;1;4;5;6;7;8";
            this.deadRulesTextBox.Leave += new System.EventHandler(this.deadRulesTextBox_TextChanged);
            // 
            // nextStepCAButton
            // 
            this.nextStepCAButton.Location = new System.Drawing.Point(188, 106);
            this.nextStepCAButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextStepCAButton.Name = "nextStepCAButton";
            this.nextStepCAButton.Size = new System.Drawing.Size(83, 58);
            this.nextStepCAButton.TabIndex = 16;
            this.nextStepCAButton.Text = "Następny\r\nKrok";
            this.nextStepCAButton.UseVisualStyleBackColor = true;
            this.nextStepCAButton.Click += new System.EventHandler(this.nextStepCAButton_Click);
            // 
            // stopCAButton
            // 
            this.stopCAButton.Location = new System.Drawing.Point(105, 106);
            this.stopCAButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopCAButton.Name = "stopCAButton";
            this.stopCAButton.Size = new System.Drawing.Size(80, 58);
            this.stopCAButton.TabIndex = 16;
            this.stopCAButton.Text = "Stop";
            this.stopCAButton.UseVisualStyleBackColor = true;
            this.stopCAButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // runCAButton
            // 
            this.runCAButton.Location = new System.Drawing.Point(13, 106);
            this.runCAButton.Margin = new System.Windows.Forms.Padding(4);
            this.runCAButton.Name = "runCAButton";
            this.runCAButton.Size = new System.Drawing.Size(86, 58);
            this.runCAButton.TabIndex = 16;
            this.runCAButton.Text = "Start";
            this.runCAButton.UseVisualStyleBackColor = true;
            this.runCAButton.Click += new System.EventHandler(this.runCAButton_Click);
            // 
            // aliveRulesLlabel
            // 
            this.aliveRulesLlabel.AutoSize = true;
            this.aliveRulesLlabel.Location = new System.Drawing.Point(18, 34);
            this.aliveRulesLlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aliveRulesLlabel.Name = "aliveRulesLlabel";
            this.aliveRulesLlabel.Size = new System.Drawing.Size(112, 17);
            this.aliveRulesLlabel.TabIndex = 55;
            this.aliveRulesLlabel.Text = "Reguła narodzin";
            // 
            // gridViewGroupBox
            // 
            this.gridViewGroupBox.Controls.Add(this.zoomTrackBar);
            this.gridViewGroupBox.Controls.Add(this.zoomLabel);
            this.gridViewGroupBox.Controls.Add(this.gridCheckBox);
            this.gridViewGroupBox.Location = new System.Drawing.Point(17, 13);
            this.gridViewGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewGroupBox.Name = "gridViewGroupBox";
            this.gridViewGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.gridViewGroupBox.Size = new System.Drawing.Size(281, 121);
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
            // gridOptionsGroupBox
            // 
            this.gridOptionsGroupBox.Controls.Add(this.NeighborhoodCheckedListBox);
            this.gridOptionsGroupBox.Controls.Add(this.randomThresholdTextBox);
            this.gridOptionsGroupBox.Controls.Add(this.randomThresholdLabel);
            this.gridOptionsGroupBox.Controls.Add(this.randomNeighborhoodLabel);
            this.gridOptionsGroupBox.Controls.Add(this.boundaryLabel);
            this.gridOptionsGroupBox.Controls.Add(this.xCellTextBox);
            this.gridOptionsGroupBox.Controls.Add(this.boundaryComboBox);
            this.gridOptionsGroupBox.Controls.Add(this.neighborhoodLabel);
            this.gridOptionsGroupBox.Controls.Add(this.yCellTextBox);
            this.gridOptionsGroupBox.Controls.Add(this.clearButton);
            this.gridOptionsGroupBox.Controls.Add(this.xNumberLabel);
            this.gridOptionsGroupBox.Controls.Add(this.resizeGridButton);
            this.gridOptionsGroupBox.Controls.Add(this.yNumberLabel);
            this.gridOptionsGroupBox.Controls.Add(this.randomNeighborhoodComboBox);
            this.gridOptionsGroupBox.Location = new System.Drawing.Point(17, 142);
            this.gridOptionsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.gridOptionsGroupBox.Name = "gridOptionsGroupBox";
            this.gridOptionsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.gridOptionsGroupBox.Size = new System.Drawing.Size(281, 338);
            this.gridOptionsGroupBox.TabIndex = 56;
            this.gridOptionsGroupBox.TabStop = false;
            this.gridOptionsGroupBox.Text = "Opcje siatki";
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
            this.NeighborhoodCheckedListBox.Location = new System.Drawing.Point(106, 104);
            this.NeighborhoodCheckedListBox.Name = "NeighborhoodCheckedListBox";
            this.NeighborhoodCheckedListBox.Size = new System.Drawing.Size(166, 89);
            this.NeighborhoodCheckedListBox.TabIndex = 51;
            this.NeighborhoodCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.NeighborhoodCheckedListBox_ItemCheck);
            // 
            // randomThresholdTextBox
            // 
            this.randomThresholdTextBox.Location = new System.Drawing.Point(130, 219);
            this.randomThresholdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.randomThresholdTextBox.Name = "randomThresholdTextBox";
            this.randomThresholdTextBox.Size = new System.Drawing.Size(144, 22);
            this.randomThresholdTextBox.TabIndex = 49;
            this.randomThresholdTextBox.Leave += new System.EventHandler(this.randomThresholdTextBox_Leave);
            // 
            // randomThresholdLabel
            // 
            this.randomThresholdLabel.AutoSize = true;
            this.randomThresholdLabel.Location = new System.Drawing.Point(19, 219);
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
            // xCellTextBox
            // 
            this.xCellTextBox.Location = new System.Drawing.Point(140, 246);
            this.xCellTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.xCellTextBox.Name = "xCellTextBox";
            this.xCellTextBox.Size = new System.Drawing.Size(132, 22);
            this.xCellTextBox.TabIndex = 33;
            // 
            // boundaryComboBox
            // 
            this.boundaryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.neighborhoodLabel.Location = new System.Drawing.Point(19, 142);
            this.neighborhoodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.neighborhoodLabel.Name = "neighborhoodLabel";
            this.neighborhoodLabel.Size = new System.Drawing.Size(79, 17);
            this.neighborhoodLabel.TabIndex = 45;
            this.neighborhoodLabel.Text = "Sąsiedstwo";
            // 
            // yCellTextBox
            // 
            this.yCellTextBox.Location = new System.Drawing.Point(140, 278);
            this.yCellTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.yCellTextBox.Name = "yCellTextBox";
            this.yCellTextBox.Size = new System.Drawing.Size(132, 22);
            this.yCellTextBox.TabIndex = 34;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearButton.Location = new System.Drawing.Point(173, 302);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 28);
            this.clearButton.TabIndex = 46;
            this.clearButton.Text = "Wyczyść";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // xNumberLabel
            // 
            this.xNumberLabel.AutoSize = true;
            this.xNumberLabel.Location = new System.Drawing.Point(72, 249);
            this.xNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xNumberLabel.Name = "xNumberLabel";
            this.xNumberLabel.Size = new System.Drawing.Size(62, 17);
            this.xNumberLabel.TabIndex = 38;
            this.xNumberLabel.Text = "Kolumny";
            // 
            // resizeGridButton
            // 
            this.resizeGridButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resizeGridButton.Location = new System.Drawing.Point(66, 302);
            this.resizeGridButton.Margin = new System.Windows.Forms.Padding(4);
            this.resizeGridButton.Name = "resizeGridButton";
            this.resizeGridButton.Size = new System.Drawing.Size(100, 28);
            this.resizeGridButton.TabIndex = 35;
            this.resizeGridButton.Text = "Zmień Rozmiar";
            this.resizeGridButton.UseVisualStyleBackColor = true;
            this.resizeGridButton.Click += new System.EventHandler(this.resizeGridButton_Click);
            // 
            // yNumberLabel
            // 
            this.yNumberLabel.AutoSize = true;
            this.yNumberLabel.Location = new System.Drawing.Point(72, 281);
            this.yNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yNumberLabel.Name = "yNumberLabel";
            this.yNumberLabel.Size = new System.Drawing.Size(59, 17);
            this.yNumberLabel.TabIndex = 37;
            this.yNumberLabel.Text = "Wiersze";
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
            // Automat2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 673);
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
            this.executionGroupBox.ResumeLayout(false);
            this.executionGroupBox.PerformLayout();
            this.gridViewGroupBox.ResumeLayout(false);
            this.gridViewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            this.gridOptionsGroupBox.ResumeLayout(false);
            this.gridOptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.PictureBox gridPictureBox;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.GroupBox executionGroupBox;
        private System.Windows.Forms.Label deadRulesLabel;
        private System.Windows.Forms.TextBox aliveRulesTextBox;
        private System.Windows.Forms.TextBox deadRulesTextBox;
        private System.Windows.Forms.Button nextStepCAButton;
        private System.Windows.Forms.Button stopCAButton;
        private System.Windows.Forms.Button runCAButton;
        private System.Windows.Forms.Label aliveRulesLlabel;
        private System.Windows.Forms.GroupBox gridViewGroupBox;
        private System.Windows.Forms.TrackBar zoomTrackBar;
        private System.Windows.Forms.Label zoomLabel;
        private System.Windows.Forms.CheckBox gridCheckBox;
        private System.Windows.Forms.GroupBox gridOptionsGroupBox;
        private System.Windows.Forms.Label boundaryLabel;
        private System.Windows.Forms.TextBox xCellTextBox;
        private System.Windows.Forms.ComboBox boundaryComboBox;
        private System.Windows.Forms.Label neighborhoodLabel;
        private System.Windows.Forms.TextBox yCellTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label xNumberLabel;
        private System.Windows.Forms.Button resizeGridButton;
        private System.Windows.Forms.Label yNumberLabel;
        private System.Windows.Forms.TextBox randomThresholdTextBox;
        private System.Windows.Forms.Label randomThresholdLabel;
        private System.Windows.Forms.Label randomNeighborhoodLabel;
        private System.Windows.Forms.ComboBox randomNeighborhoodComboBox;
        private System.Windows.Forms.CheckedListBox NeighborhoodCheckedListBox;
    }
}

