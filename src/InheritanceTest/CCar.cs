using System;
using System.Drawing;

namespace InheritanceTest
{
    public class CCar : CCycle
    {
        public Rectangle _rtSquare2;  // 몸통

        public CCar(string sName) : base(sName)
        {
            strName = sName;
            _Pen = new Pen(Color.Blue, 3);  // 펜에 대한 색상과 굵기를 설정

            _rtCircle1 = new Rectangle(60, 180, 90, 90);  // 바퀴 1에대한 위치 및 크기를 설정
            _rtCircle2 = new Rectangle(210, 180, 90, 90);  // 바퀴 2에대한 위치 및 크기를 설정
            _rtSquare1 = new Rectangle(90, 30, 180, 90);   // 몸통 1에 대한 위치 및 크기를 설정
            _rtSquare2 = new Rectangle(30, 120, 300, 60);   // 몸통 2에 대한 위치 및 크기를 설정
        }


        /// <summary>
        /// 외부에서 사용
        /// 외부에서 그림의 위치를 이동시키는 함수를 호출
        /// </summary>
        /// <param name="iMove"></param>
        public void fMove1(int iMove)
        {
            fCircle1Move(iMove);
            fCircle2Move(iMove);
            fSquare1Move(iMove);
            fSquare2Move(iMove);
        }

        private void fSquare2Move(int iMove)
        {
            Point oPoint = _rtSquare2.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSquare2.Location = oPoint;
        }

    }
}
