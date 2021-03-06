﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangfire.HttpJob.Client
{


    /// <summary>
    /// 延迟job
    /// </summary>
    public class BackgroundJob
    {
        public BackgroundJob()
        {
            Method = "Post";
            ContentType = "application/json";
            Timeout = 20000;
            DelayFromMinutes = 15;
            SendFaiMail = true;
        }

        /// <summary>
        /// 请求Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 请求参数
        /// </summary>
        public string Method { get; set; }


        /// <summary>
        /// 参数
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// 请求类型
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// 超时 单位毫秒
        /// </summary>
        public int Timeout { get; set; }

        /// <summary>
        /// 延迟时间 分钟
        /// </summary>
        public int DelayFromMinutes { get; set; }

        /// <summary>
        /// Job名称
        /// </summary>
        public string JobName { get; set; }

        /// <summary>
        /// 是否成功发送邮件
        /// </summary>
        public bool SendSucMail { get; set; }

        /// <summary>
        /// 是否失败发送邮件
        /// </summary>
        public bool SendFaiMail { get; set; }

        /// <summary>
        /// 指定发送邮件
        /// </summary>
        public List<string> Mail { get; set; }

        /// <summary>
        /// 开启失败重启
        /// </summary>
        public bool EnableRetry { get; set; }

        /// <summary>
        /// basic 验证用户名
        /// </summary>
        public string BasicUserName { get; set; }

        /// <summary>
        /// basic 验证密码
        /// </summary>
        public string BasicPassword { get; set; }

        /// <summary>
        /// 代理设置
        /// </summary>
        public string AgentClass { get; set; }
    }
}
