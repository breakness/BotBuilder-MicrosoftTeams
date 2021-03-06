// <auto-generated /> Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.Teams.Models
{
    using System.Linq;

    /// <summary>
    /// Specifies if a notification is to be sent for the mentions.
    /// </summary>
    public partial class NotificationInfo
    {
        /// <summary>
        /// Initializes a new instance of the NotificationInfo class.
        /// </summary>
        public NotificationInfo() { }

        /// <summary>
        /// Initializes a new instance of the NotificationInfo class.
        /// </summary>
        /// <param name="alert">true if notification is to be sent to the
        /// user, false otherwise.</param>
        public NotificationInfo(bool? alert = default(bool?))
        {
            Alert = alert;
        }

        /// <summary>
        /// Gets or sets true if notification is to be sent to the user, false
        /// otherwise.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "alert")]
        public bool? Alert { get; set; }

    }
}
