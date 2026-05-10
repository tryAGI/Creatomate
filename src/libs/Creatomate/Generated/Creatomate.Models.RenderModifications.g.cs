
#nullable enable

namespace Creatomate
{
    /// <summary>
    /// The modifications that were applied to the template
    /// </summary>
    public sealed partial class RenderModifications
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}