using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_02022023
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        //
        // Buttons
        //
        private void buttonFirst_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int[,] A = new int[3, 4];
            Table.RowCount = 3; // Кол‐во строк
            Table.ColumnCount = 4; // Кол‐во столбцов
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = rnd.Next(-150, 150);
                    Table.Rows[i].Cells[j].Value = Convert.ToString(A[i,j]);
                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                int minimum = int.MaxValue;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i,j] < minimum)
                    {
                        minimum = A[i,j];
                    }
                }
                label1.Text += $"Минимум {i+1} строки: {minimum}\n";
            }
        }
        private void buttonSecond_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int[,] A = new int[3, 3];
            Table.RowCount = 3; // Кол‐во строк
            Table.ColumnCount = 3; // Кол‐во столбцов
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = rnd.Next(-150, 150);
                    Table.Rows[i].Cells[j].Value = Convert.ToString(A[i, j]);
                }
            }
            int summa = 0;
            int composition = 1;
            for (int i = 0; i < A.GetLength(1); i++)
            {
                summa += A[1, i];
                composition *= A[i, 0];
            }
            label1.Text += $"Сумма второй строки - {summa}\nПроизведение первого столбца - {composition}";
        }
        private void buttonThird_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int[,] A = new int[7, 7];
            Table.RowCount = 7; // Кол‐во строк
            Table.ColumnCount = 7; // Кол‐во столбцов
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = rnd.Next(-150, 150);
                    Table.Rows[i].Cells[j].Value = Convert.ToString(A[i, j]);
                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                int minimum = int.MaxValue;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[j, i] < minimum)
                    {
                        minimum = A[j, i];
                    }
                }
                label1.Text += $"Минимум {i + 1} столбца: {minimum}\n";
            }
        }
        private void buttonFourth_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int[,] A = new int[15, 15];
            Table.RowCount = A.GetLength(0); // Кол‐во строк
            Table.ColumnCount = A.GetLength(1); // Кол‐во столбцов
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = rnd.Next(-150, 150);
                    Table.Rows[i].Cells[j].Value = Convert.ToString(A[i, j]);
                }
            }
            int maximum = int.MinValue;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i,i] > maximum)
                {
                    maximum = A[i,i];
                    label1.Text = "Строка максимального элемента главной диагонали:\n";
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        label1.Text += $"{A[i, j]} ";
                    }
                    label1.Text += "\n";
                }
            }
        }
    }
}
