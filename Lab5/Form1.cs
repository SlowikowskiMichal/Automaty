using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab5.NeighborhoodManager;

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

            SetAliveRuleFromTextBox();
            SetDeadRuleFromTextBox();
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
        private void boundaryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridController.SetBoundaryCondition(boundaryComboBox.SelectedIndex);
        }

        //ENABLED/DISABLED
        private void EnableGui(bool flag)
        {
            gridViewGroupBox.Enabled = flag;
            gridOptionsGroupBox.Enabled = flag;
        }

        private void aliveRulesTextBox_TextChanged(object sender, EventArgs e)
        {
            SetAliveRuleFromTextBox();
        }

        private void SetAliveRuleFromTextBox()
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
            SetDeadRuleFromTextBox();
        }

        private void SetDeadRuleFromTextBox()
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
        /*
        private void gridPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.None)
            {
                int x = (int)(e.X / zoom);
                int y = (int)(e.Y / zoom);


                if (mouseX != x && mouseY != y && clickStatus == GridController.GetCellStatus(x, y))
                {
                    mouseX = x;
                    mouseY = y;
                    ChangeGridCellStatus(x, y, clickStatus);
                }

            }
        }
        */



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
