﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_Flag
{
  public partial class Form1 : Form
  {
    private bool flag;
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (flag == false)
      {
        label1.Text = "Hello! Windows Forms Application!";
        flag = true;
      }
      else
      {
        label1.Text = "";
        flag = false;
      }
    }
  }
}
