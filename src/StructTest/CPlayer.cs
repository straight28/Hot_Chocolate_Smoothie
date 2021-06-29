using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructTest
{
    public class CPlayer
    {
        // 2.클래스 
        //     클래스는 참조 타입
        //     상속이 가능
        //     New 선언 필요
        public int iCount = 0;
        public int iSun = 0;
        public int iStar = 0;
        public int iMoon = 0;


        public int iCardSum = 0;

        public int CardSun(int iSum, int iMoon, int iStar)
        {
            return iSun + iMoon + iStar;
        }

        public string ResultText(int iCount, int iSun, int iMoon, int iStar, int iCardSum)
        {
            return string.Format(" {0}회 해:{1}, 달:{2}, 별:{3} => 합계는 {4} 입니다. ", iCount, iSun, iMoon, iStar, iCardSum);
        }

        public string PlayerPair(int iCount, int iP1CardSum, int iP2CardSum)
        {
            int iCheck = iP1CardSum - iP2CardSum;

            if (iCheck > 0)
            {
                return string.Format("{0}회차 : Player1이 {1}만큼 더 큽니다 ", iCount, iCheck);
            }
            else if (iCheck < 0)
            {
                return string.Format("{0}회차 : Player2이 {1}만큼 더 큽니다 ", iCount, iCheck * -1);
            }
            else
            {
                return string.Format("{0}회차 : Player1과 Player2의 값이 같습니다. ", iCount);
            }
        }

        public string PlayerResult(int iP1CardSum, int iP2CardSum)
        {

            string strReturn = string.Empty;

            if (iP1CardSum > iP2CardSum)
            {
                strReturn = "Player 1이 이겼습니다. ";
            }
            else if (iP1CardSum < iP2CardSum)
            {
                strReturn = "Player 2이 이겼습니다. ";
            }
            else
            {
                strReturn = "비겼습니다. ";
            }

            return strReturn;

        }




    }
}
