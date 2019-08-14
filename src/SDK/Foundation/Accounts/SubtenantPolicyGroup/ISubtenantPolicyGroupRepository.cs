// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="ISubtenantPolicyGroupRepository.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Foundation;
    using System.Threading.Tasks;
    using MbedCloudSDK.Exceptions;
    using System.Collections.Generic;
    using System;
    using Mbed.Cloud.RestClient;

    /// <summary>
    /// SubtenantPolicyGroupRepository
    /// </summary>
    public interface ISubtenantPolicyGroupRepository
    {
        PaginatedResponse<ISubtenantPolicyGroupSubtenantApiKeyListOptions, SubtenantApiKey> ApiKeys(string accountId, string id, ISubtenantPolicyGroupSubtenantApiKeyListOptions options = null);
        PaginatedResponse<ISubtenantPolicyGroupListOptions, SubtenantPolicyGroup> List(string accountId, ISubtenantPolicyGroupListOptions options = null);
        Task<SubtenantPolicyGroup> Read(string accountId, string id);
        PaginatedResponse<ISubtenantPolicyGroupSubtenantUserListOptions, SubtenantUser> Users(string accountId, string id, ISubtenantPolicyGroupSubtenantUserListOptions options = null);
    }
}