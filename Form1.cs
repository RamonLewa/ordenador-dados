using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordenador_dados
{
    public partial class FOrdenador : Form
    {
        public FOrdenador()
        {
            InitializeComponent();
        }

        [DllImport("DwmApi")]

        private static extern int DwmSetWindowAttribute(IntPtr hwn, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
            {
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
            }
        }

        private bool ValidarEntrada(out int qtd)
        {
            if (!int.TryParse(txtQtde.Text, out qtd) || qtd <= 0)
            {
                MessageBox.Show("Digite uma quantidade válida.", "Ordenador de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void MostrarResultado(int[] vetor, Stopwatch sw)
        {
            txtResultado.Text = string.Join(", ", vetor);
            lblTempo.Text = $"{sw.ElapsedMilliseconds} ms";
        }

        private int[] GerarItens(int quantidade)
        {
            Random rand = new Random();
            int[] itens = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
                itens[i] = rand.Next(0, 1001);

            return itens;
        }

        private void Shuffle(int[] arr, Random rand)
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            if (!ValidarEntrada(out int qtd)) 
                return;

            int[] vetor = GerarItens(qtd);

            Stopwatch sw = Stopwatch.StartNew();
            BubbleSort(vetor);
            sw.Stop();

            MostrarResultado(vetor, sw);
        }

        private void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            if (!ValidarEntrada(out int qtd)) 
                return;

            int[] vetor = GerarItens(qtd);

            Stopwatch sw = Stopwatch.StartNew();
            SelectionSort(vetor);
            sw.Stop();

            MostrarResultado(vetor, sw);
        }

        private void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[min])
                        min = j;

                (arr[i], arr[min]) = (arr[min], arr[i]);
            }
        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            if (!ValidarEntrada(out int qtd)) 
                return;

            int[] vetor = GerarItens(qtd);

            Stopwatch sw = Stopwatch.StartNew();
            InsertionSort(vetor);
            sw.Stop();

            MostrarResultado(vetor, sw);
        }

        private void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            if (!ValidarEntrada(out int qtd)) 
                return;

            int[] vetor = GerarItens(qtd);

            Stopwatch sw = Stopwatch.StartNew();
            QuickSort(vetor, 0, vetor.Length - 1);
            sw.Stop();

            MostrarResultado(vetor, sw);
        }

        private void QuickSort(int[] arr, int left, int right)
        {
            if (left >= right) 
                return;

            int pivot = arr[(left + right) / 2];
            int i = left, j = right;

            while (i <= j)
            {
                while (arr[i] < pivot) i++;
                while (arr[j] > pivot) j--;

                if (i <= j)
                {
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                    i++; j--;
                }
            }

            QuickSort(arr, left, j);
            QuickSort(arr, i, right);
        }

        private void btnBogoSort_Click(object sender, EventArgs e)
        {
            if (!ValidarEntrada(out int qtd)) 
                return;

            int[] vetor = GerarItens(qtd);

            Stopwatch sw = Stopwatch.StartNew();
            vetor = BogoSort(vetor);
            sw.Stop();

            MostrarResultado(vetor, sw);
        }

        private int[] BogoSort(int[] arr)
        {
            Random rand = new Random();

            while (!IsSorted(arr))
                Shuffle(arr, rand);

            return arr;
        }

        private bool IsSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
                if (arr[i - 1] > arr[i])
                    return false;

            return true;
        }

        private void btnCocktailSort_Click(object sender, EventArgs e)
        {
            if (!ValidarEntrada(out int qtd)) 
                return;

            int[] vetor = GerarItens(qtd);

            Stopwatch sw = Stopwatch.StartNew();
            CocktailSort(vetor);
            sw.Stop();

            MostrarResultado(vetor, sw);
        }

        private void CocktailSort(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;
            bool swapped = true;

            while (swapped)
            {
                swapped = false;

                for (int i = start; i < end; i++)
                    if (arr[i] > arr[i + 1])
                    {
                        (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                        swapped = true;
                    }

                if (!swapped) 
                    break;

                swapped = false;
                end--;

                for (int i = end; i > start; i--)
                    if (arr[i] < arr[i - 1])
                    {
                        (arr[i], arr[i - 1]) = (arr[i - 1], arr[i]);
                        swapped = true;
                    }

                start++;
            }
        }

        private void FOrdenador_Load(object sender, EventArgs e)
        {
            lblTempo.Text = string.Empty;
        }
    }
}
