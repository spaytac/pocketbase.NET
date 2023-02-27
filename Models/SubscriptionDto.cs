using System.Collections.Generic;

namespace pocketbase.net.Models
{
    /// <summary>
    /// Represents tthe 
    /// </summary>
    public class RealtimeEventArgs
    {
        public string id { get; set; } = string.Empty;
        public string @event { get; set; } = string.Empty;//this rule violation not fixed as it conflicts with event keyword
        public Dictionary<string, object> data { get; set; } = new();
    }

    /// <summary>
    /// Stuct contains Actions done on topic
    /// </summary>
    public struct RealtimeActions
    {
        public const string Create = "create";
        public const string Update = "update";
        public const string Delete = "delete";

    }
}