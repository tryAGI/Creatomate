
#nullable enable

namespace Creatomate
{
    /// <summary>
    /// Changes to apply to the template before it is rendered. Keys are element property<br/>
    /// paths and values are the new values to set.
    /// </summary>
    public sealed partial class CreateRenderRequestModifications
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}