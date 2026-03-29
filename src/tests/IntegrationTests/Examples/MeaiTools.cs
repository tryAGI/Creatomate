/*
order: 20
title: MEAI Tools
slug: meai-tools

Using Creatomate as AIFunction tools with any Microsoft.Extensions.AI IChatClient.
*/

namespace Creatomate.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_CreateTools()
    {
        using var client = GetAuthenticatedClient();

        //// Create AIFunction tools from the Creatomate client.
        var createRenderTool = client.AsCreateRenderTool();
        var getRenderStatusTool = client.AsGetRenderStatusTool();
        var listTemplatesTool = client.AsListTemplatesTool();
        var getTemplateTool = client.AsGetTemplateTool();

        //// Verify all tools are created with the expected names.
        createRenderTool.Name.Should().Be("Creatomate_CreateRender");
        getRenderStatusTool.Name.Should().Be("Creatomate_GetRenderStatus");
        listTemplatesTool.Name.Should().Be("Creatomate_ListTemplates");
        getTemplateTool.Name.Should().Be("Creatomate_GetTemplate");

        //// These tools can be passed to any IChatClient for function calling.
        var tools = new[] { createRenderTool, getRenderStatusTool, listTemplatesTool, getTemplateTool };
        tools.Should().HaveCount(4);
    }
}
