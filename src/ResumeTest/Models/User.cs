using System;

namespace ResumeTest.Models
{
    public class User
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
        public string Name { get; set; }
        public string BirthDay { get; set; }
        public string Phone { get; set; }

        public DateTime CreatedDateTime { get; set; }

        /// <summary>
        /// 마지막 로그인 일자
        /// </summary>
        public DateTime LastLoginDateTime { get; set; }

        /// <summary>
        /// 로그인 실패 횟수(5회 이상시 Lock)
        /// </summary>
        public int AccessFailCount { get; set; }

        /// <summary>
        /// Email인증 여부
        /// </summary>
        public bool IsEmailAuthenticated { get; set; }

        /// <summary>
        /// Email 인증 일자
        /// </summary>
        public DateTime EmailAuthenticatedDateTime { get; set; }


        /// <summary>
        /// 계정 비활성화
        /// </summary>
        public bool IsDelete { get; set; }

    }
}
