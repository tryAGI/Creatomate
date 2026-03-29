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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Creatomate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Creatomate.Render> GetRenderAsync(
            global::System.Guid renderId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}