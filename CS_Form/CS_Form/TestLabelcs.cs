using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CS_Form
{
    class TestLabel : Label
    {
        ///<summary>
        ///コンストラクタ
        ///クラスを生したときに呼び出される
        ///</summary>
        public TestLabel(string str,int x, int y, int width, int height)
        {
            //らべる内に文字を表示させる
            Text = str;
            // ボタンの生成場所を指定
            Location = new Point(x, y);
            // ボタンの大きさを指定する
            Size = new Size(width, height);
            
        }


        public void TextUpdate(string str) 
        {
            Text = str;
        }

    }


}
