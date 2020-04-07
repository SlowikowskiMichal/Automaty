using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{

    public partial class Form1 : Form
    {
        GridController GridController;
        
        float cellXSize;
        float cellYSize;
        Color BackgroundColor = Color.White;
        Bitmap nextImage;

        bool CurrentlyDrawing;

        SolidBrush BackGroundBrush;
        SolidBrush ForeGround;

        int zoom;
        bool drawGrid;
        
        string errMsg = "";

        Task CASimulationTask;

        public Form1()
        {
            InitializeComponent();
            GridController = new GridController(100, 100, 0, 0);

            boundaryComboBox.SelectedIndex = 0;
            NeighborComboBox.SelectedIndex = 0;

            xCellTextBox.Text = Grid.SizeX.ToString();
            yCellTextBox.Text = Grid.SizeY.ToString();

            BackGroundBrush = new SolidBrush(Color.White);
            ForeGround = new SolidBrush(Color.Blue);


            CASimulationTask = null;

            //GRID VIEW
            zoom = zoomTrackBar.Value;
            cellXSize = zoom;
            cellYSize = zoom;
            drawGrid = gridCheckBox.Checked;

            nextImage = new Bitmap((int)cellXSize * Grid.SizeX, (int)cellYSize * Grid.SizeY);
            pictureBox1.Image = nextImage;

            DrawGrid();
            pictureBox1.Refresh();
        }

        ~Form1()
        {
            BackGroundBrush.Dispose();
            ForeGround.Dispose();
        }


            //--------------------------------------------------------------------------
            //RYSOWANIE
        void DrawGrid(Grid gridToDraw = null)
        {
            CurrentlyDrawing = true;
            if (gridToDraw == null)
            {
                gridToDraw = GridController.GetGrid();
            }
            Action<int,int, SolidBrush> drawAction;

            if (drawGrid)
            {
                drawAction = new Action<int,int, SolidBrush>(DrawGridWithBorder);
            }
            else
            {
                drawAction = new Action<int, int, SolidBrush>(DrawGridWithoutBorder);
            }

            for (int i = 0; i < Grid.SizeX; i++)
            {
                for (int j = 0; j < Grid.SizeY; j++)
                {
                    if (gridToDraw.Cells[i, j].State == 1)
                    {
                        drawAction.Invoke(i, j, ForeGround);
                    }
                    else
                    {
                        drawAction.Invoke(i, j, BackGroundBrush);
                    }
                }
            }

            pictureBox1.Refresh();
            CurrentlyDrawing = false;
        }
        void DrawGridWithBorder(int x, int y, SolidBrush brush)
        {
            Graphics.FromImage(nextImage).
                FillRectangle(brush,
                x * cellXSize + 1, y * cellYSize + 1,
                cellXSize - 2, cellYSize - 2);

        }

        void DrawGridWithoutBorder(int x, int y, SolidBrush brush)
        {
            Graphics.FromImage(nextImage).
                FillRectangle(brush,
                x * cellXSize, y * cellYSize,
                cellXSize, cellYSize);
        }

 
        //PICTUREBOX
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            errLabel.Text = errMsg;
            e.Graphics.DrawImage(nextImage, 0, 0, nextImage.Width, nextImage.Height);
            errMsg = "";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Left)
            {
                int x = (int)(me.X / cellXSize);
                int y = (int)(me.Y / cellYSize);
                if (x >= Grid.SizeX || x < 0
                    || y >= Grid.SizeY || y < 0)
                {
                    return;
                }

                GridController.GridClicked(x, y);

                DrawGrid();
            }
        }

        //GRID VIEW
        private void zoomTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            int zoomBuff = zoomTrackBar.Value;
            if(GridController.IsSimulationRunning())
            {
                zoomTrackBar.Value = zoom;
                return;
            }

            if (zoom == zoomBuff)
            {
                return;
            }
            zoom = zoomBuff;

            cellXSize = zoom;
            cellYSize = zoom;
            
            nextImage = new Bitmap((int)cellXSize * Grid.SizeX, (int)cellYSize * Grid.SizeY);
            
            DrawGrid();
            
            pictureBox1.Image = nextImage;
            pictureBox1.Refresh();
        }
        private void gridCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GridController.IsSimulationRunning())
            {
                gridCheckBox.Checked = drawGrid;
                return;
            }
            drawGrid = gridCheckBox.Checked;

            DrawGrid();
            pictureBox1.Refresh();
        }

        //GRID OPTIONS
        private void resizeGridButton_Click(object sender, EventArgs e)
        {

            int sizeX;
            int sizeY;
            if (!int.TryParse(xCellTextBox.Text, out sizeX) || !int.TryParse(yCellTextBox.Text, out sizeY))
            {
                xCellTextBox.Text = Grid.SizeX.ToString();
                yCellTextBox.Text = Grid.SizeY.ToString();
                return;
            }

            GridController.ResizeGrid(sizeX, sizeY);
            
            nextImage = new Bitmap((int)cellXSize * Grid.SizeX, (int)cellYSize * Grid.SizeY);
            DrawGrid();

            pictureBox1.Size = new Size(nextImage.Size.Width, nextImage.Size.Height);
            pictureBox1.Image = nextImage;
            pictureBox1.Refresh();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            GridController.ClearGrid();
            DrawGrid();
            pictureBox1.Image = nextImage;
            pictureBox1.Refresh();
        }
        private void boundaryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridController.SetBoundaryCondition(boundaryComboBox.SelectedIndex);
        }
        private void NeighborComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridController.SetNeighborhoodType(NeighborComboBox.SelectedIndex);
        }

        //ENABLED/DISABLED
        private void EnableGui(bool flag)
        {
            gridViewGroupBox.Enabled = flag;
            gridOptionsGroupBox.Enabled = flag;
        }

        private void aliveRulesTextBox_TextChanged(object sender, EventArgs e)
        {
            char[] separators = new char[] { ' ', ',', ';' };
            List<string> alive = aliveRulesTextBox.Text.Split(separators).Where(v => v != string.Empty).ToList();
            List<string> dead = deadRulesTextBox.Text.Split(separators).Where(v => v != string.Empty).ToList();
            SetupRuleTextBox(aliveRulesTextBox, alive);
            dead.RemoveAll(v => alive.Contains(v));
            SetupRuleTextBox(deadRulesTextBox, dead);

            GridController.SetAliveRule(alive.Select(v => int.Parse(v)).ToList());
            GridController.SetDeadRule(dead.Select(v => int.Parse(v)).ToList());
        }

        private void SetupRuleTextBox(TextBox textBox, List<string> list, string separator = ";")
        {
            list = list.Where(v => v.All(char.IsDigit)).ToList();
            textBox.Text = string.Join(separator, list);
        }

        private void deadRulesTextBox_TextChanged(object sender, EventArgs e)
        {
            char[] separators = new char[] { ' ', ',', ';' };
            List<string> alive = aliveRulesTextBox.Text.Split(separators).Where(v => v != string.Empty).ToList();
            List<string> dead = deadRulesTextBox.Text.Split(separators).Where(v => v != string.Empty).ToList();
            SetupRuleTextBox(deadRulesTextBox, dead);
            alive.RemoveAll(v => dead.Contains(v));
            SetupRuleTextBox(aliveRulesTextBox, alive);

            GridController.SetAliveRule(alive.Select(v => int.Parse(v)).ToList());
            GridController.SetDeadRule(dead.Select(v => int.Parse(v)).ToList());
        }

        private async void runCAButton_Click(object sender, EventArgs e)
        {
            EnableGui(false);

            var progress = new Progress<Grid>(grid =>
            {
                if(!CurrentlyDrawing)
                    DrawGrid(grid);
                
            });
            if(CASimulationTask != null)
            {
                return;
            }

            CASimulationTask = Task.Factory.StartNew(() => GridController.RunCASimulation(progress),
                TaskCreationOptions.LongRunning);
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            GridController.StopCASimulation();

            CASimulationTask.Wait();
            CASimulationTask.Dispose();
            CASimulationTask = null;
            EnableGui(true);
        }
        private async void nextStepCAButton_Click(object sender, EventArgs e)
        {
            EnableGui(false);
            var progress = new Progress<Grid>(grid =>
            {
                DrawGrid(grid);
            });

            await Task.Factory.StartNew(() => GridController.NextStepCASimulation(progress),
                TaskCreationOptions.LongRunning);
            EnableGui(true);
        }
    }
}
