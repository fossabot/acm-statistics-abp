// <copyright file="MailPeriodEnum.cs" company="西北工业大学ACM开发组">
// Copyright (c) 西北工业大学ACM开发组. All rights reserved.
// </copyright>

namespace AcmStatisticsAbp.SubmissionStatistics
{
    /// <summary>
    /// 发送邮件的周期
    /// </summary>
    public enum MailPeriodEnum
    {
        /// <summary>
        /// 每天早上 8 点
        /// </summary>
        Daily = 1,

        /// <summary>
        /// 每周周一早上 8 点
        /// </summary>
        Weekly = 2,

        /// <summary>
        /// 每月 1 日早上 8 点
        /// </summary>
        Monthly = 3,
    }
}
