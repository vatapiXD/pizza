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

namespace pizza
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
		private void BtnOsszegzes_Click(object sender, RoutedEventArgs e)
		{
			
			var teszta = (lbTeszta.SelectedItem as ListBoxItem)?.Content.ToString()
						 ?? "nincs kiválasztva";

			var meret = (cbMeret.SelectedItem as ComboBoxItem)?.Content.ToString()
						?? "nincs kiválasztva";

	
			List<string> feltetek = new List<string>();

			if (chkSajt.IsChecked == true) feltetek.Add("sajt");
			if (chkSonka.IsChecked == true) feltetek.Add("sonka");
			if (chkGomba.IsChecked == true) feltetek.Add("gomba");
			if (chkOliva.IsChecked == true) feltetek.Add("olívabogyó");
			if (chkKukorica.IsChecked == true) feltetek.Add("kukorica");

			string feltetSzoveg = feltetek.Count > 0 ? string.Join(", ", feltetek) : "nincs feltét";




		}
	}