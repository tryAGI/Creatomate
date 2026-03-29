
#nullable enable

namespace Creatomate
{
    /// <summary>
    /// The output format of the render. Defaults to the template's output format if not specified.
    /// </summary>
    public enum CreateRenderRequestOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Gif,
        /// <summary>
        /// 
        /// </summary>
        Jpg,
        /// <summary>
        /// 
        /// </summary>
        Mp4,
        /// <summary>
        /// 
        /// </summary>
        Png,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRenderRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRenderRequestOutputFormat value)
        {
            return value switch
            {
                CreateRenderRequestOutputFormat.Gif => "gif",
                CreateRenderRequestOutputFormat.Jpg => "jpg",
                CreateRenderRequestOutputFormat.Mp4 => "mp4",
                CreateRenderRequestOutputFormat.Png => "png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRenderRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "gif" => CreateRenderRequestOutputFormat.Gif,
                "jpg" => CreateRenderRequestOutputFormat.Jpg,
                "mp4" => CreateRenderRequestOutputFormat.Mp4,
                "png" => CreateRenderRequestOutputFormat.Png,
                _ => null,
            };
        }
    }
}