
#nullable enable

namespace Creatomate
{
    /// <summary>
    /// Error response from the API
    /// </summary>
    public sealed partial class ErrorResponse
    {
        /// <summary>
        /// A human-readable error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hint")]
        public string? Hint { get; set; }

        /// <summary>
        /// A URL to the relevant documentation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentation_url")]
        public string? DocumentationUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        /// <param name="hint">
        /// A human-readable error message
        /// </param>
        /// <param name="documentationUrl">
        /// A URL to the relevant documentation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorResponse(
            string? hint,
            string? documentationUrl)
        {
            this.Hint = hint;
            this.DocumentationUrl = documentationUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        public ErrorResponse()
        {
        }
    }
}