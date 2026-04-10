#nullable enable

namespace Creatomate
{
    public partial interface ICreatomateClient
    {
        /// <summary>
        /// Create a render<br/>
        /// Starts one or multiple renders. A 202 Accepted response is returned when the request<br/>
        /// has been successfully received, along with an array of renders that have been queued.<br/>
        /// Use the render ID from the response to poll the status of the render.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Creatomate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Creatomate.Render>> CreateRenderAsync(

            global::Creatomate.CreateRenderRequest request,
            global::Creatomate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a render<br/>
        /// Starts one or multiple renders. A 202 Accepted response is returned when the request<br/>
        /// has been successfully received, along with an array of renders that have been queued.<br/>
        /// Use the render ID from the response to poll the status of the render.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Creatomate.Render>> CreateRenderAsync(
            string? templateId = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            object? source = default,
            object? modifications = default,
            global::Creatomate.CreateRenderRequestOutputFormat? outputFormat = default,
            double? frameRate = default,
            double? renderScale = default,
            int? maxWidth = default,
            int? maxHeight = default,
            string? webhookUrl = default,
            string? metadata = default,
            global::Creatomate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}