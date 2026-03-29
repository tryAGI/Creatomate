
#nullable enable

namespace Creatomate
{
    public partial class CreatomateClient
    {
        partial void PrepareCreateRenderArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Creatomate.CreateRenderRequest request);
        partial void PrepareCreateRenderRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Creatomate.CreateRenderRequest request);
        partial void ProcessCreateRenderResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateRenderResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a render<br/>
        /// Starts one or multiple renders. A 202 Accepted response is returned when the request<br/>
        /// has been successfully received, along with an array of renders that have been queued.<br/>
        /// Use the render ID from the response to poll the status of the render.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Creatomate.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Creatomate.Render>> CreateRenderAsync(

            global::Creatomate.CreateRenderRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateRenderArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Creatomate.PathBuilder(
                path: "/renders",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateRenderRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateRenderResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::Creatomate.ErrorResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::Creatomate.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::Creatomate.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Creatomate.ApiException<global::Creatomate.ErrorResponse>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Invalid API key
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::Creatomate.ErrorResponse? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::Creatomate.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::Creatomate.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::Creatomate.ApiException<global::Creatomate.ErrorResponse>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Insufficient credits
            if ((int)__response.StatusCode == 402)
            {
                string? __content_402 = null;
                global::System.Exception? __exception_402 = null;
                global::Creatomate.ErrorResponse? __value_402 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_402 = global::Creatomate.ErrorResponse.FromJson(__content_402, JsonSerializerContext);
                    }
                    else
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_402 = global::Creatomate.ErrorResponse.FromJson(__content_402, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_402 = __ex;
                }

                throw new global::Creatomate.ApiException<global::Creatomate.ErrorResponse>(
                    message: __content_402 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_402,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_402,
                    ResponseObject = __value_402,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Rate limit exceeded
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                global::Creatomate.ErrorResponse? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::Creatomate.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = global::Creatomate.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::Creatomate.ApiException<global::Creatomate.ErrorResponse>(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateRenderResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        (global::System.Collections.Generic.IList<global::Creatomate.Render>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::Creatomate.Render>), JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Creatomate.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        (global::System.Collections.Generic.IList<global::Creatomate.Render>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::Creatomate.Render>), JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Creatomate.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Create a render<br/>
        /// Starts one or multiple renders. A 202 Accepted response is returned when the request<br/>
        /// has been successfully received, along with an array of renders that have been queued.<br/>
        /// Use the render ID from the response to poll the status of the render.
        /// </summary>
        /// <param name="templateId">
        /// The ID of the template created in the editor. Either template_id or source must be provided.
        /// </param>
        /// <param name="tags">
        /// Filter templates by tags. When provided, renders are created for all matching templates.
        /// </param>
        /// <param name="source">
        /// A RenderScript object that defines the render. Can be used instead of template_id<br/>
        /// to create renders without a pre-made template.
        /// </param>
        /// <param name="modifications">
        /// Changes to apply to the template before it is rendered. Keys are element property<br/>
        /// paths and values are the new values to set.
        /// </param>
        /// <param name="outputFormat">
        /// The output format of the render. Defaults to the template's output format if not specified.
        /// </param>
        /// <param name="frameRate">
        /// The frame rate of the output video. Only applicable for mp4 and gif output formats.
        /// </param>
        /// <param name="renderScale">
        /// The scale at which to render. The default value is 1.0 (100%).<br/>
        /// Ignored when max_width or max_height is set.
        /// </param>
        /// <param name="maxWidth">
        /// Scales the output so that its width never exceeds the provided number of pixels.
        /// </param>
        /// <param name="maxHeight">
        /// Scales the output so that its height never exceeds the provided number of pixels.
        /// </param>
        /// <param name="webhookUrl">
        /// A URL that is called when the render succeeds or fails.
        /// </param>
        /// <param name="metadata">
        /// A value you want to pass to the webhook URL for identification purposes.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Creatomate.Render>> CreateRenderAsync(
            string? templateId = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            object? source = default,
            object? modifications = default,
            global::Creatomate.CreateRenderRequestOutputFormat? outputFormat = default,
            double? frameRate = default,
            double? renderScale = default,
            int? maxWidth = default,
            int? maxHeight = default,
            string? webhookUrl = default,
            string? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Creatomate.CreateRenderRequest
            {
                TemplateId = templateId,
                Tags = tags,
                Source = source,
                Modifications = modifications,
                OutputFormat = outputFormat,
                FrameRate = frameRate,
                RenderScale = renderScale,
                MaxWidth = maxWidth,
                MaxHeight = maxHeight,
                WebhookUrl = webhookUrl,
                Metadata = metadata,
            };

            return await CreateRenderAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}