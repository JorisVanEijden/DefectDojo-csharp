/* 
 * Defect Dojo API
 *
 * To use the API you need be authorized.
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

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
using SwaggerDateConverter = DefectDojo.Client.SwaggerDateConverter;

namespace DefectDojo.Model
{
    /// <summary>
    /// InlineResponse20024Prefetch
    /// </summary>
    [DataContract]
    public partial class InlineResponse20024Prefetch :  IEquatable<InlineResponse20024Prefetch>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20024Prefetch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public InlineResponse20024Prefetch()
        {
        }
        
        /// <summary>
        /// Gets or Sets FindingsAffected
        /// </summary>
        [DataMember(Name="findings_affected", EmitDefaultValue=false)]
        public Dictionary<string, Finding> FindingsAffected { get; private set; }

        /// <summary>
        /// Gets or Sets Test
        /// </summary>
        [DataMember(Name="test", EmitDefaultValue=false)]
        public Dictionary<string, Test> Test { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20024Prefetch {\n");
            sb.Append("  FindingsAffected: ").Append(FindingsAffected).Append("\n");
            sb.Append("  Test: ").Append(Test).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InlineResponse20024Prefetch);
        }

        /// <summary>
        /// Returns true if InlineResponse20024Prefetch instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20024Prefetch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20024Prefetch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FindingsAffected == input.FindingsAffected ||
                    this.FindingsAffected != null &&
                    this.FindingsAffected.SequenceEqual(input.FindingsAffected)
                ) && 
                (
                    this.Test == input.Test ||
                    this.Test != null &&
                    this.Test.SequenceEqual(input.Test)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.FindingsAffected != null)
                    hashCode = hashCode * 59 + this.FindingsAffected.GetHashCode();
                if (this.Test != null)
                    hashCode = hashCode * 59 + this.Test.GetHashCode();
                return hashCode;
            }
        }
    }

}
