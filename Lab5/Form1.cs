using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{

    public partial class Automat2D : Form
    {


        GridController GridController;

        SolidBrush[] GridBrushes = new SolidBrush[] { new SolidBrush(Color.White), new SolidBrush(Color.Green) };
        SolidBrush GridBrush = new SolidBrush(Color.LightGray);

        int Zoom;
        bool DrawGridValue;
        int mouseX = -1, mouseY = -1;
        int clickStatus = -1;
        bool mouseDown = false;
        List<Point> pointsToDraw;
        string errMsg = "";
        public Automat2D()
        {
            InitializeComponent();
            GridController = GridController.GetInstance();

            pointsToDraw = new List<Point>();
            xCellTextBox.Text = Grid.SizeX.ToString();
            yCellTextBox.Text = Grid.SizeY.ToString();

            //GRID VIEW
            Zoom = zoomTrackBar.Value;
            GridController.Zoom = Zoom;
;
            DrawGridValue = gridCheckBox.Checked;
            GridController.DrawGrid = DrawGridValue;
            Bitmap gridToDraw = this.GridController.GetGridImage();
            this.gridPictureBox.Size = new Size(gridToDraw.Width, gridToDraw.Height);
            DrawGrid(gridToDraw);
        }

        //--------------------------------------------------------------------------
        //RYSOWANIE
        void DrawGrid(Bitmap gridToDraw)
        {
            this.gridPictureBox.Image = gridToDraw;
        }


        void drawChangedCells(int x, int y)
        {
            using (var g = Graphics.FromImage(this.gridPictureBox.Image))
            {
                Action<int, int, SolidBrush, Graphics> drawAction;

                if (DrawGridValue && Zoom > 3)
                {
                    drawAction = new Action<int, int, SolidBrush, Graphics>(DrawGridWithBorder);
                }
                else
                {
                    drawAction = new Action<int, int, SolidBrush, Graphics>(DrawGridWithoutBorder);
                }
                drawAction.Invoke(x, y, GridBrushes[clickStatus], g);
                gridPictureBox.Refresh();
            }
        }

        void DrawGridWithBorder(int x, int y, Brush b, Graphics panelGraphics)
        {
            panelGraphics.
                FillRectangle(b,
                x * Zoom + 1, y * Zoom + 1,
                Zoom - 2, Zoom - 2);

        }

        void DrawGridWithoutBorder(int x, int y, Brush b, Graphics panelGraphics)
        {
            panelGraphics.
                FillRectangle(b,
                x * Zoom, y * Zoom,
                Zoom, Zoom);
        }

        void ChangeGridCellStatus(int x, int  y, int status)
        {

            if (x >= Grid.SizeX || x < 0
                || y >= Grid.SizeY || y < 0)
            {
                return;
            }

            GridController.ChangeCellStatus(x, y, status);
        }

        //GRID VIEW
        private void zoomTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            int zoomBuff = zoomTrackBar.Value;
            if(GridController.IsSimulationRunning())
            {
                zoomTrackBar.Value = Zoom;
                return;
            }

            if (Zoom == zoomBuff)
            {
                return;
            }
            Zoom = zoomBuff;

            GridController.Zoom = zoomBuff;
            Bitmap gridToDraw = this.GridController.GetGridImage();
            this.gridPictureBox.Size = new Size(gridToDraw.Width, gridToDraw.Height);
            DrawGrid(gridToDraw);
        }
        private void gridCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GridController.IsSimulationRunning())
            {
                gridCheckBox.Checked = DrawGridValue;
                return;
            }

            DrawGridValue = gridCheckBox.Checked;
            GridController.DrawGrid = DrawGridValue;
            DrawGrid(this.GridController.GetGridImage());
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
            Bitmap gridToDraw = this.GridController.GetGridImage();
            this.gridPictureBox.Size = new Size(gridToDraw.Width, gridToDraw.Height);
            DrawGrid(gridToDraw);
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            GridController.ClearGrid();
            DrawGrid(this.GridController.GetGridImage());

        }

        //ENABLED/DISABLED
        private void EnableGui(bool flag)
        {
            gridViewGroupBox.Enabled = flag;
            gridOptionsGroupBox.Enabled = flag;
        }


        private async void runCAButton_Click(object sender, EventArgs e)
        {
            
            if (GridController.IsSimulationRunning())
            {
                ShowMyDialogBox("Nie można uruchomić kolejnej symulacji, podczas gdy jedna jest już uruchomiona.");
                return;
            }

            EnableGui(false);
            var progress = new Progress<Bitmap>(bmp =>
            {
                DrawGrid(bmp);
            });
            
            await Task.Factory.StartNew(() => GridController.RunCASimulation(progress),
                TaskCreationOptions.LongRunning);
            DrawGrid(this.GridController.GetGridImage());
            EnableGui(true);

        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            GridController.StopCASimulation();
        }
        private async void nextStepCAButton_Click(object sender, EventArgs e)
        {
            if (GridController.IsSimulationRunning())
            {
                ShowMyDialogBox("Nie można uruchomić kolejnej symulacji, podczas gdy jedna jest już uruchomiona.");
                return;
            }
            EnableGui(false);
            var progress = new Progress<Bitmap>(bmp =>
            {
                DrawGrid(bmp);
            });

            await Task.Factory.StartNew(() => GridController.NextStepCASimulation(progress),
                TaskCreationOptions.LongRunning);
            EnableGui(true);
        }


        public void ShowMyDialogBox(string errorMessage)
        {
            DialogResult res = MessageBox.Show(errorMessage, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void gridPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (GridController.IsSimulationRunning())
                {
                    ShowMyDialogBox("Nie można rysować podczas symulacji.");
                    return;
                }
                int x = (int)(e.X / Zoom);
                int y = (int)(e.Y / Zoom);

                if (mouseDown)
                {
                    if (mouseX != x || mouseY != y)
                    {
                        mouseX = x;
                        mouseY = y;
                        pointsToDraw.Add(new Point(x, y));
                        drawChangedCells(x, y);
                    }
                }
                else
                {
                    mouseX = x;
                    mouseY = y;
                    clickStatus = GridController.GetCellStatus(x, y) == 0 ? 1 : 0;
                    pointsToDraw.Add(new Point(x, y));
                    mouseDown = true;
                    drawChangedCells(x, y);
                }
            }
        }

        private void gridPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (GridController.IsSimulationRunning())
            {
                ShowMyDialogBox("Nie można rysować podczas symulacji.");
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                EnableGui(false);
                GridController.LockSimulation(false);
                foreach (Point p in pointsToDraw)
                {
                    ChangeGridCellStatus(p.X, p.Y, clickStatus);
                    ChangeGridCellId(p.X, p.Y, clickStatus);
                }
                if(clickStatus == 1)
                {
                    GridController.AddGrainOriginPoints(pointsToDraw, 1);
                }
                else
                {
                    GridController.RemoveGrainOriginPoints(pointsToDraw);
                }
                mouseX = -1;
                mouseY = -1;
                clickStatus = -1;
                mouseDown = false;
                pointsToDraw.Clear();

                DrawGrid(this.GridController.GetGridImage());
                EnableGui(true);
                GridController.LockSimulation(false);
            }
        }

        private void ChangeGridCellId(int x, int y, int v)
        {
            GridController.ChangeCellId(x, y, v);
        }
    }
}
