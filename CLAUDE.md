# CLAUDE.md -- Creatomate SDK

## Overview

Auto-generated C# SDK for [Creatomate](https://creatomate.com/) -- programmatic video and image rendering with templates.
OpenAPI spec manually created from API docs and official Node.js/PHP SDKs (no public OpenAPI spec exists).

## Build & Test

```bash
dotnet build Creatomate.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Standard Bearer token via API key from project settings:

```csharp
var client = new CreatomateClient(apiKey); // CREATOMATE_API_KEY env var
```

## Key Files

- `src/libs/Creatomate/openapi.yaml` -- Manually created OpenAPI 3.0.3 spec
- `src/libs/Creatomate/generate.sh` -- Runs autosdk to generate code
- `src/libs/Creatomate/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Creatomate/Extensions/CreatomateClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## API Endpoints

```csharp
var client = new CreatomateClient(apiKey);

// Renders -- create and poll video/image renders
client.CreateRenderAsync(request)           // POST /v1/renders -- start render(s)
client.GetRenderAsync(renderId)             // GET /v1/renders/{id} -- get render status

// Templates -- list and retrieve templates
client.ListTemplatesAsync()                 // GET /v1/templates -- list all templates
client.GetTemplateAsync(templateId)         // GET /v1/templates/{id} -- get template with source
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsCreateRenderTool()` -- Create a render from a template
- `AsGetRenderStatusTool()` -- Get render status and output URL
- `AsListTemplatesTool()` -- List all templates in the project
- `AsGetTemplateTool()` -- Get template by ID with RenderScript source

## Render Workflow

1. Create render from template: `POST /v1/renders` with `template_id`
2. Poll for completion: `GET /v1/renders/{id}` until `status` is `succeeded` or `failed`
3. Download output from `url` field when succeeded

Statuses: `planned` -> `waiting` -> `transcribing` -> `rendering` -> `succeeded`/`failed`

## Spec Notes

- Base URL: `https://api.creatomate.com/v1`
- Auth: Standard HTTP Bearer (API key from project settings)
- Output formats: jpg, png, gif, mp4
- Render is async: POST returns 202 with queued render(s), poll GET for status
