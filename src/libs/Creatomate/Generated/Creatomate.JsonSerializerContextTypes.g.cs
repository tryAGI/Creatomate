
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Creatomate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::Creatomate.CreateRenderRequest? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Creatomate.OneOf<string, double?>? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Creatomate.CreateRenderRequestOutputFormat? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Creatomate.Render? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Creatomate.RenderStatus? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Creatomate.TemplateSummary? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Creatomate.Template? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Creatomate.ErrorResponse? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Creatomate.Render>? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Creatomate.TemplateSummary>? Type17 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Creatomate.Render>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Creatomate.TemplateSummary>? ListType2 { get; set; }
    }
}