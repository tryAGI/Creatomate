#nullable enable

namespace Creatomate.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateRenderRequestOutputFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Creatomate.CreateRenderRequestOutputFormat>
    {
        /// <inheritdoc />
        public override global::Creatomate.CreateRenderRequestOutputFormat Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Creatomate.CreateRenderRequestOutputFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Creatomate.CreateRenderRequestOutputFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Creatomate.CreateRenderRequestOutputFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Creatomate.CreateRenderRequestOutputFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Creatomate.CreateRenderRequestOutputFormatExtensions.ToValueString(value));
        }
    }
}
