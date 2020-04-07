using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Lab3
{

    public partial class Form1 : Form
    {
        readonly static object synLock = new object();
        //GRID
        const int sizeX = 1;
        const int sizeY = 1;
        float cellXSize;
        float cellYSize;
        Grid currentGrid;
        Grid nextStepGrid;
        int emptyCount = 0;
        //RULES
        List<int> AliveRule;
        List<int> DeadRule;
        //IMAGE
        readonly Neighborhood[] implementedNeighborhood = {new MooresNeighborhood(), new NeumannNeighborhood(),
            new HexagonalLeftNeighborhood(), new HexagonalRightNeighborhood(), new HexagonalRandomNeighborhood(),
            new PentagonalLeftNeighborhood(), new PentagonalRightNeighborhood(), new PentagonalTopNeighborhood(),
            new PentagonalBottomNeighborhood(), new PentagonalRandomNeighborhood() };
        Color BackgroundColor = Color.White;
        Bitmap nextImage;
        //GRID VIEW
        int zoom;
        bool drawGrid;
        //GRID OPTIONS
        BoundaryConditions boundaryCondition;
        Neighborhood neighborhood;
        //FILL
        int idZiarno = 0;
        int nPopulation;
        //SIMULATION
        bool running = false;
        bool mcRunning = false;
        int mcStep = 0;
        //Label
        string errMsg = "";

        public Form1()
        {
            InitializeComponent();

            //GRID
            currentGrid = new Grid();
            nextStepGrid = new Grid();
            xCellTextBox.Text = Grid.SizeX.ToString();
            yCellTextBox.Text = Grid.SizeY.ToString();

            //RULES
            AliveRule = new List<int>();
            DeadRule = new List<int>();
            //GRID VIEW
            zoom = zoomTrackBar.Value;
            cellXSize = sizeX * zoom;
            cellYSize = sizeY * zoom;
            drawGrid = gridCheckBox.Checked;
            //GRID OPTIONS
            boundaryComboBox.SelectedIndex = 0;
            boundaryCondition = (BoundaryConditions)boundaryComboBox.SelectedIndex;
            NeighborComboBox.SelectedIndex = 0;
            neighborhood = implementedNeighborhood[NeighborComboBox.SelectedIndex];

            nextImage = new Bitmap((int)cellXSize * Grid.SizeX, (int)cellYSize * Grid.SizeY);
            pictureBox1.Image = nextImage;
            InitializeGrid();
            pictureBox1.Refresh();
        }

        //--------------------------------------------------------------------------
        //RYSOWANIE
        void InitializeGrid()
        {
            lock (synLock)
            {
                Graphics.FromImage(nextImage).Clear(Color.Black);
            }
            for (int i = 0; i < Grid.SizeX; i++)
            {
                for (int j = 0; j < Grid.SizeY; j++)
                {
                    if (currentGrid.Cells[i, j].State == 1)
                    {
                        FillCell(i, j, Color.Blue);
                    }
                    else
                    {
                        FillCell(i, j, Color.White);
                    }
                }
            }
        }
        void FillCell(int x, int y, Color color)
        {
            lock (synLock)
            {
                SolidBrush brush = new SolidBrush(color);

                if (drawGrid)
                {
                    Graphics.FromImage(nextImage).
                        FillRectangle(brush,
                        x * cellXSize + 1, y * cellYSize + 1,
                        cellXSize - 2, cellYSize - 2);
                }
                else
                {
                    Graphics.FromImage(nextImage).
                        FillRectangle(brush,
                        x * cellXSize, y * cellYSize,
                        cellXSize, cellYSize);
                }
                brush.Dispose();
            }
        }
        void Shuffle<T>(IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        //--------------------------------------------------------------------------
        //ROZROST
        void CalculateNextStep(int startX, int startY, int endX, int endY)
        {
            Random r = new Random();

            List<Point> n;

            for (int x = startX; x < endX; x++)
            {
                for (int y = startY; y < endY; y++)
                {
                    n = neighborhood.GetNeighborhood(x, y, Grid.SizeX, Grid.SizeY, boundaryCondition);

                    int aliveNeighborhoodsCount = n.Where(p => currentGrid.Cells[p.X, p.Y].State == 1).Count();

                    if (currentGrid.Cells[x, y].State == 1)
                    {
                        if (DeadRule.Contains(aliveNeighborhoodsCount))
                        {
                            lock (synLock)
                            {
                                nextStepGrid.Cells[x, y].ChangeState();
                            }
                            FillCell(x, y, Color.White);
                        }
                    }
                    else
                    {
                        if (AliveRule.Contains(aliveNeighborhoodsCount))
                        {
                            lock (synLock)
                            {
                                nextStepGrid.Cells[x, y].ChangeState();
                            }
                            FillCell(x, y, Color.Blue);
                        }
                    }
                }
            }
        }
        void Continue()
        {
            int nThreads = 4;
            Thread[] calculations = new Thread[nThreads];
            int x = Grid.SizeX / 2;
            int y = Grid.SizeY / 2;

            long current = DateTime.Now.Ticks;
            while (running)
            {
                nextStepGrid.Copy(currentGrid, 0, 0, Grid.SizeX, Grid.SizeY);
                calculations[0] = new Thread(() => CalculateNextStep(0, 0, x, y));
                calculations[1] = new Thread(() => CalculateNextStep(x, 0, Grid.SizeX, y));
                calculations[2] = new Thread(() => CalculateNextStep(0, y, x, Grid.SizeY));
                calculations[3] = new Thread(() => CalculateNextStep(x, y, Grid.SizeX, Grid.SizeY));
                foreach (Thread task in calculations)
                {
                    task.Start();
                }
                foreach (Thread task in calculations)
                {
                    task.Join();
                }
                currentGrid.Copy(nextStepGrid);
                this.Invoke((MethodInvoker)delegate
                {
                    pictureBox1.Refresh();
                });
            }
            running = false;
            this.Invoke((MethodInvoker)delegate
            {
                GUI(!running);
            });
        }
 
        //PICTUREBOX
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            lock (synLock)
            {
                errLabel.Text = errMsg;
                e.Graphics.DrawImage(nextImage, 0, 0, nextImage.Width, nextImage.Height);
                errMsg = "";
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (running || mcRunning)
            {
                return;
            }
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
                lock (synLock)
                {
                    currentGrid.ChangeCellValue(x, y);
                    currentGrid.Cells[x, y].Id = idZiarno;
                }
                if (currentGrid.Cells[x, y].State != 0)
                {
                    FillCell(x, y, Color.Blue);
                }
                else
                {
                    FillCell(x, y, BackgroundColor);
                }
            }
            else
            {
                idZiarno++;
                idZiarno = idZiarno % nPopulation;
            }

            pictureBox1.Refresh();
        }

        //GRID VIEW
        private void zoomTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            int zoomBuff = zoomTrackBar.Value;
            if (zoom == zoomBuff)
            {
                return;
            }
            zoom = zoomBuff;

            cellXSize = sizeX * zoom;
            cellYSize = sizeY * zoom;
            lock (synLock)
            {
                nextImage = new Bitmap((int)cellXSize * Grid.SizeX, (int)cellYSize * Grid.SizeY);
            }
            int cc = emptyCount;
            InitializeGrid();
            emptyCount = cc;
            lock (synLock)
            {
                pictureBox1.Image = nextImage;
            }
            pictureBox1.Refresh();
        }
        private void gridCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            lock (synLock)
            {
                drawGrid = gridCheckBox.Checked;
            }
            int cc = emptyCount;
            InitializeGrid();
            emptyCount = cc;

            pictureBox1.Refresh();
        }

        //GRID OPTIONS
        private void resizeGridButton_Click(object sender, EventArgs e)
        {
            if (running || mcRunning)
            {
                return;
            }
            int sizeX;
            int sizeY;
            int.TryParse(xCellTextBox.Text, out sizeX);
            int.TryParse(yCellTextBox.Text, out sizeY);

            currentGrid.Resize(sizeX, sizeY);
            nextStepGrid.Resize(sizeX, sizeY);

            nextImage = new Bitmap((int)cellXSize * Grid.SizeX, (int)cellYSize * Grid.SizeY);
            InitializeGrid();

            pictureBox1.Size = new Size(nextImage.Size.Width, nextImage.Size.Height);
            pictureBox1.Image = nextImage;
            pictureBox1.Refresh();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            lock (synLock)
            {
                currentGrid.Clear();
                nextStepGrid.Clear();
            }
            InitializeGrid();
            lock (synLock)
            {
                pictureBox1.Image = nextImage;
            }
            pictureBox1.Refresh();
        }
        private void boundaryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            boundaryCondition = (BoundaryConditions)boundaryComboBox.SelectedIndex;
        }
        private void NeighborComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            neighborhood = implementedNeighborhood[NeighborComboBox.SelectedIndex];
        }

       
        private void fillRunButton_Click(object sender, EventArgs e)
        {
            if (running)
                return;
            running = true;
            GUI(!running);
            Thread calculations = new Thread(Continue);
            calculations.Start();
        }
        private void stopFillButton_Click(object sender, EventArgs e)
        {
            running = false;
            GUI(!running);
        }
        private void nextFillButton_Click(object sender, EventArgs e)
        {
            if (running)
                return;
            CalculateNextStep(0, 0, Grid.SizeX, Grid.SizeY);
            currentGrid.Copy(nextStepGrid);
            pictureBox1.Refresh();
        }


        //ENABLED/DISABLED
        private void GUI(bool flag)
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

            AliveRule = alive.Select(v => int.Parse(v)).ToList();
            DeadRule = dead.Select(v => int.Parse(v)).ToList();
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

            AliveRule = alive.Select(v => int.Parse(v)).ToList();
            DeadRule = dead.Select(v => int.Parse(v)).ToList();
        }

        private void runCAButton_Click(object sender, EventArgs e)
        {
            if (running)
                return;
            running = true;
            GUI(!running);
            Thread calculations = new Thread(Continue);
            calculations.Start();
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            mcRunning = false;
            GUI(!mcRunning);
        }
        private void nextStepCAButton_Click(object sender, EventArgs e)
        {

            if (!running)
            {
                OneStepCalculations();
            }
        }

        private void OneStepCalculations()
        {
            int nThreads = 4;
            Thread[] calculations = new Thread[nThreads];
            int x = Grid.SizeX / 2;
            int y = Grid.SizeY / 2;

            running = true;
            nextStepGrid.Copy(currentGrid, 0, 0, Grid.SizeX, Grid.SizeY);
            calculations[0] = new Thread(() => CalculateNextStep(0, 0, x, y));
            calculations[1] = new Thread(() => CalculateNextStep(x, 0, Grid.SizeX, y));
            calculations[2] = new Thread(() => CalculateNextStep(0, y, x, Grid.SizeY));
            calculations[3] = new Thread(() => CalculateNextStep(x, y, Grid.SizeX, Grid.SizeY));
            foreach (Thread task in calculations)
            {
                task.Start();
            }
            foreach (Thread task in calculations)
            {
                task.Join();
            }
            currentGrid.Copy(nextStepGrid);

            pictureBox1.Refresh();


            running = false;
            GUI(!running);
        }
    }
}
