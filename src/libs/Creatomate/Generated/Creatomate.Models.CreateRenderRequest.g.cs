
#nullable enable

namespace Creatomate
{
    /// <summary>
    /// Options for creating a render
    /// </summary>
    public sealed partial class CreateRenderRequest
    {
        /// <summary>
        /// The ID of the template created in the editor. Either template_id or source must be provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// Filter templates by tags. When provided, renders are created for all matching templates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// A RenderScript object that defines the render. Can be used instead of template_id<br/>
        /// to create renders without a pre-made template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public object? Source { get; set; }

        /// <summary>
        /// Changes to apply to the template before it is rendered. Keys are element property<br/>
        /// paths and values are the new values to set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modifications")]
        public object? Modifications { get; set; }

        /// <summary>
        /// The output format of the render. Defaults to the template's output format if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Creatomate.JsonConverters.CreateRenderRequestOutputFormatJsonConverter))]
        public global::Creatomate.CreateRenderRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// The frame rate of the output video. Only applicable for mp4 and gif output formats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_rate")]
        public double? FrameRate { get; set; }

        /// <summary>
        /// The scale at which to render. The default value is 1.0 (100%).<br/>
        /// Ignored when max_width or max_height is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("render_scale")]
        public double? RenderScale { get; set; }

        /// <summary>
        /// Scales the output so that its width never exceeds the provided number of pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_width")]
        public int? MaxWidth { get; set; }

        /// <summary>
        /// Scales the output so that its height never exceeds the provided number of pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_height")]
        public int? MaxHeight { get; set; }

        /// <summary>
        /// A URL that is called when the render succeeds or fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// A value you want to pass to the webhook URL for identification purposes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRenderRequest" /> class.
        /// </summary>
        /// <param name="templateId">
        /// The ID of the template created in the editor. Either template_id or source must be provided.
        /// </param>
        /// <param name="tags">
        /// Filter templates by tags. When provided, renders are created for all matching templates.
        /// </param>
        /// <param name="source">
        /// A RenderScript object that defines the render. Can be used instead of template_id<br/>
        /// to create renders without a pre-made template.
        /// </param>
        /// <param name="modifications">
        /// Changes to apply to the template before it is rendered. Keys are element property<br/>
        /// paths and values are the new values to set.
        /// </param>
        /// <param name="outputFormat">
        /// The output format of the render. Defaults to the template's output format if not specified.
        /// </param>
        /// <param name="frameRate">
        /// The frame rate of the output video. Only applicable for mp4 and gif output formats.
        /// </param>
        /// <param name="renderScale">
        /// The scale at which to render. The default value is 1.0 (100%).<br/>
        /// Ignored when max_width or max_height is set.
        /// </param>
        /// <param name="maxWidth">
        /// Scales the output so that its width never exceeds the provided number of pixels.
        /// </param>
        /// <param name="maxHeight">
        /// Scales the output so that its height never exceeds the provided number of pixels.
        /// </param>
        /// <param name="webhookUrl">
        /// A URL that is called when the render succeeds or fails.
        /// </param>
        /// <param name="metadata">
        /// A value you want to pass to the webhook URL for identification purposes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRenderRequest(
            string? templateId,
            global::System.Collections.Generic.IList<string>? tags,
            object? source,
            object? modifications,
            global::Creatomate.CreateRenderRequestOutputFormat? outputFormat,
            double? frameRate,
            double? renderScale,
            int? maxWidth,
            int? maxHeight,
            string? webhookUrl,
            string? metadata)
        {
            this.TemplateId = templateId;
            this.Tags = tags;
            this.Source = source;
            this.Modifications = modifications;
            this.OutputFormat = outputFormat;
            this.FrameRate = frameRate;
            this.RenderScale = renderScale;
            this.MaxWidth = maxWidth;
            this.MaxHeight = maxHeight;
            this.WebhookUrl = webhookUrl;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRenderRequest" /> class.
        /// </summary>
        public CreateRenderRequest()
        {
        }
    }
}