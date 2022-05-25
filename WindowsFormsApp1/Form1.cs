using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        FirestoreDb db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"maui-login-firebase-adminsdk-qcm61-688ce81bc3.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("maui-login");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Document_with_AutoID();
        }

        private void Add_Document_with_AutoID()
        {
            CollectionReference coll = db.Collection("Add_Document_Width_AutoID");
            Dictionary<string, object> datal = new Dictionary<string, object>()
            {
                {"FirestName", "Kim" },
                {"LastName", "Jinwon" },
                {"PhoneNumber", "010-1234-5678" }
            };
            coll.AddAsync(datal);
            MessageBox.Show("data added successfully");
        }
    }
}
