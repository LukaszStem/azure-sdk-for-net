// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for PackageState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PackageState
    {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "unmapped")]
        Unmapped
    }
}
