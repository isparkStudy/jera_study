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
using System.Windows.Shapes;

namespace WpfApp1
{

    public partial class SubWindow : Window
    {
        // 메인 윈도우의 하단 ListBox를 Refresh하기 위한 델리게이트
        // 메인 윈도우에서 직무추가 버튼을 클릭할 때 이벤트를 할당해 준다.
        public Delegate UpdateActor;

        public SubWindow()
        {
            InitializeComponent();
        }

        // 저장 버튼 클릭
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (rdolnner.IsChecked == false && rdoOutSide.IsChecked == false)
            {
                MessageBox.Show("내근 또는 외근을 선택하세요.", "항목선택");
                return;
            }

            DutyType dutyType = (rdolnner.IsChecked == true) ? DutyType.Inner : DutyType.OutSide;
            MainWindow.duties.Add(new Duty(txtDutyName.Text, dutyType));        // 사용자가 지금 입력한 직무

            UpdateActor.DynamicInvoke(dutyType);

            MessageBox.Show("저장OK!", "저장확인");
            this.Close();

        }
    }
}
