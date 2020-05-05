namespace Lab6
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
            this.nextStepCAButton = new System.Windows.Forms.Button();
            this.stopCAButton = new System.Windows.Forms.Button();
            this.runCAButton = new System.Windows.Forms.Button();
            this.gridViewGroupBox = new System.Windows.Forms.GroupBox();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.gridCheckBox = new System.Windows.Forms.CheckBox();
            this.gridOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.xCellTextBox = new System.Windows.Forms.TextBox();
            this.yCellTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.xNumberLabel = new System.Windows.Forms.Label();
            this.resizeGridButton = new System.Windows.Forms.Button();
            this.yNumberLabel = new System.Windows.Forms.Label();
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
            this.gridPanel.Size = new System.Drawing.Size(854, 616);
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
            this.splitContainer.Size = new System.Drawing.Size(1170, 616);
            this.splitContainer.SplitterDistance = 854;
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
            this.settingsPanel.Size = new System.Drawing.Size(312, 616);
            this.settingsPanel.TabIndex = 58;
            // 
            // executionGroupBox
            // 
            this.executionGroupBox.Controls.Add(this.nextStepCAButton);
            this.executionGroupBox.Controls.Add(this.stopCAButton);
            this.executionGroupBox.Controls.Add(this.runCAButton);
            this.executionGroupBox.Location = new System.Drawing.Point(18, 279);
            this.executionGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.executionGroupBox.Name = "executionGroupBox";
            this.executionGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.executionGroupBox.Size = new System.Drawing.Size(281, 98);
            this.executionGroupBox.TabIndex = 56;
            this.executionGroupBox.TabStop = false;
            this.executionGroupBox.Text = "Egzekucja";
            // 
            // nextStepCAButton
            // 
            this.nextStepCAButton.Location = new System.Drawing.Point(183, 23);
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
            this.stopCAButton.Location = new System.Drawing.Point(100, 23);
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
            this.runCAButton.Location = new System.Drawing.Point(8, 23);
            this.runCAButton.Margin = new System.Windows.Forms.Padding(4);
            this.runCAButton.Name = "runCAButton";
            this.runCAButton.Size = new System.Drawing.Size(86, 58);
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
            this.gridOptionsGroupBox.Controls.Add(this.xCellTextBox);
            this.gridOptionsGroupBox.Controls.Add(this.yCellTextBox);
            this.gridOptionsGroupBox.Controls.Add(this.clearButton);
            this.gridOptionsGroupBox.Controls.Add(this.xNumberLabel);
            this.gridOptionsGroupBox.Controls.Add(this.resizeGridButton);
            this.gridOptionsGroupBox.Controls.Add(this.yNumberLabel);
            this.gridOptionsGroupBox.Location = new System.Drawing.Point(17, 142);
            this.gridOptionsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.gridOptionsGroupBox.Name = "gridOptionsGroupBox";
            this.gridOptionsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.gridOptionsGroupBox.Size = new System.Drawing.Size(281, 129);
            this.gridOptionsGroupBox.TabIndex = 56;
            this.gridOptionsGroupBox.TabStop = false;
            this.gridOptionsGroupBox.Text = "Opcje siatki";
            // 
            // xCellTextBox
            // 
            this.xCellTextBox.Location = new System.Drawing.Point(108, 25);
            this.xCellTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.xCellTextBox.Name = "xCellTextBox";
            this.xCellTextBox.Size = new System.Drawing.Size(166, 22);
            this.xCellTextBox.TabIndex = 33;
            // 
            // yCellTextBox
            // 
            this.yCellTextBox.Location = new System.Drawing.Point(108, 57);
            this.yCellTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.yCellTextBox.Name = "yCellTextBox";
            this.yCellTextBox.Size = new System.Drawing.Size(166, 22);
            this.yCellTextBox.TabIndex = 34;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearButton.Location = new System.Drawing.Point(177, 87);
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
            this.xNumberLabel.Location = new System.Drawing.Point(19, 28);
            this.xNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xNumberLabel.Name = "xNumberLabel";
            this.xNumberLabel.Size = new System.Drawing.Size(62, 17);
            this.xNumberLabel.TabIndex = 38;
            this.xNumberLabel.Text = "Kolumny";
            // 
            // resizeGridButton
            // 
            this.resizeGridButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resizeGridButton.Location = new System.Drawing.Point(69, 87);
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
            this.yNumberLabel.Location = new System.Drawing.Point(19, 60);
            this.yNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yNumberLabel.Name = "yNumberLabel";
            this.yNumberLabel.Size = new System.Drawing.Size(59, 17);
            this.yNumberLabel.TabIndex = 37;
            this.yNumberLabel.Text = "Wiersze";
            // 
            // Automat2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 616);
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
        private System.Windows.Forms.Button nextStepCAButton;
        private System.Windows.Forms.Button stopCAButton;
        private System.Windows.Forms.Button runCAButton;
        private System.Windows.Forms.GroupBox gridViewGroupBox;
        private System.Windows.Forms.TrackBar zoomTrackBar;
        private System.Windows.Forms.Label zoomLabel;
        private System.Windows.Forms.CheckBox gridCheckBox;
        private System.Windows.Forms.GroupBox gridOptionsGroupBox;
        private System.Windows.Forms.TextBox xCellTextBox;
        private System.Windows.Forms.TextBox yCellTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label xNumberLabel;
        private System.Windows.Forms.Button resizeGridButton;
        private System.Windows.Forms.Label yNumberLabel;
    }
}

