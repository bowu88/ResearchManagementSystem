﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.FB
{
    public class MatchAndJudge
    {
        public int MatchID { get; set; }
        public String MatchName { get; set; }
        public DateTime DeadLine { get; set; }
        public String Status { get; set; }
        public DateTime DeclarantDeadLine { get; set; }
        public int MatchModel { get; set; }
        public String ProjectID { get; set; }
        public String MatchCollege { get; set; }
        public String Rule { get; set; }
        public String ScoreIntro { get; set; }
        /// <summary>
        /// Id
        /// </summary>
        public int JudgeId { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 工作单位
        /// </summary>
        public string WorkUnits { get; set; }
        /// <summary>
        /// 职称
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 校园卡号
        /// </summary>
        public string CampusId { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        public string JobId { get; set; }
        /// <summary>
        /// 学历
        /// </summary>
        public string Background { get; set; }
        /// <summary>
        /// 研究方向
        /// </summary>
        public string Research { get; set; }
        /// <summary>
        /// 学院
        /// </summary>
        public string JudgeCollege { get; set; }
    }
}
