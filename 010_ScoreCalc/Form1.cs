﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010_ScoreCalc
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      double sum = double.Parse(txtKor.Text) +
        Convert.ToDouble(txtMath.Text) +
        Convert.ToDouble(txtEng.Text);

      double avg = sum / 3;

      textBox5.Text = sum.ToString();
      textBox4.Text = avg.ToString("0.0");   // 소수점 한자리
    }
  }
}

// wwwbklee@naver.com    이보경  