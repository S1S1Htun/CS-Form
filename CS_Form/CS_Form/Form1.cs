using System;
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
        TestLabel _testLabel;
        TestButton _testButton;
        public Form1()
        {
            InitializeComponent();

            

            for (int i =0;i <10; i ++)
            {
                _testButton = new TestButton(this,i,(i%5) * 100, (i/5)*100, 100, 100,i);
                Controls.Add(_testButton);
            }
            _testLabel = new TestLabel("ラベル",10, 300, 100, 500);
            Controls.Add(_testLabel);
            //Label label = new Label():
            //label.Location = new Point(30,400);
            //label.Text = "ラベルです。”；
            //Controls.Add(label);

        }
        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate(str);
        }
    }
}
