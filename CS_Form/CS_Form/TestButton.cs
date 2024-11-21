using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace CS_Form
{
    class TestButton : Button
    {
        Form1 _form1;

        string globalmessage;
        int globalnum;

        public TestButton(Form1 form1, int x, int y, int width, int height, int button_num, string text)
        {

            _form1 = form1;
            globalnum = button_num;
            //globalmessage = "" + button_num;
            Click += OnClick;
            Text = "" + text;
            Location = new Point(x, y);
            Size = new Size(width, height);
            Tag = "button";
        }
        public void OnClick(object sender, EventArgs s)
        {
            string t = _form1.ButtonLabelReplacement(Text);

            Text = t;


            //_form1.LabelTextUpdate(globalmessage);

           // _form1.LabelTextUpdate(""+globalnum);


        }
    }
}