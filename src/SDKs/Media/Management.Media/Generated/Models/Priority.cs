// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for Priority.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Priority
    {
        /// <summary>
        /// Used for TransformOutputs that can be generated after Normal and
        /// High priority TransformOutputs.
        /// </summary>
        [EnumMember(Value = "Low")]
        Low,
        /// <summary>
        /// Used for TransformOutputs that can be generated at Normal priority.
        /// </summary>
        [EnumMember(Value = "Normal")]
        Normal,
        /// <summary>
        /// Used for TransformOutputs that should take precedence over others.
        /// </summary>
        [EnumMember(Value = "High")]
        High
    }
    internal static class PriorityEnumExtension
    {
        internal static string ToSerializedValue(this Priority? value)
        {
            return value == null ? null : ((Priority)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this Priority value)
        {
            switch( value )
            {
                case Priority.Low:
                    return "Low";
                case Priority.Normal:
                    return "Normal";
                case Priority.High:
                    return "High";
            }
            return null;
        }

        internal static Priority? ParsePriority(this string value)
        {
            switch( value )
            {
                case "Low":
                    return Priority.Low;
                case "Normal":
                    return Priority.Normal;
                case "High":
                    return Priority.High;
            }
            return null;
        }
    }
}