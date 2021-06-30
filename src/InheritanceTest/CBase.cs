using System.Drawing;

namespace InheritanceTest
{
    public class CBase
    {
        public string strName;

        protected Pen _Pen;

        public CBase()
        {
            _Pen = new Pen(Color.White);
        }
    }
}
