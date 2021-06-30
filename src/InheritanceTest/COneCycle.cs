using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTest
{
    public class COneCycle : CBase
    {
        public Rectangle _rtCircle1;
        public Rectangle _rtSquare1;

        public COneCycle(string sName)
        {
            strName = sName;
            _Pen = new Pen(Color.WhiteSmoke, 3);  // 펜에 대한 색상과 굵기를 설정

            _rtCircle1 = new Rectangle(120, 150, 120, 120);  // 바퀴 1에대한 위치 및 크기를 설정
            _rtSquare1 = new Rectangle(150, 30, 60, 120);   // 몸통 1에 대한 위치 및 크기를 설정
        }
        
        /// <summary>
        /// 설정되어 있는 Pen에 대한 정보를 반환
        /// </summary>
        /// <returns></returns>
        public Pen fPenInfo()
        {
            return _Pen;
        }

        /// <summary>
        /// 외부에서 그림의 위치를 이동시키는 함수를 호출
        /// </summary>
        /// <param name="iMove"></param>
        public void fMove(int iMove)
        {
            fCircle1Move(iMove);
            fSquare1Move(iMove);
        }

        /// <summary>
        /// 바퀴1의 위치를 가져와서 x 위치 값을 이동시키고 다시 바퀴1에 위치정보를 넣어줌
        /// </summary>
        /// <param name="iMove"></param>
        private void fSquare1Move(int iMove)
        {
            Point oPoint = _rtCircle1.Location;
            oPoint.X = oPoint.X + iMove;
            _rtCircle1.Location = oPoint;
        }


        /// <summary>
        /// 몸통1의 위치를 가져와서 x 위치값을 이동시키고 다시 바퀴1에 위치정보를 넣어줌
        /// </summary>
        /// <param name="iMove"></param>
        private void fCircle1Move(int iMove)
        {
            Point oPoint = _rtSquare1.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSquare1.Location = oPoint;
        }
    }
}
