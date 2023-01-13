using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sorting
{
    public partial class Form1 : Form
    {
        int[] Array, Array1, Array2, Array3, Array4, Array5;
        List<int> ArrayList = new List<int>();
        string Millisecond = "ms";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void отсортироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGrid.AllowUserToAddRows = false;

            DataGridToArray(chart); //представление таблицы данных в массив

            SortingSelection(); //выбор сортировки

            if (!IsAll.Checked)
            {
                ArrayToDataGrid(Array); //представление массива в таблицу данных
            }

            DataGrid.AllowUserToAddRows = true;
        }
        
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable Table = new DataTable();
            Table.Columns.Add("Элементы массива", typeof(int));
            DataGrid.Columns.Clear();
            DataGrid.DataSource = null;
            DataGrid.DataSource = Table;
        }

        private void заполнитьМассивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random Random = new Random();
            int[] RandomArray = new int[100];
            for (int i = 0; i < RandomArray.Length; i++)
            {
                RandomArray[i] = Random.Next(1, 10);
            }
            ArrayToDataGrid(RandomArray);
        }

        private void Swap(Chart c, int[] Array, int i, int j)
        {
            int Temp = Array[i];
            Array[i] = Array[j];
            Array[j] = Temp;
            if (IsVisualized.Checked)
            {
                Invoke(new Action(() => Visualization(c, Array)));
            }
        }

        private bool IsSorted(int[] Array)
        {
            int Count = Array.Length;
            while (--Count >= 1)
            {
                if (Array[Count] < Array[Count - 1])
                {
                    return false;
                }
            }
            return true;
        }

        private void Check()
        {
            if (label1.Text != "")
            {
                ms1.Text = Millisecond;
            }
            if (label2.Text != "")
            {
                ms2.Text = Millisecond;
            }
            if (label3.Text != "")
            {
                ms3.Text = Millisecond;
            }
            if (label4.Text != "")
            {
                ms4.Text = Millisecond;
            }
            if (label5.Text != "")
            {
                ms5.Text = Millisecond;
            }
        }

        public void Visualization(Chart c ,int[] Array)
        {
            c.Series[0].Points.Clear();
            for (int i = 0; i < Array.Length; i++)
            {
                c.Series[0].Points.AddY(Array[i]);
            }
            Wait(0.001);
        }

        private void Wait(double seconds)
        {
            int ticks = System.Environment.TickCount + (int)Math.Round(seconds * 1000.0);
            while (System.Environment.TickCount < ticks)
            {
                Application.DoEvents();
            }
        }

        public async Task SortingSelection()
        {
            if (!IsAll.Checked)
            {
                if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked)
                {
                    if (checkBox1.Checked)
                    {
                        BubbleSort(Array);
                        Visualization(bubbleChart, Array);
                    }
                    if (checkBox2.Checked)
                    {
                        InsertionSort(Array);
                        Visualization(insertionChart, Array);
                    }
                    if (checkBox3.Checked)
                    {
                        CoctailSort(Array);
                        Visualization(coctailChart, Array);
                    }
                    if (checkBox4.Checked)
                    {
                        QuickSort(Array, 0, Array.Length-1);
                        Visualization(quickChart, Array);
                    }
                    if (checkBox5.Checked)
                    {
                        BogoSort(Array);
                        Visualization(chart, Array);
                    }

                }
                else
                {
                    MessageBox.Show("Сортировка не выбрана");
                }
            }
            else
            {
                Stopwatch SW = new Stopwatch();
                SW.Start();
                await Task.Run(() => BubbleSort(Array1));
                SW.Stop();
                ToLabel(label1, SW.ElapsedMilliseconds.ToString());
                ArrayToDataGrid(Array1);

                SW.Restart();
                await Task.Run(() => InsertionSort(Array2));
                SW.Stop();
                ToLabel(label2, SW.ElapsedMilliseconds.ToString());
                ArrayToDataGrid(Array2);

                SW.Restart();
                await Task.Run(() => CoctailSort(Array3));
                SW.Stop();
                ToLabel(label3, SW.ElapsedMilliseconds.ToString());
                ArrayToDataGrid(Array3);

                SW.Restart();
                await Task.Run(() => QuickSort(Array4, 0, Array4.Length-1));
                SW.Stop();
                ToLabel(label4, SW.ElapsedMilliseconds.ToString());
                ArrayToDataGrid(Array4);

                //await Task.Run(() => BogoSort(Array5));
                Check();
                Visualization(chart, Array1);
            }
        }

        private void DataGridToArray(Chart c)
        {
            if (ArrayList.Count != 0)
            {
                ArrayList.Clear();
            }
            for (int i = 0; i < DataGrid.RowCount; i++)
            {
                ArrayList.Add(Convert.ToInt32(DataGrid[0, i].Value));
            }
            Array = ArrayList.ToArray();
            Array1 = ArrayList.ToArray();
            Array2 = ArrayList.ToArray();
            Array3 = ArrayList.ToArray();
            Array4 = ArrayList.ToArray();
            Array5 = ArrayList.ToArray();
            Stopwatch SW = new Stopwatch();
            Visualization(c, Array);
        }

        public void ArrayToDataGrid(int[] Array)
        {
            Check();
            DataTable Table = new DataTable();
            Table.Columns.Add("Элементы массива", typeof(int));
            for (int i = 0; i < Array.Length; i++)
            {
                Table.Rows.Add(Array[i]);
            }
            DataGrid.Columns.Clear();
            DataGrid.DataSource = null;
            DataGrid.DataSource = Table;
        }
        
        public static void ToLabel(Label label, string text)
        {
            label.Invoke(new Action(() => label.Text = text));
        }

        #region Sorting
        public int[] BubbleSort(int[] Array)
        {
            
            int temp;
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                    {
                        temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = temp;
                        if (IsVisualized.Checked)
                        {
                            //SW.Stop();
                            Invoke(new Action(() => Visualization(bubbleChart, Array)));
                            //SW.Start();
                        }
                    }
                }
            }
            Wait(0.1);
            
            return Array;
        }

        public int[] InsertionSort(int[] Array)
        {
            
            for (int i = 1; i < Array.Length; i++)
            {
                int k = Array[i];
                int j = i - 1;

                while (j >= 0 && Array[j] > k)
                {
                    Array[j + 1] = Array[j];
                    Array[j] = k;
                    j--;
                    if (IsVisualized.Checked)
                    {
                        //SW.Stop();
                        Invoke(new Action(() => Visualization(insertionChart, Array)));
                        //SW.Start();
                    }
                }
            }
            Wait(0.1);
            
            return Array;
        }

        public int[] CoctailSort(int[] Array)
        {
            
            int left = 0,
            right = Array.Length - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (Array[i] > Array[i + 1])
                    {
                        Swap(coctailChart ,Array, i, i + 1);
                        if (IsVisualized.Checked)
                        {
                            Invoke(new Action(() => Visualization(coctailChart, Array)));
                        }
                    }
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (Array[i - 1] > Array[i])
                    {
                        Swap(coctailChart, Array, i - 1, i);
                        if (IsVisualized.Checked)
                        {
                            Invoke(new Action(() => Visualization(coctailChart, Array)));
                        }
                    }
                }
                left++;
            }
            Wait(0.1);
            
            return Array;
        }

        public int[] QuickSort(int[] Array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = Array[leftIndex];
            while (i <= j)
            {
                while (Array[i] < pivot)
                {
                    i++;
                }

                while (Array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = Array[i];
                    Array[i] = Array[j];
                    Array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
            {
                QuickSort(Array, leftIndex, j);
            }
            if (i < rightIndex)
            {
                QuickSort(Array, i, rightIndex);
            }

            
            return Array;
        }

        public int[] BogoSort(int[] Array)
        {
            int Temp, Rnd;
            Stopwatch SW = new Stopwatch();
            Random Random = new Random();
            SW.Start();
            while (!IsSorted(Array))
            {
                for (int i = 0; i < Array.Length; ++i)
                {
                    Rnd = Random.Next(Array.Length);
                    Temp = Array[i];
                    Array[i] = Array[Rnd];
                    Array[Rnd] = Temp;
                    if (IsVisualized.Checked)
                    {
                        Invoke(new Action(() => Visualization(chart, Array)));
                    }
                }
            }
            SW.Stop();
            ToLabel(label5, SW.ElapsedMilliseconds.ToString());
            return Array;
        }
        #endregion Sorting
    }
}