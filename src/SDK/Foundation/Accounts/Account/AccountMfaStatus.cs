// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="AccountMfaStatus.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation.Enums
{
    using System.Runtime.Serialization;

    public enum AccountMfaStatus
    {
        [EnumMember(Value = "UNKNOWN_ENUM_VALUE_RECEIVED")]
        UNKNOWN_ENUM_VALUE_RECEIVED,
        [EnumMember(Value = "enforced")]
        ENFORCED,
        [EnumMember(Value = "optional")]
        OPTIONAL,
    }
}