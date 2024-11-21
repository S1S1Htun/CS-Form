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
        TestTextBox _testTextBox;
        string[] strings =
            {
                "0",
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
            };
        public Form1()
        {
            InitializeComponent();
            
            

            for (int i =0;i <10; i ++)
            {
                _testButton = new TestButton(this,(i%5) * 100, (i/5)*100, 100, 100,i, strings[i]);
                Controls.Add(_testButton);
            }
            _testLabel = new TestLabel("ラベル",10, 330, 100, 100);
            Controls.Add(_testLabel);



            _testTextBox = new TestTextBox("できするとぼっくすです", 10, 300, 500, 100);
            Controls.Add(_testTextBox);
            //Label label = new Label():
            //label.Location = new Point(30,400);
            //label.Text = "ラベルです。”；
            //Controls.Add(label);

        }
        public string ButtonLabelReplacement(string str)
        {
            string s = _testTextBox.TextReplacement(str);

            return s;
        }
    }
}
