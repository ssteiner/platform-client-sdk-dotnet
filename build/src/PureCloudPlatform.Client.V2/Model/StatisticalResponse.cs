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
    /// StatisticalResponse
    /// </summary>
    [DataContract]
    public partial class StatisticalResponse :  IEquatable<StatisticalResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticalResponse" /> class.
        /// </summary>
        /// <param name="Interval">Interval.</param>
        /// <param name="Metrics">Metrics.</param>
        /// <param name="Views">Views.</param>
        public StatisticalResponse(string Interval = null, List<AggregateMetricData> Metrics = null, List<AggregateViewData> Views = null)
        {
            this.Interval = Interval;
            this.Metrics = Metrics;
            this.Views = Views;
            
        }
        


        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public string Interval { get; set; }



        /// <summary>
        /// Gets or Sets Metrics
        /// </summary>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<AggregateMetricData> Metrics { get; set; }



        /// <summary>
        /// Gets or Sets Views
        /// </summary>
        [DataMember(Name="views", EmitDefaultValue=false)]
        public List<AggregateViewData> Views { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatisticalResponse {\n");

            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  Views: ").Append(Views).Append("\n");
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
            return this.Equals(obj as StatisticalResponse);
        }

        /// <summary>
        /// Returns true if StatisticalResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of StatisticalResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatisticalResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) &&
                (
                    this.Metrics == other.Metrics ||
                    this.Metrics != null &&
                    this.Metrics.SequenceEqual(other.Metrics)
                ) &&
                (
                    this.Views == other.Views ||
                    this.Views != null &&
                    this.Views.SequenceEqual(other.Views)
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
                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();

                if (this.Metrics != null)
                    hash = hash * 59 + this.Metrics.GetHashCode();

                if (this.Views != null)
                    hash = hash * 59 + this.Views.GetHashCode();

                return hash;
            }
        }
    }

}
