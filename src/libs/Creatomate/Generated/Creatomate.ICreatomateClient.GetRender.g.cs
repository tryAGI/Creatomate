#nullable enable

namespace Creatomate
{
    public partial interface ICreatomateClient
    {
        /// <summary>
        /// Get the status of a render<br/>
        /// Retrieves the current status of a render by its ID. Use this endpoint to poll<br/>
        /// the progress of a render that was started with the create render endpoint.<br/>
        /// Images are typically ready within seconds, but videos can take longer.
        /// </summary>
        /// <param name="renderId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Creatomate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Creatomate.Render> GetRenderAsync(
            global::System.Guid renderId,
            global::Creatomate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the status of a render<br/>
        /// Retrieves the current status of a render by its ID. Use this endpoint to poll<br/>
        /// the progress of a render that was started with the create render endpoint.<br/>
        /// Images are typically ready within seconds, but videos can take longer.
        /// </summary>
        /// <param name="renderId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Creatomate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Creatomate.AutoSDKHttpResponse<global::Creatomate.Render>> GetRenderAsResponseAsync(
            global::System.Guid renderId,
            global::Creatomate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}