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
        int number;
        public TestButton(int x, int y, int width, int height,int numeric )
        
        {
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

        private void OnClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void Onclick(object sender, EventArgs e)
        {
            MessageBox.Show(""+number);        
        }


    }
}