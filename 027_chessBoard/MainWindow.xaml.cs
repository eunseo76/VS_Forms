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

namespace _027_chessBoard
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            chessBoard.Rows = 8;
            chessBoard.Columns = 8;

            for (int i = 0; i < 64/2; i++)    // 한번에 2개씩 추가
            {
                // 짝수 줄은 검은색,빨간색 / 홀수 줄은 빨간색, 검은색
                Rectangle r1 = new Rectangle();
                Rectangle r2 = new Rectangle();

                if ((i / 4) % 2 == 0)
                {
                    r1.Fill = Brushes.Black;
                    r2.Fill = Brushes.Red;
                    chessBoard.Children.Add(r1);
                    chessBoard.Children.Add(r2);
                }
                else
                {
                    r1.Fill = Brushes.Red;
                    r2.Fill = Brushes.Black;
                    chessBoard.Children.Add(r1);
                    chessBoard.Children.Add(r2);
                }    
            }
        }
    }
}
