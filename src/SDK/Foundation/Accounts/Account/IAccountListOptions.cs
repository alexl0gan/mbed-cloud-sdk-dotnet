// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="IAccountListOptions.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Common.Filters;
    using Mbed.Cloud.Foundation.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// AccountListOptions
    /// </summary>
    public interface IAccountListOptions : IQueryOptions
    {
        /// <summary>
        /// 
        /// </summary>
        string Format
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        string Properties
        {
            get;
            set;
        }

        /// <summary>
        /// Filter object
        /// </summary>
        Filter Filter
        {
            get;
            set;
        }

        AccountListOptions StatusEqualTo(AccountStatus value);
        AccountListOptions StatusIn(params AccountStatus[] value);
        AccountListOptions StatusNotIn(params AccountStatus[] value);
        AccountListOptions TierEqualTo(string value);
        AccountListOptions ParentEqualTo(string value);
        AccountListOptions EndMarketEqualTo(string value);
        AccountListOptions CountryLike(string value);
    }
}