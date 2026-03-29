#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace Creatomate;

public static class CreatomateClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that creates a render from a template with optional modifications.
    /// </summary>
    public static AIFunction AsCreateRenderTool(this CreatomateClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The ID of the template to render")] string templateId,
                   [Description("Output format: jpg, png, gif, or mp4. Defaults to template's format if not specified.")] string? outputFormat,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.CreateRenderAsync(
                    templateId: templateId,
                    outputFormat: outputFormat switch
                    {
                        "jpg" => CreateRenderRequestOutputFormat.Jpg,
                        "png" => CreateRenderRequestOutputFormat.Png,
                        "gif" => CreateRenderRequestOutputFormat.Gif,
                        "mp4" => CreateRenderRequestOutputFormat.Mp4,
                        _ => null,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response.Select(r => new
                {
                    r.Id,
                    Status = r.Status.ToValueString(),
                    r.OutputFormat,
                    r.TemplateId,
                    r.TemplateName,
                }).ToArray();
            },
            name: "Creatomate_CreateRender",
            description: "Create a video, image, or GIF render from a Creatomate template. Returns render IDs to poll for status.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets the status and details of a render.
    /// </summary>
    public static AIFunction AsGetRenderStatusTool(this CreatomateClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The unique identifier (UUID) of the render to check")] string renderId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.GetRenderAsync(
                    renderId: Guid.Parse(renderId),
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Id,
                    Status = response.Status.ToValueString(),
                    response.Url,
                    response.SnapshotUrl,
                    response.OutputFormat,
                    response.Width,
                    response.Height,
                    response.Duration,
                    response.FileSize,
                    response.ErrorMessage,
                };
            },
            name: "Creatomate_GetRenderStatus",
            description: "Get the status and details of a Creatomate render job, including the output URL when complete.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists all templates in the project.
    /// </summary>
    public static AIFunction AsListTemplatesTool(this CreatomateClient client)
    {
        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.ListTemplatesAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response.Select(t => new
                {
                    t.Id,
                    t.Name,
                    t.Tags,
                    t.CreatedAt,
                    t.UpdatedAt,
                }).ToArray();
            },
            name: "Creatomate_ListTemplates",
            description: "List all available templates in the Creatomate project with their names, tags, and timestamps.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets a template by its ID including its RenderScript source.
    /// </summary>
    public static AIFunction AsGetTemplateTool(this CreatomateClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The unique identifier (UUID) of the template to retrieve")] string templateId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.GetTemplateAsync(
                    templateId: Guid.Parse(templateId),
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Id,
                    response.Name,
                    response.Tags,
                    response.Source,
                    response.CreatedAt,
                    response.UpdatedAt,
                };
            },
            name: "Creatomate_GetTemplate",
            description: "Get a Creatomate template by its ID, including the full RenderScript source definition.");
    }
}
