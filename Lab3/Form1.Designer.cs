namespace Lab3
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errLabel = new System.Windows.Forms.Label();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            this.gridCheckBox = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.neighborhoodLabel = new System.Windows.Forms.Label();
            this.boundaryLabel = new System.Windows.Forms.Label();
            this.boundaryComboBox = new System.Windows.Forms.ComboBox();
            this.NeighborComboBox = new System.Windows.Forms.ComboBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.speedBar = new System.Windows.Forms.TrackBar();
            this.xNumberLabel = new System.Windows.Forms.Label();
            this.yNumberLabel = new System.Windows.Forms.Label();
            this.resizeGridButton = new System.Windows.Forms.Button();
            this.yCellTextBox = new System.Windows.Forms.TextBox();
            this.xCellTextBox = new System.Windows.Forms.TextBox();
            this.gridOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.gridViewGroupBox = new System.Windows.Forms.GroupBox();
            this.executionGroupBox = new System.Windows.Forms.GroupBox();
            this.deadRulesLabel = new System.Windows.Forms.Label();
            this.aliveRulesTextBox = new System.Windows.Forms.TextBox();
            this.deadRulesTextBox = new System.Windows.Forms.TextBox();
            this.nextStepCAButton = new System.Windows.Forms.Button();
            this.stopCAButton = new System.Windows.Forms.Button();
            this.runCAButton = new System.Windows.Forms.Button();
            this.aliveRulesLlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            this.gridOptionsGroupBox.SuspendLayout();
            this.gridViewGroupBox.SuspendLayout();
            this.executionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 738);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(744, 556);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // errLabel
            // 
            this.errLabel.AutoSize = true;
            this.errLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errLabel.Location = new System.Drawing.Point(1088, 757);
            this.errLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errLabel.Name = "errLabel";
            this.errLabel.Size = new System.Drawing.Size(27, 17);
            this.errLabel.TabIndex = 13;
            this.errLabel.Text = "Err";
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
            // gridCheckBox
            // 
            this.gridCheckBox.AutoSize = true;
            this.gridCheckBox.Location = new System.Drawing.Point(13, 119);
            this.gridCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.gridCheckBox.Name = "gridCheckBox";
            this.gridCheckBox.Size = new System.Drawing.Size(69, 21);
            this.gridCheckBox.TabIndex = 47;
            this.gridCheckBox.Text = "Siatka";
            this.gridCheckBox.UseVisualStyleBackColor = true;
            this.gridCheckBox.CheckedChanged += new System.EventHandler(this.gridCheckBox_CheckedChanged);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearButton.Location = new System.Drawing.Point(172, 190);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 28);
            this.clearButton.TabIndex = 46;
            this.clearButton.Text = "Wyczyść";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // neighborhoodLabel
            // 
            this.neighborhoodLabel.AutoSize = true;
            this.neighborhoodLabel.Location = new System.Drawing.Point(44, 68);
            this.neighborhoodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.neighborhoodLabel.Name = "neighborhoodLabel";
            this.neighborhoodLabel.Size = new System.Drawing.Size(79, 17);
            this.neighborhoodLabel.TabIndex = 45;
            this.neighborhoodLabel.Text = "Sąsiedstwo";
            // 
            // boundaryLabel
            // 
            this.boundaryLabel.AutoSize = true;
            this.boundaryLabel.Location = new System.Drawing.Point(61, 19);
            this.boundaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.boundaryLabel.Name = "boundaryLabel";
            this.boundaryLabel.Size = new System.Drawing.Size(125, 17);
            this.boundaryLabel.TabIndex = 44;
            this.boundaryLabel.Text = "Warunki brzegowe";
            // 
            // boundaryComboBox
            // 
            this.boundaryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boundaryComboBox.FormattingEnabled = true;
            this.boundaryComboBox.Items.AddRange(new object[] {
            "Periodyczne",
            "Odbijające"});
            this.boundaryComboBox.Location = new System.Drawing.Point(107, 39);
            this.boundaryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.boundaryComboBox.Name = "boundaryComboBox";
            this.boundaryComboBox.Size = new System.Drawing.Size(166, 24);
            this.boundaryComboBox.TabIndex = 42;
            this.boundaryComboBox.SelectedIndexChanged += new System.EventHandler(this.boundaryComboBox_SelectedIndexChanged);
            // 
            // NeighborComboBox
            // 
            this.NeighborComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NeighborComboBox.FormattingEnabled = true;
            this.NeighborComboBox.Items.AddRange(new object[] {
            "Moore",
            "von Neumann",
            "Hexagonal Left",
            "Hexagonal Right",
            "Hexagonal Random",
            "Pentagonal Left",
            "Pentagonal Right",
            "Pentagonal Top",
            "Pentagonal Bottom",
            "Pentagonal Random"});
            this.NeighborComboBox.Location = new System.Drawing.Point(105, 89);
            this.NeighborComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.NeighborComboBox.Name = "NeighborComboBox";
            this.NeighborComboBox.Size = new System.Drawing.Size(166, 24);
            this.NeighborComboBox.TabIndex = 41;
            this.NeighborComboBox.SelectedIndexChanged += new System.EventHandler(this.NeighborComboBox_SelectedIndexChanged);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(17, 80);
            this.speedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(72, 17);
            this.speedLabel.TabIndex = 40;
            this.speedLabel.Text = "Szybkość:";
            // 
            // speedBar
            // 
            this.speedBar.LargeChange = 2500;
            this.speedBar.Location = new System.Drawing.Point(91, 80);
            this.speedBar.Margin = new System.Windows.Forms.Padding(4);
            this.speedBar.Maximum = 1000000;
            this.speedBar.Name = "speedBar";
            this.speedBar.Size = new System.Drawing.Size(139, 56);
            this.speedBar.SmallChange = 10000;
            this.speedBar.TabIndex = 39;
            this.speedBar.TickFrequency = 0;
            this.speedBar.Value = 1000000;
            // 
            // xNumberLabel
            // 
            this.xNumberLabel.AutoSize = true;
            this.xNumberLabel.Location = new System.Drawing.Point(71, 129);
            this.xNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xNumberLabel.Name = "xNumberLabel";
            this.xNumberLabel.Size = new System.Drawing.Size(62, 17);
            this.xNumberLabel.TabIndex = 38;
            this.xNumberLabel.Text = "Kolumny";
            // 
            // yNumberLabel
            // 
            this.yNumberLabel.AutoSize = true;
            this.yNumberLabel.Location = new System.Drawing.Point(71, 161);
            this.yNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yNumberLabel.Name = "yNumberLabel";
            this.yNumberLabel.Size = new System.Drawing.Size(59, 17);
            this.yNumberLabel.TabIndex = 37;
            this.yNumberLabel.Text = "Wiersze";
            // 
            // resizeGridButton
            // 
            this.resizeGridButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resizeGridButton.Location = new System.Drawing.Point(64, 190);
            this.resizeGridButton.Margin = new System.Windows.Forms.Padding(4);
            this.resizeGridButton.Name = "resizeGridButton";
            this.resizeGridButton.Size = new System.Drawing.Size(100, 28);
            this.resizeGridButton.TabIndex = 35;
            this.resizeGridButton.Text = "Zmień Rozmiar";
            this.resizeGridButton.UseVisualStyleBackColor = true;
            this.resizeGridButton.Click += new System.EventHandler(this.resizeGridButton_Click);
            // 
            // yCellTextBox
            // 
            this.yCellTextBox.Location = new System.Drawing.Point(139, 158);
            this.yCellTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.yCellTextBox.Name = "yCellTextBox";
            this.yCellTextBox.Size = new System.Drawing.Size(132, 22);
            this.yCellTextBox.TabIndex = 34;
            // 
            // xCellTextBox
            // 
            this.xCellTextBox.Location = new System.Drawing.Point(139, 126);
            this.xCellTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.xCellTextBox.Name = "xCellTextBox";
            this.xCellTextBox.Size = new System.Drawing.Size(132, 22);
            this.xCellTextBox.TabIndex = 33;
            // 
            // gridOptionsGroupBox
            // 
            this.gridOptionsGroupBox.Controls.Add(this.boundaryLabel);
            this.gridOptionsGroupBox.Controls.Add(this.NeighborComboBox);
            this.gridOptionsGroupBox.Controls.Add(this.xCellTextBox);
            this.gridOptionsGroupBox.Controls.Add(this.boundaryComboBox);
            this.gridOptionsGroupBox.Controls.Add(this.neighborhoodLabel);
            this.gridOptionsGroupBox.Controls.Add(this.yCellTextBox);
            this.gridOptionsGroupBox.Controls.Add(this.clearButton);
            this.gridOptionsGroupBox.Controls.Add(this.xNumberLabel);
            this.gridOptionsGroupBox.Controls.Add(this.resizeGridButton);
            this.gridOptionsGroupBox.Controls.Add(this.yNumberLabel);
            this.gridOptionsGroupBox.Location = new System.Drawing.Point(1092, 171);
            this.gridOptionsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.gridOptionsGroupBox.Name = "gridOptionsGroupBox";
            this.gridOptionsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.gridOptionsGroupBox.Size = new System.Drawing.Size(281, 229);
            this.gridOptionsGroupBox.TabIndex = 56;
            this.gridOptionsGroupBox.TabStop = false;
            this.gridOptionsGroupBox.Text = "Opcje siatki";
            // 
            // gridViewGroupBox
            // 
            this.gridViewGroupBox.Controls.Add(this.zoomTrackBar);
            this.gridViewGroupBox.Controls.Add(this.speedBar);
            this.gridViewGroupBox.Controls.Add(this.speedLabel);
            this.gridViewGroupBox.Controls.Add(this.zoomLabel);
            this.gridViewGroupBox.Controls.Add(this.gridCheckBox);
            this.gridViewGroupBox.Location = new System.Drawing.Point(1092, 16);
            this.gridViewGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewGroupBox.Name = "gridViewGroupBox";
            this.gridViewGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.gridViewGroupBox.Size = new System.Drawing.Size(281, 148);
            this.gridViewGroupBox.TabIndex = 57;
            this.gridViewGroupBox.TabStop = false;
            this.gridViewGroupBox.Text = "Widok siatki";
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
            this.executionGroupBox.Location = new System.Drawing.Point(1092, 408);
            this.executionGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.executionGroupBox.Name = "executionGroupBox";
            this.executionGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.executionGroupBox.Size = new System.Drawing.Size(281, 181);
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
            this.aliveRulesTextBox.Leave += new System.EventHandler(this.aliveRulesTextBox_TextChanged);
            // 
            // deadRulesTextBox
            // 
            this.deadRulesTextBox.Location = new System.Drawing.Point(129, 66);
            this.deadRulesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.deadRulesTextBox.Name = "deadRulesTextBox";
            this.deadRulesTextBox.Size = new System.Drawing.Size(138, 22);
            this.deadRulesTextBox.TabIndex = 48;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 784);
            this.Controls.Add(this.executionGroupBox);
            this.Controls.Add(this.gridViewGroupBox);
            this.Controls.Add(this.errLabel);
            this.Controls.Add(this.gridOptionsGroupBox);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            this.gridOptionsGroupBox.ResumeLayout(false);
            this.gridOptionsGroupBox.PerformLayout();
            this.gridViewGroupBox.ResumeLayout(false);
            this.gridViewGroupBox.PerformLayout();
            this.executionGroupBox.ResumeLayout(false);
            this.executionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label errLabel;
        private System.Windows.Forms.Label zoomLabel;
        private System.Windows.Forms.TrackBar zoomTrackBar;
        private System.Windows.Forms.CheckBox gridCheckBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label neighborhoodLabel;
        private System.Windows.Forms.Label boundaryLabel;
        private System.Windows.Forms.ComboBox boundaryComboBox;
        private System.Windows.Forms.ComboBox NeighborComboBox;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TrackBar speedBar;
        private System.Windows.Forms.Label xNumberLabel;
        private System.Windows.Forms.Label yNumberLabel;
        private System.Windows.Forms.Button resizeGridButton;
        private System.Windows.Forms.TextBox yCellTextBox;
        private System.Windows.Forms.TextBox xCellTextBox;
        private System.Windows.Forms.GroupBox gridOptionsGroupBox;
        private System.Windows.Forms.GroupBox gridViewGroupBox;
        private System.Windows.Forms.GroupBox executionGroupBox;
        private System.Windows.Forms.Label deadRulesLabel;
        private System.Windows.Forms.TextBox aliveRulesTextBox;
        private System.Windows.Forms.TextBox deadRulesTextBox;
        private System.Windows.Forms.Button nextStepCAButton;
        private System.Windows.Forms.Button stopCAButton;
        private System.Windows.Forms.Button runCAButton;
        private System.Windows.Forms.Label aliveRulesLlabel;
    }
}

