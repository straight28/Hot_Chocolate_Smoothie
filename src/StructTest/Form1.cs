using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StructTest
{

    // *** 메모리

    // Stack 메모리
    // 함수 호출시 생성 되는 지역 및 매개 변수들이 지정
    // 함수 호출이 완료되면 소멸

    // Heap 메모리
    // 필요에 의해 동적으로 생성하고 원할 때 소멸
    // 생성과 소멸 관리 필요, 메모리 누수에 대한 관리가 필요함
    public partial class Form1 : Form
    {
        // 구조체와 클래스
        // 1.구조체 
        //     구조체는 값 타입
        //     상속이 불가능
        //     New 선언 필요없이 바로 사용가능
        struct structPlayer
        {
            public int iCount;
            public int iSun;
            public int iStar;
            public int iMoon;


            public int iCardSum;

            public int CardSun(int iSum, int iMoon, int iStar)
            {
                return iSun + iMoon + iStar;
            }

            public string ResultText()
            {
                return string.Format("{0}회) 해:{1}, 달:{2}, 별:{3} => 합계는 {4} 입니다.", iCount, iSun, iMoon, iStar, iCardSum);
            }

        }

         structPlayer _stPlayer1;
         structPlayer _stPlayer2;

       


        Random _rd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void pboxSun_Click(object sender, EventArgs e)
        {

            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iSun = iNumber;
            }
            else
            {
                _stPlayer2.iSun = iNumber;
            }

            Result();
        }

        private void pboxMoon_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iMoon = iNumber;
            }
            else
            {
                _stPlayer2.iMoon = iNumber;
            }

            Result();
        }

        private void pboxStar_Click(object sender, EventArgs e)
        {

            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iStar = iNumber;
            }
            else
            {
                _stPlayer2.iStar = iNumber;
            }

            Result();
        }


        private void pboxNone_Click(object sender, EventArgs e)
        {
            Result();
        }

        private void iCheckedChange()
        {
            if (rdoPlayer1.Checked)
            {
                rdoPlayer2.Checked = true;
            }
            else
            {
                rdoPlayer1.Checked = true;
            }
        }


        CPlayer _ctPlayer = new CPlayer();

        public void Result()
        {
            string strResult = string.Empty;

            
            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iCount++;

                _stPlayer1.iCardSum = _ctPlayer.CardSun(_stPlayer1.iSun, _stPlayer1.iMoon, _stPlayer1.iStar);

                strResult = _ctPlayer.ResultText(_stPlayer1.iCount, _stPlayer1.iSun, _stPlayer1.iMoon, _stPlayer1.iStar, _stPlayer1.iCardSum);

                lboxResult1.Items.Add(strResult);
            }
            else
            {
                _stPlayer2.iCount++;

                _stPlayer2.iCardSum = _ctPlayer.CardSun(_stPlayer2.iSun, _stPlayer2.iMoon, _stPlayer2.iStar);

                strResult = _ctPlayer.ResultText(_stPlayer2.iCount, _stPlayer2.iSun, _stPlayer2.iMoon, _stPlayer2.iStar, _stPlayer2.iCardSum);

                lboxResult2.Items.Add(strResult);
            }

            iCheckedChange();

            
            if(_stPlayer1.iCount == _stPlayer2.iCount)
            {
                lboxNow.Items.Add(_ctPlayer.PlayerPair(_stPlayer2.iCount, _stPlayer1.iCardSum, _stPlayer2.iCardSum));

                if (_stPlayer2.iCount >= 5)
                {
                    lboxNow.Items.Add(_ctPlayer.PlayerResult(_stPlayer1.iCardSum, _stPlayer2.iCardSum));
                }
            }


        }

    }
}
