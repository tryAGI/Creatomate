# Microsoft.Extensions.AI Integration

The Creatomate SDK provides `AIFunction` tools that can be used with any `IChatClient` for function/tool calling.

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
