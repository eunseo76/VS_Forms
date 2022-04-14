using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _012_ListBox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // (2) listBox.Items.Add() 사용법
      listBox2.Items.Add("뉴질랜드, 오클랜드");
      listBox2.Items.Add("일본, 오사카");
      listBox2.Items.Add("호주, 아델레이드");
      listBox2.Items.Add("뉴질랜드, 웰링턴");
      listBox2.Items.Add("일본, 도쿄");
      listBox2.Items.Add("호주, 퍼스");
      listBox2.Items.Add("스위스, 취리히");
      listBox2.Items.Add("스위스, 제네바");
      listBox2.Items.Add("호주, 멜버른");
      listBox2.Items.Add("호주, 브리즈번");

      // (3) DataSource 사용법
      List<string> happiness = new List<string>()
      {
        "필란드", "덴마크", "아이슬란드", "스위스", "네덜란드", "룩셈부르크",
        "스웨덴", "노르웨이", "이스라엘", "뉴질랜드"
      };
      listBox3.DataSource = happiness;
    }

    // 여러 속성들(Class)의 첫 조상 object - ToString()
    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      //ListBox l = (ListBox)sender;
      ListBox l = sender as ListBox;
      txtSIndex1.Text = l.SelectedIndex.ToString();
      txtSItem1.Text = l.SelectedItem.ToString();
    }

    private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListBox l = sender as ListBox;
      txtSIndex2.Text = l.SelectedIndex.ToString();
      txtSItem2.Text = l.SelectedItem.ToString(); 
    }

    private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListBox l = sender as ListBox;
      txtSIndex3.Text = l.SelectedIndex.ToString();
      txtSItem3.Text = l.SelectedItem.ToString();
    }
  }
}
