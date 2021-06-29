using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public static class Win32ApiHelper
    {

        /// <summary>
        /// 윈도우 찾기
        /// </summary>
        /// <param name="className">클래스명</param>
        /// <param name="windowName">윈도우명</param>
        /// <returns>윈도우 핸들</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string className, string windowName);



        /// <summary>
        /// 메세지 보내기
        /// </summary>
        /// <param name="winodwHandle">윈도우 핸들</param>
        /// <param name="message">메시지</param>
        /// <param name="wordParameter">Word 매개변수</param>
        /// <param name="longParameter">Long 매개변수</param>
        /// <returns>처리 결과</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr winodwHandle, uint message, IntPtr wordParameter, ref CopyDataStruct longParameter);


        /// <summary>
        /// 메세지 보내기
        /// </summary>
        /// <param name="windowHandle">윈도우 핸들</param>
        /// <param name="message">메세지</param>
        /// <param name="wordParameter">word 매개변수 </param>
        /// <param name="longParameter">long 매개변수 </param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr windowHandle, uint message, IntPtr wordParameter, StringBuilder longParameter);


        /// <summary>
        /// 메시지 보내기
        /// </summary>
        /// <param name="windowHandle"></param>
        /// <param name="message"></param>
        /// <param name="wordParameter"></param>
        /// <param name="longParameter"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr windowHandle, uint message, IntPtr wordParameter, [MarshalAs(UnmanagedType.LPStr)] string longParameter);





    }
}
