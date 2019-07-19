using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vector_App
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		NumGen Gen = new NumGen();

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			for (int i = 0; i <= 100; i++)
			{
				Combobox_lenght.Items.Add(i);
				Combobox_num.Items.Add(i);
			}
		}

		private byte VectorPart_Gen(ref int n, int N)
		{
			int percent = Convert.ToInt32(((float)n / (float)N) * 100);
			int probability = Gen.probabilityGen();
			if ((probability < percent) && (n != 0))
			{
				n -= 1;
				return 1;
			}
			else return 0;
			
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			TextBox_Bin.Text = "";
			int n = (int)Combobox_num.SelectedItem - 2; // n - количество единиц в массиве
			int N = (int)Combobox_lenght.SelectedItem; // N - размер массива
			byte[] array = new byte[N];
			for (int i = 0; i < N; i++)
			{
				if (i == 0 || i == (N - 1))
				{
					array[i] = 1;
				}
				else
				{
					array[i] = VectorPart_Gen(ref n, N - (i + 1)); ;
				}
			}
			for (int i = 0; i < N; i++)
				TextBox_Bin.Text += Convert.ToString(array[i]);

		}
	}
}
