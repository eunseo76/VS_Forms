using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003_Messegebox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      MessageBox.Show("가장 간단한 메시지 박스입니다.");
      MessageBox.Show("타이틀이 있는 메시지 박스입니다.", "title");
      DialogResult result1 = MessageBox.Show("두개의 버튼", "Question",
        MessageBoxButtons.YesNo);
      DialogResult result2 = MessageBox.Show("세개의 버튼", "Question",
        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button3);
      MessageBox.Show("느낌표와 알람", "타이틀",
        MessageBoxButtons.OK, MessageBoxIcon.Hand);
      MessageBox.Show(result1.ToString() + " " + result2.ToString());
    }
  }
}
