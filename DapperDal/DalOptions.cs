﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DapperDal
{
    /// <summary>
    /// DAL配置项
    /// </summary>
    public class DalOptions
    {
        /// <summary>
        /// 逻辑删除时更新属性和值的构造器
        /// </summary>
        public Func<object> SoftDeletePropsFactory { get; set; }

        /// <summary>
        /// 逻辑激活时更新属性和值的构造器
        /// </summary>
        public Func<object> SoftActivePropsFactory { get; set; }
    }
}