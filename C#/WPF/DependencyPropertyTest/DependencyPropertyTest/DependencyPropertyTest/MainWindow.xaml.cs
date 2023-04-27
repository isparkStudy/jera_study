using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DependencyPropertyTest
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public String MyColor
        {
            get { return (String)GetValue(MyProperty); }
            set { SetValue(MyProperty, value); }
        }

        //의존속성(Dependency Property) MyProperty
        // DependencyProperty 클래스에는 public 생성자가 없기 때문에 static //메소드인 DependencyProperty.Register()를 사용해서 등록한다.
        // 수정이 불가능 하도록 의존속성은 읽기전용(readonly) 필드로 //선언되는데 일반 UI컨트롤의 Height, Width 등
        //대부분의 의존속성은 FrameworkElement에 DependencyProprty로
        // 정의되어있다.
        public static readonly DependencyProperty MyProperty = DependencyProperty.Register(
            "MyColor",      //의존속성으로 등록될 속성
            typeof(String),     //등록할 의존속성 타입
            typeof(MainWindow),     // 의존속성을 소유하게될 OWNER
            new FrameworkPropertyMetadata(new PropertyChangedCallback(OnMyPropertyChanged)));

        private static void OnMyPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MainWindow win = d as MainWindow;
            SolidColorBrush brush = (SolidColorBrush)new BrushConverter().ConvertFromString(e.NewValue.ToString());
            win.Background = brush;
            win.Title = (e.OldValue == null) ? "이전배경색 없음" : "배경색 : " + e.OldValue.ToString();
            win.textBox1.Text = e.NewValue.ToString();
        }

        private void ContextMenu_Click(object sender, RoutedEventArgs e)
        {
            string str = (e.Source as MenuItem).Header as string;
            MyColor = str;
        }
    }
}