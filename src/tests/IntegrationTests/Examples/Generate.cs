/*
order: 10
title: Video Rendering
slug: video-rendering

Basic example showing how to create a client and start a render from a template.
*/

namespace Creatomate.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_CreateClient()
    {
        //// Create a Creatomate client using your API key.
        using var client = GetAuthenticatedClient();

        //// List all templates available in the project.
        var templates = await client.ListTemplatesAsync();

        templates.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Example_GetTemplate()
    {
        using var client = GetAuthenticatedClient();

        var templateId =
            Environment.GetEnvironmentVariable("CREATOMATE_TEMPLATE_ID") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("CREATOMATE_TEMPLATE_ID environment variable is not found.");

        //// Get a template by ID, including its full RenderScript source.
        var template = await client.GetTemplateAsync(
            templateId: Guid.Parse(templateId));

        template.Should().NotBeNull();
        template.Name.Should().NotBeNullOrEmpty();
        template.Source.Should().NotBeNull();
    }
}
