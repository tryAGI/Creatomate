
#nullable enable

namespace Creatomate
{
    /// <summary>
    /// The current status of the render:<br/>
    /// - planned: The render has been queued<br/>
    /// - waiting: The render is waiting in the queue<br/>
    /// - transcribing: Audio transcription is in progress<br/>
    /// - rendering: The render is being processed<br/>
    /// - succeeded: The render completed successfully<br/>
    /// - failed: The render has failed
    /// </summary>
    public enum RenderStatus
    {
        /// <summary>
        /// The render has failed
        /// </summary>
        Failed,
        /// <summary>
        /// The render has been queued
        /// </summary>
        Planned,
        /// <summary>
        /// The render is being processed
        /// </summary>
        Rendering,
        /// <summary>
        /// The render completed successfully
        /// </summary>
        Succeeded,
        /// <summary>
        /// Audio transcription is in progress
        /// </summary>
        Transcribing,
        /// <summary>
        /// The render is waiting in the queue
        /// </summary>
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RenderStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RenderStatus value)
        {
            return value switch
            {
                RenderStatus.Failed => "failed",
                RenderStatus.Planned => "planned",
                RenderStatus.Rendering => "rendering",
                RenderStatus.Succeeded => "succeeded",
                RenderStatus.Transcribing => "transcribing",
                RenderStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RenderStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => RenderStatus.Failed,
                "planned" => RenderStatus.Planned,
                "rendering" => RenderStatus.Rendering,
                "succeeded" => RenderStatus.Succeeded,
                "transcribing" => RenderStatus.Transcribing,
                "waiting" => RenderStatus.Waiting,
                _ => null,
            };
        }
    }
}