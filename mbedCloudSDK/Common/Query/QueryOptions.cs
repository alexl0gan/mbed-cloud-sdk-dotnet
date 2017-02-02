﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace mbedCloudSDK.Common.Query
{
	/// <summary>
	/// Parameters send with list requests.
	/// </summary>
	public class QueryOptions
	{
		/// <summary>
		/// Gets or sets the limit of objects in response.
		/// </summary>
		/// <value>The limit.</value>
		public int? Limit { get; set; }

		/// <summary>
		/// Gets or sets the order.
		/// </summary>
		/// <value>The order (ASC or DESC, default ASC).</value>
		public string Order { get; set; }

		/// <summary>
		/// Gets or sets the after.
		/// </summary>
		/// <value>Objects after given element.</value>
		public string After { get; set; }

        /// <summary>
        /// Get Query String.
        /// </summary>
        public virtual string QueryString
        {
            get
            {
                return Attributes != null ? string.Join("&", Attributes.Select(q => String.Format("{0}={1}", q.Key, q.Value))) : string.Empty;
            }
        }

        /// <summary>
        /// List of query attributes.
        /// </summary>
        public Dictionary<string, QueryAttribute> Attributes { get; set; }


        /// <summary>
        /// Gets or sets the include.
        /// </summary>
        /// <value>Comma separate additional data to return. Currently supported: total_count.</value>
        public string Include { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:mbedCloudSDK.Common.ListParams"/> class.
        /// </summary>
        /// <param name="limit">Limit.</param>
        /// <param name="order">Order.</param>
        /// <param name="after">After.</param>
        /// <param name="attributes">Attributes.</param>
        /// <param name="include">Include.</param>
        public QueryOptions(int? limit = null, string order = null, string after = null, string include = null, Dictionary<string, QueryAttribute> attributes = null)
		{
			this.Limit = limit;
			this.Order = order;
            this.After = after;
			this.Include = include;
            this.Attributes = attributes;
		} 
	}
}