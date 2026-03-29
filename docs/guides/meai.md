# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Creatomate SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Creatomate's programmatic video and image rendering capabilities.

## Available Tools

| Tool | Description |
|------|-------------|
| `AsCreateRenderTool()` | Create a video, image, or GIF render from a Creatomate template |
| `AsGetRenderStatusTool()` | Get the status and details of a render job, including the output URL |
| `AsListTemplatesTool()` | List all available templates in the project |
| `AsGetTemplateTool()` | Get a template by ID with its full RenderScript source |

## Usage

```csharp
using Creatomate;

var client = new CreatomateClient(apiKey);

// Create tools
var tools = new[]
{
    client.AsCreateRenderTool(),
    client.AsGetRenderStatusTool(),
    client.AsListTemplatesTool(),
    client.AsGetTemplateTool(),
};

// Use with any IChatClient
var response = await chatClient.GetResponseAsync(
    "List all my video templates",
    new ChatOptions { Tools = [.. tools] });
```
