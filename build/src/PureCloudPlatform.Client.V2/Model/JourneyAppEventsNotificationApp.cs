using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// JourneyAppEventsNotificationApp
    /// </summary>
    [DataContract]
    public partial class JourneyAppEventsNotificationApp :  IEquatable<JourneyAppEventsNotificationApp>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyAppEventsNotificationApp" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Namespace">Namespace.</param>
        /// <param name="Version">Version.</param>
        /// <param name="BuildNumber">BuildNumber.</param>
        public JourneyAppEventsNotificationApp(string Name = null, string Namespace = null, string Version = null, string BuildNumber = null)
        {
            this.Name = Name;
            this.Namespace = Namespace;
            this.Version = Version;
            this.BuildNumber = BuildNumber;
            
        }
        


        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Gets or Sets Namespace
        /// </summary>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string Namespace { get; set; }



        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }



        /// <summary>
        /// Gets or Sets BuildNumber
        /// </summary>
        [DataMember(Name="buildNumber", EmitDefaultValue=false)]
        public string BuildNumber { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyAppEventsNotificationApp {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  BuildNumber: ").Append(BuildNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as JourneyAppEventsNotificationApp);
        }

        /// <summary>
        /// Returns true if JourneyAppEventsNotificationApp instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyAppEventsNotificationApp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyAppEventsNotificationApp other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Namespace == other.Namespace ||
                    this.Namespace != null &&
                    this.Namespace.Equals(other.Namespace)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.BuildNumber == other.BuildNumber ||
                    this.BuildNumber != null &&
                    this.BuildNumber.Equals(other.BuildNumber)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Namespace != null)
                    hash = hash * 59 + this.Namespace.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.BuildNumber != null)
                    hash = hash * 59 + this.BuildNumber.GetHashCode();

                return hash;
            }
        }
    }

}
