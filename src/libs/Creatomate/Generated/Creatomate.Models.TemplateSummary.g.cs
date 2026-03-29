
#nullable enable

namespace Creatomate
{
    /// <summary>
    /// Summary of a template (without RenderScript source)
    /// </summary>
    public sealed partial class TemplateSummary
    {
        /// <summary>
        /// The unique identifier of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The display name of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Tags associated with the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// When the template was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the template was last modified
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateSummary" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the template
        /// </param>
        /// <param name="name">
        /// The display name of the template
        /// </param>
        /// <param name="tags">
        /// Tags associated with the template
        /// </param>
        /// <param name="createdAt">
        /// When the template was created
        /// </param>
        /// <param name="updatedAt">
        /// When the template was last modified
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateSummary(
            global::System.Guid id,
            string name,
            global::System.Collections.Generic.IList<string> tags,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateSummary" /> class.
        /// </summary>
        public TemplateSummary()
        {
        }
    }
}