#nullable enable

namespace Creatomate
{
    public partial interface ICreatomateClient
    {
        /// <summary>
        /// Get a template by its ID<br/>
        /// Retrieves a specific template by its ID, including its full RenderScript source.<br/>
        /// Template IDs can be found by listing all project templates or from the template<br/>
        /// editor URL in the Creatomate dashboard.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Creatomate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Creatomate.Template> GetTemplateAsync(
            global::System.Guid templateId,
            global::Creatomate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}