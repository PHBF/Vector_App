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
		
		public MainWindow()
		{
			InitializeComponent();
		}

		NumGen Gen = new NumGen();

		private byte VectorPart_Gen(ref float n, float N)
		{
			int percent = Convert.ToInt32((n / N) * 100);
			int probability = Gen.probabilityGen();
			if ((probability < percent) && (n != 0))
			{
				n -= 1;
				return 1;
			}
			else return 0;
		}

		//public partial class Form1 : Form
		//{
		//	public Form1()
		//	{
		//		InitializeComponent();
		//	}

		//	private int MyRandom(ref int n, int N, Random r)
		//	{
		//		float random;
		//		float num;

		//		random = ((float)n / (float)N) * 100;
		//		//float random_num = ((float)1 / (float)N)*100;  

		//		//Random r = new Random();
		//		num = r.Next(0, 100);

		//		if ((num < random) && (n != 0))
		//		{
		//			n -= 1;
		//			return 1;

		//		}
		//		else
		//		{
		//			return 0;
		//		}

		//	}

		//	public void button_Gen_Click(object sender, EventArgs e)
		//	{
		//		textBox_array.Text = "";

		//		int arraySize = Convert.ToInt32(textBox_lenght.Text);
		//		int arrayWeight = 3;

		//		int[] mainArray = new int[arraySize];
		//		//Array.Resize(ref mainArray, arraySize);

		//		Random r = new Random();
		//		for (int i = 0; i < arraySize; i++)
		//		{
		//			if (i == 0) mainArray[i] = 1;
		//			else
		//			{
		//				mainArray[i] = MyRandom(ref arrayWeight, arraySize - i, r);
		//			}
		//		}

		//		for (int i = 0; i < arraySize; i++)
		//		{
		//			textBox_array.Text += Convert.ToString(mainArray[i], 2);
		//		}


		//	}

		//	private void Form1_Load(object sender, EventArgs e)
		//	{

		//	}
		//}
	}
}
