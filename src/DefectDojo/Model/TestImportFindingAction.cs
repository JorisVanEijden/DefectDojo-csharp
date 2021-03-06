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
    /// TestImportFindingAction
    /// </summary>
    [DataContract]
    public partial class TestImportFindingAction :  IEquatable<TestImportFindingAction>
    {
        /// <summary>
        /// Defines Action
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            
            /// <summary>
            /// Enum N for value: N
            /// </summary>
            [EnumMember(Value = "N")]
            N = 1,
            
            /// <summary>
            /// Enum C for value: C
            /// </summary>
            [EnumMember(Value = "C")]
            C = 2,
            
            /// <summary>
            /// Enum R for value: R
            /// </summary>
            [EnumMember(Value = "R")]
            R = 3,
            
            /// <summary>
            /// Enum U for value: U
            /// </summary>
            [EnumMember(Value = "U")]
            U = 4
        }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestImportFindingAction" /> class.
        /// </summary>
        /// <param name="action">action.</param>
        public TestImportFindingAction(ActionEnum? action = default(ActionEnum?))
        {
            this.Action = action;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; private set; }

        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public DateTime? Modified { get; private set; }


        /// <summary>
        /// Gets or Sets TestImport
        /// </summary>
        [DataMember(Name="test_import", EmitDefaultValue=false)]
        public int? TestImport { get; private set; }

        /// <summary>
        /// Gets or Sets Finding
        /// </summary>
        [DataMember(Name="finding", EmitDefaultValue=false)]
        public int? Finding { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestImportFindingAction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  TestImport: ").Append(TestImport).Append("\n");
            sb.Append("  Finding: ").Append(Finding).Append("\n");
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
            return this.Equals(input as TestImportFindingAction);
        }

        /// <summary>
        /// Returns true if TestImportFindingAction instances are equal
        /// </summary>
        /// <param name="input">Instance of TestImportFindingAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestImportFindingAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.TestImport == input.TestImport ||
                    (this.TestImport != null &&
                    this.TestImport.Equals(input.TestImport))
                ) && 
                (
                    this.Finding == input.Finding ||
                    (this.Finding != null &&
                    this.Finding.Equals(input.Finding))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.TestImport != null)
                    hashCode = hashCode * 59 + this.TestImport.GetHashCode();
                if (this.Finding != null)
                    hashCode = hashCode * 59 + this.Finding.GetHashCode();
                return hashCode;
            }
        }
    }

}
