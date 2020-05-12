using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab7.NeighborhoodManager;

namespace Lab7
{

    public partial class Automat2D : Form
    {


        GridController GridController;

        SolidBrush[] GridBrushes = new SolidBrush[] { new SolidBrush(Color.White), new SolidBrush(Color.Black) };
        SolidBrush GridBrush = new SolidBrush(Color.LightGray);

        int Zoom;
        bool DrawGridValue;
        int mouseX = -1, mouseY = -1;
        int clickStatus = -1;
        bool mouseDown = false;
        int CurrentNucleonId = 0;

        List<Point> pointsToDraw;
        public Automat2D()
        {
            InitializeComponent();
            CurrentNucleonId = 0;
            GridController = GridController.GetInstance();
            GridController.SetNeighborhoodType(0);
            boundaryComboBox.SelectedIndex = 0;
            randomNeighborhoodComboBox.SelectedIndex = 0;
            NeighborhoodCheckedListBox.SetItemChecked(0,true);

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

        void ChangeGridCellStatus(int x, int y, int cellStatus)
        {

            if (x >= Grid.SizeX || x < 0
                || y >= Grid.SizeY || y < 0)
            {
                return;
            }
            if(cellStatus == 0)
            {
                GridController.ResetCell(x, y);
            }
            else
            {
                GridController.SetCellAsActive(x, y, CurrentNucleonId);
            }
            
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
            GridController.ZoomChanged();
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
        private void boundaryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridController.SetBoundaryCondition(boundaryComboBox.SelectedIndex);
        }

        //ENABLED/DISABLED
        private void EnableGui(bool flag)
        {
            gridViewGroupBox.Enabled = flag;
            gridOptionsGroupBox.Enabled = flag;
            simulationOptionsGroupBox.Enabled = flag;
        }


        private async void runCAButton_Click(object sender, EventArgs e)
        {
            
            if (GridController.IsSimulationRunning())
            {
                ShowMyDialogBox("Nie można uruchomić kolejnej symulacji, podczas gdy jedna jest już uruchomiona.");
                return;
            }

            EnableGui(false);
            GridController.Neighborhood.SetNeighborhood(NeighborhoodCheckedListBox.CheckedIndices.Cast<int>().ToList());
            var progress = new Progress<Bitmap>(bmp =>
            {
                DrawGrid(bmp);
            });
            
            await Task.Factory.StartNew(() => GridController.RunCASimulation(progress),
                TaskCreationOptions.LongRunning);
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
            GridController.Neighborhood.SetNeighborhood(NeighborhoodCheckedListBox.CheckedIndices.Cast<int>().ToList());
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

        private void randomThresholdTextBox_Leave(object sender, EventArgs e)
        {
            SetThresholdTextBox();  
        }

        private void SetThresholdTextBox()
        {
            char[] separators = new char[] { ' ', ',', ';' };

            List<string> thresholdValues = randomThresholdTextBox.Text.Split(separators).Where(v => v != string.Empty).ToList();

            List<double> thresholdList = thresholdValues.Select(v => Math.Round(Math.Min(Math.Max(Convert.ToSingle(v.Replace('.', ',')), 0.0), 1.0), 2)).ToList();

            int numberOfThresholds = DetermineNumberOfThresholds();

            if (numberOfThresholds < thresholdList.Count)
            {
                thresholdList.RemoveRange(numberOfThresholds, thresholdList.Count - numberOfThresholds);
            }
            else if (numberOfThresholds > thresholdList.Count)
            {
                for (int i = thresholdList.Count; i < numberOfThresholds; i++)
                {
                    thresholdList.Add(0);
                }
            }

            if (GridController.Neighborhood.RandomMode != RandomNeighborhoodMode.Toggle && GridController.Neighborhood.RandomMode != RandomNeighborhoodMode.Direction)
            {
                double val = 0f;
                for (int i = 0; i < thresholdList.Count; i++)
                {
                    if (val + thresholdList[i] > 1.0)
                    {
                        thresholdList[i] = Math.Max(1.0 - val, 0.0);
                    }
                    val += thresholdList[i];
                }

                if (val < 1 && thresholdList.Count > 0)
                {
                    thresholdList[0] += 1 - val;
                }

            }
            GridController.Neighborhood.RandomThresholdList = thresholdList;

            randomThresholdTextBox.Text = string.Join(";", thresholdList.Select(v => v.ToString().Replace(',', '.')));
        }

        private int DetermineNumberOfThresholds()
        {
            switch(randomNeighborhoodComboBox.SelectedIndex)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                case 2:
                    return GridController.Neighborhood.CurrentNeighborhoods.Count();
                case 3:
                    return GridController.Neighborhood.GetNumberOfNeighbors();
                default:
                    return 1;
            }
        }

        private void randomNeighborhoodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            randomThresholdTextBox_Leave(sender, e);
            GridController.Neighborhood.RandomMode = (RandomNeighborhoodMode)randomNeighborhoodComboBox.SelectedIndex;
            if(!GridController.Neighborhood.IsRandomModeMultiNeighborhood() && NeighborhoodCheckedListBox.CheckedIndices.Count > 1)
            {
                for (int i = 0; i < NeighborhoodCheckedListBox.Items.Count; i++)
                {
                    NeighborhoodCheckedListBox.SetItemChecked(i, false);
                }
                NeighborhoodCheckedListBox.SetItemChecked(0,true);
                GridController.Neighborhood.SetNeighborhood(new List<int>() { 0 }); ;
            }
            GridController.Neighborhood.SetNeighborhood(NeighborhoodCheckedListBox.CheckedIndices.Cast<int>().ToList());
        }

        private void NeighborhoodCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(!GridController.Neighborhood.IsRandomModeMultiNeighborhood())
            {
                if (e.NewValue == CheckState.Checked && NeighborhoodCheckedListBox.CheckedItems.Count > 0)
                {
                    NeighborhoodCheckedListBox.ItemCheck -= NeighborhoodCheckedListBox_ItemCheck;
                    NeighborhoodCheckedListBox.SetItemChecked(NeighborhoodCheckedListBox.CheckedIndices[0], false);
                    NeighborhoodCheckedListBox.ItemCheck += NeighborhoodCheckedListBox_ItemCheck;
                }
            }
            var list = NeighborhoodCheckedListBox.CheckedIndices.Cast<int>().ToList();
            if (e.NewValue == CheckState.Unchecked)
            {
                if (NeighborhoodCheckedListBox.CheckedItems.Count == 1)
                {
                    e.NewValue = CheckState.Checked;
                    GridController.Neighborhood.SetNeighborhood(new List<int>() { e.Index });
                }
                else
                {
                    list.Remove(e.Index);
                    GridController.Neighborhood.SetNeighborhood(list);
                }

            }
            else
            {
                list.Add(e.Index);
                GridController.Neighborhood.SetNeighborhood(list);
            }
            SetThresholdTextBox();
        }

        private void nucleonAmountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if(CurrentNucleonId >= nucleonAmountNumericUpDown.Value)
            {
                CurrentNucleonId = 0;
            }
            GridController.EraseNucleonsWithHigherId((int)nucleonAmountNumericUpDown.Value);
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

        private void gridPictureBox_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CurrentNucleonId = ++CurrentNucleonId % (int)nucleonAmountNumericUpDown.Value;
            }

            currentNucleonIdValueLabel.Text = string.Format("{0}", CurrentNucleonId + 1);
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
                foreach(Point p in pointsToDraw)
                {
                    ChangeGridCellStatus(p.X, p.Y, clickStatus);
                }
                mouseX = -1;
                mouseY = -1;
                clickStatus = -1;
                mouseDown = false;
                pointsToDraw.Clear();

                DrawGrid(this.GridController.GetGridImage());
            }
        }
    }
}
