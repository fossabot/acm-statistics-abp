// <copyright file="CrawlerUsernameSet.cs" company="西北工业大学ACM开发组">
// Copyright (c) 西北工业大学ACM开发组. All rights reserved.
// </copyright>

namespace AcmStatisticsAbp.SubmissionStatistics
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Abp.Domain.Entities;
    using Abp.Domain.Entities.Auditing;
    using AcmStatisticsAbp.Authorization.Users;

    /// <summary>
    /// 存储了某个用户在查题网站上的用户名，某个用户可以有多个 Set，方便切换
    /// </summary>
    [Table("crawler_username_set")]
    public class CrawlerUsernameSet : Entity<long>, IFullAudited<User>, IExtendableObject
    {
        public DateTime CreationTime { get; set; }

        public long? CreatorUserId { get; set; }

        public DateTime? LastModificationTime { get; set; }

        public long? LastModifierUserId { get; set; }

        public User CreatorUser { get; set; }

        public User LastModifierUser { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletionTime { get; set; }

        public long? DeleterUserId { get; set; }

        public User DeleterUser { get; set; }

        public string ExtensionData { get; set; }

        /// <summary>
        /// Gets or sets 使用此 Set 的用户名
        /// </summary>
        public User User { get; set; }

        public long UserId { get; set; }

        /// <summary>
        /// Gets or sets 该订阅的名称，显示给用户，方便用户检索
        /// </summary>
        [MaxLength(128)]
        public string Title { get; set; }

        /// <summary>
        /// 获取用户在各个网站上的用户名，由于这里不能使用ORM的自动更新功能，必须显式设置，因此使用方法而不是属性来操作对象。
        /// </summary>
        /// <returns>用户在各个网站上的用户名</returns>
        public Usernames GetUsernames() => this.GetData<Usernames>("usernames");

        /// <summary>
        /// 设置用户在各个网站上的用户名
        /// </summary>
        /// <param name="usernames"></param>
        public void SetUsernames(Usernames usernames) => this.SetData("usernames", usernames);
    }
}
