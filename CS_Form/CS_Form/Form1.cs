﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

            for (int i =0;i <10; i ++)
            {
                TestButton testButton = new TestButton((i%3) * 100, (i/3)*100, 100, 100,i);
                Controls.Add(testButton);
            }
            TestLabel testLabel = new TestLabel("ラベル",100, 500, 30, 30);
            Controls.Add(testLabel);

            

        }
    }
}
