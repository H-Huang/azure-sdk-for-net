// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Insights.Models
{

    /// <summary>
    /// Defines values for EventLevel.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EventLevel
    {
        [System.Runtime.Serialization.EnumMember(Value = "Critical")]
        Critical,
        [System.Runtime.Serialization.EnumMember(Value = "Error")]
        Error,
        [System.Runtime.Serialization.EnumMember(Value = "Warning")]
        Warning,
        [System.Runtime.Serialization.EnumMember(Value = "Informational")]
        Informational,
        [System.Runtime.Serialization.EnumMember(Value = "Verbose")]
        Verbose
    }
}