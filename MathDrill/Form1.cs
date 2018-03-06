using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathDrill
{

    public partial class MathDrill : Form
    {
        //フィールド
        Random rand = new Random();
        long noA = 0; //前数
        long noB = 0; //後ろ数
        long noC = 0;　//答え
        long MondaiCnt = 0; //出題数カウント
        long MondaiMax = 0; //最大出題数
        long seisekiCnt = 0;

        long type = 0; //足し算引き算タイプ
        public const long PLUS_TYPE = 0;
        public const long MINUS_TYPE = 1;
        String typeStr;

        public MathDrill()
        {
            InitializeComponent();
        }

        private void MathDrill_Load(object sender, EventArgs e)
        {
            MessageBox.Show("算数ドリルへようこそ！");
            InBox.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /**
         * 入力検地メソッド
         * */
        private void InBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //数値およびバックスペースのみ受け付ける　"マイナスも除外"
            if((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b'))
            {
                if(!(e.KeyChar == '-' && InBox.TextLength == 0))
                {
                e.Handled = true;     //今入力されたものを無視       
                }
            }


            if (e.KeyChar == (char)Keys.Enter && InBox.Text != "" && InBox.Text != "-")
            {
                Kotaeawase();
                InBox.Text = "";

                if (MondaiCnt < MondaiMax)
                {
                    MondaiSakusei();
                }
                else
                {
                    Seiseki();
                }
            }
        }

        /**
         * 問題作成メソッド
         * */
        private void MondaiSakusei()
        {
            noA = rand.Next(1, 10);
            noB = rand.Next(1, 10);

            //足し算問題引き算問題判定
            if (plus_type.Checked)
            {
                type = PLUS_TYPE;
                typeStr = " + ";
            }
            else
            {
                type = MINUS_TYPE;
                typeStr = " - ";
            }

            //問題文作成
            MondaiLbl.Text = noA.ToString() + typeStr + noB.ToString() + " = ";

            if (type == PLUS_TYPE)
            {

                noC = noA + noB;
            }
            else
            {
                noC = noA - noB;
            }
            MondaiCnt++;
        }

        /**
         * 答えあわせメソッド
         * */
        private void Kotaeawase()
        {
            if (noC == Int64.Parse(InBox.Text))
            {
                OutBox.AppendText("○ ");
                seisekiCnt++;
            }
            else
            {
                OutBox.AppendText("× ");
            }
            OutBox.AppendText(MondaiLbl.Text + InBox.Text + "\r\n");
        }

        /**
         * ドリル開始メソッド
         * */
        private void StartBtn_Click(object sender, EventArgs e)
        {
          //問題数の作成
            if (ten_questions.Checked)
            {
                MondaiMax = 10;
            }
            if (twenty_questions.Checked)
            {
                MondaiMax = 20;
            }
            if (thirty_questions.Checked)
            {
                MondaiMax = 30;
            }

            //成績変数の初期化
            MondaiCnt = 0;
            seisekiCnt = 0;
            MondaiSakusei();
            //回答受付
            InBox.Enabled = true;
            InBox.Focus();
        }

        private void Seiseki()
        {
            InBox.Enabled = false;
            MondaiLbl.Text = "";
            OutBox.AppendText("正解数は" + seisekiCnt + "です！\r\n");
        }
    }
}
