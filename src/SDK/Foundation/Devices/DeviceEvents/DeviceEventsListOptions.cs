// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="DeviceEventsListOptions.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Common.Filters;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// DeviceEventsListOptions
    /// </summary>
    public class DeviceEventsListOptions : QueryOptions, IDeviceEventsListOptions
    {
        public DeviceEventsListOptions()
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

        public DeviceEventsListOptions DateTimeIn(params DateTime[] value)
        {
            this.Filter.AddFilterItem("date_time", new FilterItem(value, FilterOperator.In));
            return this;
        }

        public DeviceEventsListOptions DateTimeNotIn(params DateTime[] value)
        {
            this.Filter.AddFilterItem("date_time", new FilterItem(value, FilterOperator.NotIn));
            return this;
        }

        public DeviceEventsListOptions DateTimeLessThan(DateTime value)
        {
            this.Filter.AddFilterItem("date_time", new FilterItem(value, FilterOperator.LessThan));
            return this;
        }

        public DeviceEventsListOptions DateTimeGreaterThan(DateTime value)
        {
            this.Filter.AddFilterItem("date_time", new FilterItem(value, FilterOperator.GreaterThan));
            return this;
        }

        public DeviceEventsListOptions DescriptionEqualTo(string value)
        {
            this.Filter.AddFilterItem("description", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public DeviceEventsListOptions DescriptionNotEqualTo(string value)
        {
            this.Filter.AddFilterItem("description", new FilterItem(value, FilterOperator.NotEqual));
            return this;
        }

        public DeviceEventsListOptions DescriptionIn(params string[] value)
        {
            this.Filter.AddFilterItem("description", new FilterItem(value, FilterOperator.In));
            return this;
        }

        public DeviceEventsListOptions DescriptionNotIn(params string[] value)
        {
            this.Filter.AddFilterItem("description", new FilterItem(value, FilterOperator.NotIn));
            return this;
        }

        public DeviceEventsListOptions IdEqualTo(string value)
        {
            this.Filter.AddFilterItem("id", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public DeviceEventsListOptions IdNotEqualTo(string value)
        {
            this.Filter.AddFilterItem("id", new FilterItem(value, FilterOperator.NotEqual));
            return this;
        }

        public DeviceEventsListOptions IdIn(params string[] value)
        {
            this.Filter.AddFilterItem("id", new FilterItem(value, FilterOperator.In));
            return this;
        }

        public DeviceEventsListOptions IdNotIn(params string[] value)
        {
            this.Filter.AddFilterItem("id", new FilterItem(value, FilterOperator.NotIn));
            return this;
        }

        public DeviceEventsListOptions DeviceIdEqualTo(string value)
        {
            this.Filter.AddFilterItem("device_id", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public DeviceEventsListOptions DeviceIdNotEqualTo(string value)
        {
            this.Filter.AddFilterItem("device_id", new FilterItem(value, FilterOperator.NotEqual));
            return this;
        }

        public DeviceEventsListOptions DeviceIdIn(params string[] value)
        {
            this.Filter.AddFilterItem("device_id", new FilterItem(value, FilterOperator.In));
            return this;
        }

        public DeviceEventsListOptions DeviceIdNotIn(params string[] value)
        {
            this.Filter.AddFilterItem("device_id", new FilterItem(value, FilterOperator.NotIn));
            return this;
        }

        public DeviceEventsListOptions EventTypeEqualTo(string value)
        {
            this.Filter.AddFilterItem("event_type", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public DeviceEventsListOptions EventTypeNotEqualTo(string value)
        {
            this.Filter.AddFilterItem("event_type", new FilterItem(value, FilterOperator.NotEqual));
            return this;
        }

        public DeviceEventsListOptions EventTypeIn(params string[] value)
        {
            this.Filter.AddFilterItem("event_type", new FilterItem(value, FilterOperator.In));
            return this;
        }

        public DeviceEventsListOptions EventTypeNotIn(params string[] value)
        {
            this.Filter.AddFilterItem("event_type", new FilterItem(value, FilterOperator.NotIn));
            return this;
        }

        public DeviceEventsListOptions StateChangeEqualTo(bool value)
        {
            this.Filter.AddFilterItem("state_change", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public DeviceEventsListOptions StateChangeNotEqualTo(bool value)
        {
            this.Filter.AddFilterItem("state_change", new FilterItem(value, FilterOperator.NotEqual));
            return this;
        }
    }
}