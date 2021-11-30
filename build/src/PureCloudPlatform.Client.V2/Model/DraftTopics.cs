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
    /// DraftTopics
    /// </summary>
    [DataContract]
    public partial class DraftTopics :  IEquatable<DraftTopics>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DraftTopics" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DraftTopics() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DraftTopics" /> class.
        /// </summary>
        /// <param name="Id">Id for a topic. (required).</param>
        /// <param name="Name">Name/Label for a topic. (required).</param>
        /// <param name="Phrases">The phrases that are extracted for a topic. (required).</param>
        public DraftTopics(string Id = null, string Name = null, List<string> Phrases = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Phrases = Phrases;
            
        }
        
        
        
        /// <summary>
        /// Id for a topic.
        /// </summary>
        /// <value>Id for a topic.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Name/Label for a topic.
        /// </summary>
        /// <value>Name/Label for a topic.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The phrases that are extracted for a topic.
        /// </summary>
        /// <value>The phrases that are extracted for a topic.</value>
        [DataMember(Name="phrases", EmitDefaultValue=false)]
        public List<string> Phrases { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DraftTopics {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Phrases: ").Append(Phrases).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as DraftTopics);
        }

        /// <summary>
        /// Returns true if DraftTopics instances are equal
        /// </summary>
        /// <param name="other">Instance of DraftTopics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DraftTopics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Phrases == other.Phrases ||
                    this.Phrases != null &&
                    this.Phrases.SequenceEqual(other.Phrases)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Phrases != null)
                    hash = hash * 59 + this.Phrases.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}