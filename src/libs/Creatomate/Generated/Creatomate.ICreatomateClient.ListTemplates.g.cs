#nullable enable

namespace Creatomate
{
    public partial interface ICreatomateClient
    {
        /// <summary>
        /// Get all templates in a project<br/>
        /// Returns a list of all template metadata in the project associated with the API key.<br/>
        /// This does not include the template's RenderScript source — use the get template by ID<br/>
        /// endpoint for that.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Creatomate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Creatomate.TemplateSummary>> ListTemplatesAsync(
            global::Creatomate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all templates in a project<br/>
        /// Returns a list of all template metadata in the project associated with the API key.<br/>
        /// This does not include the template's RenderScript source — use the get template by ID<br/>
        /// endpoint for that.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Creatomate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Creatomate.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Creatomate.TemplateSummary>>> ListTemplatesAsResponseAsync(
            global::Creatomate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}