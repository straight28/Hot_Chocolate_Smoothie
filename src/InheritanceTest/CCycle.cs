using System.Drawing;

namespace InheritanceTest
{
    public class CCycle : CBase
    {
        public Rectangle _rtCircle1;  // 바퀴
        public Rectangle _rtCircle2;  // 바퀴
        public Rectangle _rtSquare1;  // 몸통


        public CCycle(string sName)
        {
            strName = sName;
            _Pen = new Pen(Color.Black, 3);  // 펜에 대한 색상과 굵기를 설정

            _rtCircle1 = new Rectangle(30, 150, 120, 120);  // 바퀴 1에대한 위치 및 크기를 설정
            _rtCircle2 = new Rectangle(210, 150, 120, 120);  // 바퀴 1에대한 위치 및 크기를 설정
            _rtSquare1 = new Rectangle(60, 90, 240, 60);   // 몸통 1에 대한 위치 및 크기를 설정
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
        /// 외부에서 사용
        /// 외부에서 그림의 위치를 이동시키는 함수를 호출
        /// </summary>
        /// <param name="iMove"></param>
        public void fMove1(int iMove)
        {
            fCircle1Move(iMove);
            fCircle2Move(iMove);
            fSquare1Move(iMove);
        }

        /// <summary>
        /// 내부에서 사용
        /// 바퀴1의 위치를 가져와서 x 위치 값을 이동시키고 다시 바퀴1에 위치정보를 넣어줌
        /// </summary>
        /// <param name="iMove"></param>
        protected void fSquare1Move(int iMove)
        {
            Point oPoint = _rtSquare1.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSquare1.Location = oPoint;
        }


        /// <summary>
        /// 내부에서 사용
        /// 몸통1의 위치를 가져와서 x 위치값을 이동시키고 다시 바퀴1에 위치정보를 넣어줌
        /// </summary>
        /// <param name="iMove"></param>
        protected void fCircle1Move(int iMove)
        {
            Point oPoint = _rtCircle1.Location;
            oPoint.X = oPoint.X + iMove;
            _rtCircle1.Location = oPoint;
        }

        /// <summary>
        /// 내부에서 사용
        /// 몸통1의 위치를 가져와서 x 위치값을 이동시키고 다시 바퀴1에 위치정보를 넣어줌
        /// </summary>
        /// <param name="iMove"></param>
        protected void fCircle2Move(int iMove)
        {
            Point oPoint = _rtCircle2.Location;
            oPoint.X = oPoint.X + iMove;
            _rtCircle2.Location = oPoint;
        }
    }
}
