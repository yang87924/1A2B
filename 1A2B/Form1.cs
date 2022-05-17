using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1A2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] number = new string[5];//存放答案的陣列
        
        string[] player_number=new string[5];//用來存放玩家輸入的值
        Random rand = new Random();//產生亂數
        int a=0, b=0;//用來存放幾A幾B的值
        int totle = 0;//用來存放猜幾次
        int several=4;//用來存放幾位數的值
        int width;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(200, 28);
            width = this.Width;
            Array.Resize(ref player_number, 4);
            //Array.Clear(player_number, 0, player_number.Length);
            main();//當視窗載入時產生一次亂數
            show.Visible = false;//一開始先讓答案不顯示
            label1.Text = "請輸入" + several + "個不重複的0~9數字";//視窗載入時顯示遊戲說明
        }
        
        private void 初級ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(200, 28);
            Array.Resize(ref player_number, 4);
            several = 4;//當初級被點選時先把位數設成4，代表現在是在玩猜幾位數的
            input_value.ReadOnly = false;
            angin_button.Enabled = true;
            totle = 0;//把累計的猜測次數歸零
            show.Text = "";//清空答案
            show.Visible = false;//讓答案隱藏起來
            answer_buttom.Enabled = true;//讓顯示答案的按鈕可以按
            main();//產生一次亂數
            input_value.Text = "";//清空輸入欄位
            Guess_richTextBox.Text = "";//清空遊戲紀錄
            label1.Text = "請輸入" + several + "個不重複的0~9數字";//當位數改變時重新更新一次遊戲說明
        }
        private void 中級ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(200, 28);
            Array.Resize(ref player_number, 5);
            several = 5;//當初級被點選時先把位數設成5，代表現在是在玩猜幾位數的
            input_value.ReadOnly = false;
            angin_button.Enabled = true;
            totle = 0;//把累計的猜測次數歸零
            show.Text = "";//清空答案
            show.Visible = false;//讓答案隱藏起來
            answer_buttom.Enabled = true;//讓顯示答案的按鈕可以按
            main();//產生一次亂數
            input_value.Text = "";//清空輸入欄位
            Guess_richTextBox.Text = "";//清空遊戲紀錄
            label1.Text = "請輸入" + several + "個不重複的0~9數字";//當位數改變時重新更新一次遊戲說明
            //main();
        }
        private void main ()//產生一組四位不重複的數值
        {
            int i,j;
            for(i=1;i <= several; i++)
            {
                do
                {
                    number[i - 1] =Convert.ToString( rand.Next(0, 9));

                    for (j = 1; j < i; j++)
                    {
                        if (number[i - 1] == number[j - 1])
                        {
                            break;
                        }
                    }
                    
                } while (j != i);
                show.Text += number[i - 1];
            }
        }
        private void answer_Click(object sender, EventArgs e)//看答案
        {
            show.Visible = true;
            answer_buttom.Enabled = false;
        }

        private void guess_button_Click(object sender, EventArgs e)//當猜測按鈕被按下時
        {
            Cutting_input_value();
            for(int k=0;k < several; k++)
            {
                
                for(int j=0;j < several; j++)
                {
                    if(number[k]==player_number[j]&& (number[k] != player_number[k]))
                    {
                        b++;
                    }
                }
                if (number[k] == player_number[k])
                {
                    a++;
                }
            }
            if(a == several)
            {
                timer2.Start();
            }
            Guess_richTextBox.Text +=input_value.Text+Environment.NewLine +a + "A" + b + "B"+ Environment.NewLine+ Environment.NewLine;
            Guess_richTextBox.Select(Guess_richTextBox.Text.Length, 1);//用來讓紀錄欄位定位在最後面
            Guess_richTextBox.ScrollToCaret();//用來讓紀錄欄位定位在最後面
            a = 0;
            b = 0;
            totle++;
        }

        public void Cutting_input_value()//玩家輸入的字串分割存入陣列裡面
        {
            string a = Convert.ToString(input_value.Text);
            
            for (int i = 0; i <= a.Length - 1; i++)
            {
                player_number[i] = a.Substring(i, 1);
            }
        }
        private void input_value_TextChanged(object sender, EventArgs e)//當輸入欄位改變時做哪些事
        {
            int[] zxc = new int[10];
            int sum = 0;
           
            string a = Convert.ToString(input_value.Text);

            for (int i = 0; i <= a.Length - 1; i++)
            {
                player_number[i] = a.Substring(i, 1);
            }

            foreach (string q in player_number)
            {

                zxc[Convert.ToInt32(q)] = 1;
            }
            
            foreach (int q in zxc)
            {
                if (q == 1)
                    sum++;
               /* if(several=4&&sum<4)
                {

                }*/
               
                Console.WriteLine(sum);
                Console.Read();
            }
            if (sum == several && input_value.Text.Length == several && isNumeric(input_value.Text))
                guess_button.Enabled = true;
            else
                guess_button.Enabled = false;
            
        }
        private void angin_button_Click(object sender, EventArgs e)//當重來按鈕被點擊
        {
            totle = 0;
            show.Text = "";
            show.Visible = false;
            answer_buttom.Enabled = true;
            main();
            input_value.Text = "";
            Guess_richTextBox.Text = "";
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            MessageBox.Show("雖然你猜對了，但你用了"+totle+"次","遊戲結束");
            totle = 0;
            show.Text = "";
            show.Visible = false;
            answer_buttom.Enabled = true;
            main();
            input_value.Text = "";
            Guess_richTextBox.Text = "";
        }
        private void input_value_KeyPress(object sender, KeyPressEventArgs e)//用來判斷哪個按鍵被按下
        {
            if ((e.KeyChar < 48 | e.KeyChar > 57) & e.KeyChar != 8)
                e.Handled = true;
            if (input_value.Text.Length == several)
                e.Handled = true;           
            if (e.KeyChar == 8)
                e.Handled = false;
        }
        public bool isNumeric(string str)
        {
            int i; char ch;
            for (i = 0; i < str.Length; i++)
            {
                ch = str[i];
                if (ch < '0' || ch > '9')
                    return false;
            }
            return true;
        }

        private void 終極版未完成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(150,28);
            label1.Text = "從26個英文大寫字母中\n隨機挑選5個不重複的英文大寫字母\n來進行排列組合藉此來進行1A2B";
            input_value.ReadOnly= true;
            angin_button.Enabled = false;
            answer_buttom.Enabled = false;
            show.Text = "";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            /*int[] zxc = new int[10];
            int sum = 0;

            string a = Convert.ToString(input_value.Text);

            for (int i = 0; i <= a.Length - 1; i++)
            {
                player_number[i] = a.Substring(i, 1);
            }

            foreach (string q in player_number)
            {
                zxc[Convert.ToInt32(q)] = 1;
            }
            foreach (int q in zxc)
            {
                if (q == 1)
                    sum++;
            }
            if (sum == 5 && input_value.Text.Length == several && isNumeric(input_value.Text))
                guess_button.Enabled = true;
            else
                guess_button.Enabled = false;*/
        }

    }
}
