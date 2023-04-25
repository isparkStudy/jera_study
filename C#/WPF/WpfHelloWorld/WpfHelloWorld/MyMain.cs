using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfHelloWorld
{
    class MyMain : Application
    {
        [STAThread]
        public static void Main(string[] args)
        {
            MyMain app = new MyMain();
            app.ShutdownMode = ShutdownMode.OnMainWindowClose;      // 메인 Window 닫을 때 Sub Window도 다 종료
            app.Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Main Window 띄우기
            Window mainWindow = new Window();
            mainWindow.Title = "WPF Sample(Main)";
            mainWindow.MouseDown += WinMouseDown;
            mainWindow.Show();

            // Sub Window 2개 띄우기
            for (int i = 0; i < 2;  i++)
            {
                Window win = new Window();
                win.Title = "Extra Window No." + (i + 1);
                win.ShowInTaskbar = false;
                win.Owner = mainWindow;
                win.Show();
            }
        }

        private void WinMouseDown(object sender, MouseEventArgs args)
        {
            Window win = new Window();
            win.Title = "Modal DialogBox";
            win.Width = 400;
            win.Height = 200;

            Button b = new Button();
            b.Content = "Click Me!";
            b.Click += ButtonClick;

            win.Content = b;
            win.ShowDialog();       // Modal 형태로 띄우기
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Click!", sender.ToString());
        }
    }
}
