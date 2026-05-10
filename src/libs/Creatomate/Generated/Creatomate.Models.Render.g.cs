
#nullable enable

namespace Creatomate
{
    /// <summary>
    /// Represents a render job and its output
    /// </summary>
    public sealed partial class Render
    {
        /// <summary>
        /// The unique identifier of the render
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The current status of the render:<br/>
        /// - planned: The render has been queued<br/>
        /// - waiting: The render is waiting in the queue<br/>
        /// - transcribing: Audio transcription is in progress<br/>
        /// - rendering: The render is being processed<br/>
        /// - succeeded: The render completed successfully<br/>
        /// - failed: The render has failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Creatomate.JsonConverters.RenderStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Creatomate.RenderStatus Status { get; set; }

        /// <summary>
        /// Error message if the render has failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// URL to download the rendered file. Only available when status is succeeded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// URL of the snapshot image. Only available when the template has snapshot_time configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshot_url")]
        public string? SnapshotUrl { get; set; }

        /// <summary>
        /// The ID of the template used for this render
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// The name of the template used for this render
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_name")]
        public string? TemplateName { get; set; }

        /// <summary>
        /// Tags of the template used for this render
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_tags")]
        public global::System.Collections.Generic.IList<string>? TemplateTags { get; set; }

        /// <summary>
        /// The output format (jpg, png, gif, mp4)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OutputFormat { get; set; }

        /// <summary>
        /// The scale at which the render was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("render_scale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RenderScale { get; set; }

        /// <summary>
        /// Width of the output in pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Height of the output in pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Frame rate of the output video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_rate")]
        public double? FrameRate { get; set; }

        /// <summary>
        /// Duration of the output in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// File size of the output in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_size")]
        public long? FileSize { get; set; }

        /// <summary>
        /// The modifications that were applied to the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modifications")]
        public object? Modifications { get; set; }

        /// <summary>
        /// The webhook URL that was configured for this render
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// The metadata value that was provided when creating the render
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Render" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the render
        /// </param>
        /// <param name="status">
        /// The current status of the render:<br/>
        /// - planned: The render has been queued<br/>
        /// - waiting: The render is waiting in the queue<br/>
        /// - transcribing: Audio transcription is in progress<br/>
        /// - rendering: The render is being processed<br/>
        /// - succeeded: The render completed successfully<br/>
        /// - failed: The render has failed
        /// </param>
        /// <param name="outputFormat">
        /// The output format (jpg, png, gif, mp4)
        /// </param>
        /// <param name="renderScale">
        /// The scale at which the render was created
        /// </param>
        /// <param name="errorMessage">
        /// Error message if the render has failed
        /// </param>
        /// <param name="url">
        /// URL to download the rendered file. Only available when status is succeeded.
        /// </param>
        /// <param name="snapshotUrl">
        /// URL of the snapshot image. Only available when the template has snapshot_time configured.
        /// </param>
        /// <param name="templateId">
        /// The ID of the template used for this render
        /// </param>
        /// <param name="templateName">
        /// The name of the template used for this render
        /// </param>
        /// <param name="templateTags">
        /// Tags of the template used for this render
        /// </param>
        /// <param name="width">
        /// Width of the output in pixels
        /// </param>
        /// <param name="height">
        /// Height of the output in pixels
        /// </param>
        /// <param name="frameRate">
        /// Frame rate of the output video
        /// </param>
        /// <param name="duration">
        /// Duration of the output in seconds
        /// </param>
        /// <param name="fileSize">
        /// File size of the output in bytes
        /// </param>
        /// <param name="modifications">
        /// The modifications that were applied to the template
        /// </param>
        /// <param name="webhookUrl">
        /// The webhook URL that was configured for this render
        /// </param>
        /// <param name="metadata">
        /// The metadata value that was provided when creating the render
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Render(
            global::System.Guid id,
            global::Creatomate.RenderStatus status,
            string outputFormat,
            double renderScale,
            string? errorMessage,
            string? url,
            string? snapshotUrl,
            string? templateId,
            string? templateName,
            global::System.Collections.Generic.IList<string>? templateTags,
            int? width,
            int? height,
            double? frameRate,
            double? duration,
            long? fileSize,
            object? modifications,
            string? webhookUrl,
            string? metadata)
        {
            this.Id = id;
            this.Status = status;
            this.ErrorMessage = errorMessage;
            this.Url = url;
            this.SnapshotUrl = snapshotUrl;
            this.TemplateId = templateId;
            this.TemplateName = templateName;
            this.TemplateTags = templateTags;
            this.OutputFormat = outputFormat ?? throw new global::System.ArgumentNullException(nameof(outputFormat));
            this.RenderScale = renderScale;
            this.Width = width;
            this.Height = height;
            this.FrameRate = frameRate;
            this.Duration = duration;
            this.FileSize = fileSize;
            this.Modifications = modifications;
            this.WebhookUrl = webhookUrl;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Render" /> class.
        /// </summary>
        public Render()
        {
        }

    }
}