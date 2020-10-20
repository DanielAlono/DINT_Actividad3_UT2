using System.Windows;

namespace Actividad3_UT2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sinAjusteRadioButton_Click(object sender, RoutedEventArgs e)
        {
            episodioIVImage.Stretch = System.Windows.Media.Stretch.None;
        }

        private void rellenoUniformeRadioButton_Click(object sender, RoutedEventArgs e)
        {
            episodioIVImage.Stretch = System.Windows.Media.Stretch.UniformToFill;
        }

        private void uniformeRadioButton_Click(object sender, RoutedEventArgs e)
        {
            episodioIVImage.Stretch = System.Windows.Media.Stretch.Uniform;
        }

        private void rellenoRadioButton_Click(object sender, RoutedEventArgs e)
        {
            episodioIVImage.Stretch = System.Windows.Media.Stretch.Fill;
        }

        private void bajaRadioButton_Click(object sender, RoutedEventArgs e)
        {
            episodioIVImage.Opacity = 0.3;
        }

        private void mediaRadioButton_Click(object sender, RoutedEventArgs e)
        {
            episodioIVImage.Opacity = 0.5;
        }

        private void altaRadioButton_Click(object sender, RoutedEventArgs e)
        {
            episodioIVImage.Opacity = 1;
        }
    }
}
