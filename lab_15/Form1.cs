using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_02022023
{
    public partial class Form1 : Form
    {
        int num, count = 0;
        int[] arr = new int[100];
        int[] arr_BubbleSort = new int[100];
        int[] arr_SelectSort = new int[100];
        Random rnd = new Random();

        public void FindBefore(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    label2.Text += $"Простой поиск {num} до сортировки: {i + 1} итераций\n";
                    break;
                }
            }
        }
        public void FindAfter(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    label2.Text += $"Простой поиск {num} после сортировки: {i + 1} итераций\n";
                    break;
                }
            }
        }
        public void BubbleSort(int[] array)
        {
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        k++;
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            label2.Text += $"Сортировка пузырьком: {k} итераций\n";
        }
        public void SelectSort(int[] array)
        {
            int k = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    k++;
                    int t = array[i];
                    array[i] = array[min];
                    array[min] = t;  
                }
            }
            label2.Text += $"Сортировка выбором: {k} итераций\n";
        }
        public void QuickSort(int[] array, int l, int r, ref int count)
        {
            int i = 0;
            int j = r - 1;
            int num = array[(i + j) / 2];
            do
            {
                while (array[i] < num) i++;
                while (array[j] > num) j--;
                if (i <= j)
                {
                    count++;
                    int t = array[i];
                    array[i] = array[j];
                    array[j] = t;
                    i++;
                    j--;
                }

            } while (i <= j);
            if (j > 0) QuickSort(array, l, j + 1, ref count);
            if (r > i) QuickSort(array, i, r - i, ref count);
        }
        public int BinFind(int[] array, int num, int l, int r, ref int count)
        {
            int mid = (l + r) / 2;
            if (array[mid] == num)
            {
                label2.Text += $"Бинарный поиск {num}: {count + 1} итераций\n";
                return 1;
            }
            if ((mid == l) || (mid == r))
            {
                label2.Text += $"Бинарный поиск: -1\n";
                return 0;
            }
            if (array[mid] < num)
            {
                count++;
                return BinFind(array, num, mid, r, ref count);
            }
            else
            {
                count++;
                return BinFind(array, num, l, mid, ref count);
            }
        }
        //
        // Forms
        //
        public Form1()
        {
            InitializeComponent();
            label1.Text = label2.Text = "";
            for (int i = 0; i < arr_BubbleSort.Length; i++)
            {
                arr[i] = rnd.Next(100);
                if (i % 10 == 0) label1.Text += "\n";
                label1.Text += arr[i] < 10 ? $"  {arr[i]} " : $"{arr[i]} ";
            }
            num = arr[rnd.Next(arr.Length)];
            arr_BubbleSort = arr.Clone() as int[];
            arr_SelectSort = arr.Clone() as int[];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Простой поиск до сортировки
            FindBefore(arr, num);

            // Сортировка пузырьком
            BubbleSort(arr_BubbleSort);

            // Сортировка выбором
            SelectSort(arr_SelectSort);

            // Быстрая сортировка
            QuickSort(arr, 0, arr.Length, ref count);
            label2.Text += $"Быстрая сортировка: {count} итераций\n";
            count = 0;

            // Простлй поиск после сортировки
            FindAfter(arr, num);

            // Бинарный поиск
            BinFind(arr_BubbleSort, num, 0, arr_BubbleSort.Length - 1, ref count);
        }
    }
}
