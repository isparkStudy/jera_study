using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;

namespace WpfOracleTest3
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

        OracleConnection conn;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string strCon = "data source=onj;User ID=scott;Password=tiger";
                conn = new OracleConnection(strCon);
                conn.Open();

                MessageBox.Show("DB Connection OK!");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string sql = "select empno, ename, job from emp ";

            OracleCommand comm = new OracleCommand();
            if (conn == null) button_Click(this, null);
            comm.Connection = conn;
            comm.CommandText = sql;

            OracleDataReader reader = comm.ExecuteReader(CommandBehavior.CloseConnection);
            List<EmpViewModel> emps = new List<EmpViewModel>();
            while (reader.Read())
            {
                emps.Add(new EmpViewModel()
                {
                    Empno = reader.GetInt32(reader.GetOrdinal("empno")),
                    Ename = reader.GetString(reader.GetOrdinal("ename")),
                    Job = reader.GetString(reader.GetOrdinal("job"))
                });
            }

            lstView.ItemsSource = emps;
            reader.Close();
        }
    }
}
