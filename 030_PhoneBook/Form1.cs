﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\eunse\Documents\StudentTable.accdb
namespace _030_PhoneBook
{
    public partial class Form1 : Form
    {
        string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\eunse\Documents\StudentTable.accdb";
        OleDbConnection conn = null;
        OleDbCommand comm = null;
        OleDbDataReader reader = null;

        public Form1()
        {
            InitializeComponent();
            DisplayStudents();
        }
        // 교과서 602쪽
        private void DisplayStudents()
        {
            if (conn == null)
            {
                // DB 연결 후 Open
                conn = new OleDbConnection(connStr);
                conn.Open();
            }

            // SQL 명령어 만들고 
            string sql = "SELECT * FROM StudentTable";

            // 실행
            comm = new OleDbCommand(sql, conn);
            reader = comm.ExecuteReader();

            // 여러 개 찾으면 각각에 대해서 루프에서 처리
            while (reader.Read())
            {
                string x = "";
                x += reader["ID"] + "\t";
                x += reader["SId"] + "\t";
                x += reader["SName"] + "\t";
                x += reader["Phone"];
                lstStudent.Items.Add(x);
            }
            reader.Close();
            conn.Close();
            conn = null;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}