namespace ResumeTest.Models
{
    public class ApplicationActivity
    {
        public int ApplicationId { get; set; }
        public int Id { get; set; }

        /// <summary>
        /// 활동명
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 역할
        /// </summary>
        public string Role { get; set; }


        /// <summary>
        /// 주체기관
        /// </summary>
        public string Issuser { get; set; }

        /// <summary>
        /// 활동기간
        /// </summary>
        public string Period { get; set; }

        /// <summary>
        /// 활동내역
        /// </summary>
        public string Contents { get; set; }
    }
}
