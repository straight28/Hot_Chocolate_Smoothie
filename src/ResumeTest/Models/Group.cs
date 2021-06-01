using System;

namespace ResumeTest.Models
{
    public class Group
    {
        public int Id { get; set; }

        public string CareerType { get; set; }

        /// <summary>
        /// 채용공고 이름
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 채용공고 상세 내용
        /// </summary>
        public string Contents { get; set; }

        /// <summary>
        /// 채용공고 시작 날짜
        /// </summary>
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// 채용공고 종료 날짜
        /// </summary>
        public DateTime EndDateTime { get; set; }

        /// <summary>
        /// 공개여부(Default = false, 비공개)
        /// </summary>
        public bool IsPublic { get; set; } = false;

        /// <summary>
        /// 삭제여부
        /// </summary>
        public bool IsDelete { get; set; }


    }
}
