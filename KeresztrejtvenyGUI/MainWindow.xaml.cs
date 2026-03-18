using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KeresztrejtvenyGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		int sorok;
		int oszlopok;
		public MainWindow()
        {
            InitializeComponent();
			for (int i = 6; i <= 15; i++)
			{
				cbSor.Items.Add(i);
				cbOszlop.Items.Add(i);
			}

			cbSor.SelectedItem = 15;
			cbOszlop.SelectedItem = 15;

			for (int i = 1; i <= 10; i++)
				cbIndex.Items.Add(i);

			cbIndex.SelectedItem = 3;
		}
		private void Letrehoz_Click(object sender, RoutedEventArgs e)
		{
			gridRacs.Children.Clear();

			sorok = (int)cbSor.SelectedItem;
			oszlopok = (int)cbOszlop.SelectedItem;

			gridRacs.Rows = sorok;
			gridRacs.Columns = oszlopok;

			for (int i = 0; i < sorok; i++)
			{
				for (int j = 0; j < oszlopok; j++)
				{
					TextBox tb = new TextBox();
					tb.Text = "-";
					tb.Width = 25;
					tb.Height = 25;
					tb.Margin = new Thickness(1);
					tb.TextAlignment = TextAlignment.Center;
					gridRacs.Width = oszlopok * 30;
					gridRacs.Height = sorok * 30;
					gridRacs.Children.Add(tb);
					tb.MouseDoubleClick += MezoDuplaKlikk;
				}
			}
		}
		private void MezoDuplaKlikk(object sender, MouseButtonEventArgs e)
		{
			TextBox tb = sender as TextBox;

			if (tb.Text == "-")
				tb.Text = "#";
			else
				tb.Text = "-";
		}
	}
}