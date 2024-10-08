using System.Windows;

namespace YourNamespace
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenTranslator(object sender, RoutedEventArgs e)
        {
            TranslatorWindow translatorWindow = new TranslatorWindow();
            translatorWindow.Show();
        }

        private void OpenCalculator(object sender, RoutedEventArgs e)
        {
            CalculatorWindow calculatorWindow = new CalculatorWindow();
            calculatorWindow.Show();
        }

        private void OpenIntervalDefiner(object sender, RoutedEventArgs e)
        {
            IntervalDefinerWindow rangeCheckerWindow = new IntervalDefinerWindow();
            rangeCheckerWindow.Show();
        }

        private void OpenPasswordChecker(object sender, RoutedEventArgs e)
        {
            PasswordCheckerWindow passwordCheckerWindow = new PasswordCheckerWindow();
            passwordCheckerWindow.Show();
        }
    }
}