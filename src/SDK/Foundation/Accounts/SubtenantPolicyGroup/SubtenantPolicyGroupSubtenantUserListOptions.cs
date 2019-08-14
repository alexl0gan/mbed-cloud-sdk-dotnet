// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="SubtenantPolicyGroupSubtenantUserListOptions.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Common.Filters;
    using System.Collections.Generic;

    /// <summary>
    /// SubtenantPolicyGroupSubtenantUserListOptions
    /// </summary>
    public class SubtenantPolicyGroupSubtenantUserListOptions : QueryOptions, ISubtenantPolicyGroupSubtenantUserListOptions
    {
        public SubtenantPolicyGroupSubtenantUserListOptions()
        {
            Filter = new Filter();
        }

        /// <summary>
        /// Filter object
        /// </summary>
        public Filter Filter
        {
            get;
            set;
        }

        public SubtenantPolicyGroupSubtenantUserListOptions StatusEqualTo(string value)
        {
            this.Filter.AddFilterItem("status", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public SubtenantPolicyGroupSubtenantUserListOptions StatusIn(params string[] value)
        {
            this.Filter.AddFilterItem("status", new FilterItem(value, FilterOperator.In));
            return this;
        }

        public SubtenantPolicyGroupSubtenantUserListOptions StatusNotIn(params string[] value)
        {
            this.Filter.AddFilterItem("status", new FilterItem(value, FilterOperator.NotIn));
            return this;
        }
    }
}