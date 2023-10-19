using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patagames.Ocr;
using System.Drawing;
using System.IO;



namespace getText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var obj = OcrApi.Create())
            {
                obj.Init(Patagames.Ocr.Enums.Languages.English);
                string plainText = obj.GetTextFromImage(@"C:\Users\Admin\Desktop\big.png");
                label1.Text = plainText;
            }
            
        }
    }
}
