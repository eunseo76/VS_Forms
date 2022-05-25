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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _032_Splash
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Border> borderList;
        DispatcherTimer t = new DispatcherTimer();
        Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();
            borderList = new List<Border>
            // Timer t =  new Timer();    - WinForm 사용방법
            {
                bd1, bd2, bd3, bd4, bd5, bd6, bd7, bd8, bd9, bd10,
                bd11, bd12, bd13, bd14, bd15, bd16, bd17, bd18, bd19, bd20
            };
            t.Interval = new TimeSpan(0, 0, 1);  // 1초
            t.Tick += T_Tick;
        }

        int index;
        private void T_Tick(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string time = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = date;
            lblTime.Text = time;

            byte[] colors = new byte[20];
            for (int i = 0; i < colors.Length; i++)
            {
                colors[i] = (byte)(r.Next(255));
                borderList[i].Background =
                    new SolidColorBrush(Color.FromRgb(0, colors[i], 0));
            }

            string s = "";
            s += date + " " + time + " ";
            for (int i = 0; i < borderList.Count; i++)
            {
                s += colors[i] + " ";
            }

            lstDB.Items.Add(s);

            // 리스트박스의 스크롤
            lstDB.SelectedIndex = index++;
            lstDB.ScrollIntoView(lstDB.SelectedItem);
        }

        bool flag = false;
        private void btnRandom_Click(object sender, RoutedEventArgs e)
        {
            if (flag == false)
            {
                t.Start();
                btnRandom.Content = "중지";
                flag = true;
            }
            else
            {
                t.Stop();
                btnRandom.Content = "Random색깔표시";
                flag = false;
            }
        }

        private void btnDB_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
