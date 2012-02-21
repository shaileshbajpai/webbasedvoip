using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CabLib;
using System.IO;
namespace ExtractCabfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Extract obj = new Extract();
            //obj.ExtractFile("E:\\FM9.cab", "E:\\");
            //Extract.kHeaderInfo pk = new Extract.kHeaderInfo();
            //obj.IsFileCabinet("E:\\FM9.cab",out pk);
            
            StringBuilder s_folder = new StringBuilder();
            //obj.ExtractStream(st, s_folder);  
 
            // create reader & open file
            StreamReader tr = new StreamReader("E:\\FM9.txt");
            
            // read a line of text
            while (!tr.EndOfStream)
            {
                s_folder.AppendLine(tr.ReadLine());
            }

            // close the stream
            tr.Close();
            

        }
    }
}
