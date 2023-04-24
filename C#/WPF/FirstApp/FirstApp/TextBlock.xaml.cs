using System.Windows;
using System.Windows.Input;

namespace FirstApp
{
    /// <summary>
    /// ch7.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ch7 : Window
    {
        public ch7()
        {
            InitializeComponent();
        }

        private void hyper_MouseEnter(object sender, MouseEventArgs e)
        {
            hyper.TextDecorations = TextDecorations.Underline;
        }

        private void hyper_MouseLeave(object sender, MouseEventArgs e)
        {
            hyper.TextDecorations = null;
        }

        private void hyper_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }

    }
}
