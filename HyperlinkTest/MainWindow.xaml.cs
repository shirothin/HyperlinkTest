using System.Windows;

namespace HyperlinkTest
{
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void OnClick(object sender, RoutedEventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start("http://www.microsoft.com");
			}
			catch { }
		}
	}
}