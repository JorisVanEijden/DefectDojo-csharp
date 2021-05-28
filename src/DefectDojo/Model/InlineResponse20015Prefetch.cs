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
    /// InlineResponse20015Prefetch
    /// </summary>
    [DataContract]
    public partial class InlineResponse20015Prefetch :  IEquatable<InlineResponse20015Prefetch>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20015Prefetch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public InlineResponse20015Prefetch()
        {
        }
        
        /// <summary>
        /// Gets or Sets AuthorizedUsers
        /// </summary>
        [DataMember(Name="authorized_users", EmitDefaultValue=false)]
        public Dictionary<string, UserStub> AuthorizedUsers { get; private set; }

        /// <summary>
        /// Gets or Sets Members
        /// </summary>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public Dictionary<string, UserStub> Members { get; private set; }

        /// <summary>
        /// Gets or Sets ProdType
        /// </summary>
        [DataMember(Name="prod_type", EmitDefaultValue=false)]
        public Dictionary<string, ProductType> ProdType { get; private set; }

        /// <summary>
        /// Gets or Sets ProductManager
        /// </summary>
        [DataMember(Name="product_manager", EmitDefaultValue=false)]
        public Dictionary<string, UserStub> ProductManager { get; private set; }

        /// <summary>
        /// Gets or Sets Regulations
        /// </summary>
        [DataMember(Name="regulations", EmitDefaultValue=false)]
        public Dictionary<string, Regulation> Regulations { get; private set; }

        /// <summary>
        /// Gets or Sets TeamManager
        /// </summary>
        [DataMember(Name="team_manager", EmitDefaultValue=false)]
        public Dictionary<string, UserStub> TeamManager { get; private set; }

        /// <summary>
        /// Gets or Sets TechnicalContact
        /// </summary>
        [DataMember(Name="technical_contact", EmitDefaultValue=false)]
        public Dictionary<string, UserStub> TechnicalContact { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20015Prefetch {\n");
            sb.Append("  AuthorizedUsers: ").Append(AuthorizedUsers).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  ProdType: ").Append(ProdType).Append("\n");
            sb.Append("  ProductManager: ").Append(ProductManager).Append("\n");
            sb.Append("  Regulations: ").Append(Regulations).Append("\n");
            sb.Append("  TeamManager: ").Append(TeamManager).Append("\n");
            sb.Append("  TechnicalContact: ").Append(TechnicalContact).Append("\n");
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
            return this.Equals(input as InlineResponse20015Prefetch);
        }

        /// <summary>
        /// Returns true if InlineResponse20015Prefetch instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20015Prefetch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20015Prefetch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthorizedUsers == input.AuthorizedUsers ||
                    this.AuthorizedUsers != null &&
                    this.AuthorizedUsers.SequenceEqual(input.AuthorizedUsers)
                ) && 
                (
                    this.Members == input.Members ||
                    this.Members != null &&
                    this.Members.SequenceEqual(input.Members)
                ) && 
                (
                    this.ProdType == input.ProdType ||
                    this.ProdType != null &&
                    this.ProdType.SequenceEqual(input.ProdType)
                ) && 
                (
                    this.ProductManager == input.ProductManager ||
                    this.ProductManager != null &&
                    this.ProductManager.SequenceEqual(input.ProductManager)
                ) && 
                (
                    this.Regulations == input.Regulations ||
                    this.Regulations != null &&
                    this.Regulations.SequenceEqual(input.Regulations)
                ) && 
                (
                    this.TeamManager == input.TeamManager ||
                    this.TeamManager != null &&
                    this.TeamManager.SequenceEqual(input.TeamManager)
                ) && 
                (
                    this.TechnicalContact == input.TechnicalContact ||
                    this.TechnicalContact != null &&
                    this.TechnicalContact.SequenceEqual(input.TechnicalContact)
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
                if (this.AuthorizedUsers != null)
                    hashCode = hashCode * 59 + this.AuthorizedUsers.GetHashCode();
                if (this.Members != null)
                    hashCode = hashCode * 59 + this.Members.GetHashCode();
                if (this.ProdType != null)
                    hashCode = hashCode * 59 + this.ProdType.GetHashCode();
                if (this.ProductManager != null)
                    hashCode = hashCode * 59 + this.ProductManager.GetHashCode();
                if (this.Regulations != null)
                    hashCode = hashCode * 59 + this.Regulations.GetHashCode();
                if (this.TeamManager != null)
                    hashCode = hashCode * 59 + this.TeamManager.GetHashCode();
                if (this.TechnicalContact != null)
                    hashCode = hashCode * 59 + this.TechnicalContact.GetHashCode();
                return hashCode;
            }
        }
    }

}