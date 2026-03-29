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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Creatomate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Creatomate.TemplateSummary>> ListTemplatesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}