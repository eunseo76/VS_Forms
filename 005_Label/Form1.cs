using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_Label
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      button1.Text = "라파엘로, 아테네 학당";
      label1.Text = "";
      label2.Text = "";
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      label1.Text = "라파엘로 산치오 다 우르비노(Raffaello Sanzio da Urbino), " +
        "르네상스 시대 이탈리아의 예술가/화가";
      label2.Text = "라파엘로는 동시대의 대가인 미켈란젤로, 레오나르도 다빈치와 함께 르네상스 3대" +
        "거장으로 알려져 있습니다. 가장 유명한 작품은 <아테네 학당(The School of Athens)>으로 바티칸" +
        "궁(Apostolic Palace)에 있는 프레스코 벽화입니다.";
    }
  }
}
