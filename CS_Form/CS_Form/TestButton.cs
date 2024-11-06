using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace CS_Form
{
    class TestButton : Button
    {
        Form1 _form1;
        /// <summary>
        /// コンストラクタ
        /// クラスを生成したときに呼び出される
        /// <summary>


            
        int number;
        public TestButton(Form1 form1, int id,int x, int y, int width, int height,int numeric )
        
        {
            _form1 = form1;
            number = numeric;
            ///<summary>
            ///コンストラ文字を表示させる
            Click += Onclick;

           // ボタン内に文字を表示させる
            Text = ""+numeric;

           
            
            Location = new Point(x, y);

           
            Size = new Size(width,height);


            ///クラスを生したとき</summary>
            //Click event ni On Click 関数を登録
            //ボタンをクリックしたときに登録した関数を実行します。
            
            

            // ボタン内に
        }

        public void Onclick(object sender, EventArgs e)
        {
            _form1.LabelTextUpdate(number.ToString());
        }


    }
}