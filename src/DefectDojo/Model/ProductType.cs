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
    /// ProductType
    /// </summary>
    [DataContract]
    public partial class ProductType :  IEquatable<ProductType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductType" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="criticalProduct">criticalProduct.</param>
        /// <param name="keyProduct">keyProduct.</param>
        /// <param name="authorizedUsers">authorizedUsers.</param>
        public ProductType(string name = default(string), string description = default(string), bool? criticalProduct = default(bool?), bool? keyProduct = default(bool?), List<int?> authorizedUsers = default(List<int?>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ProductType and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Description = description;
            this.CriticalProduct = criticalProduct;
            this.KeyProduct = keyProduct;
            this.AuthorizedUsers = authorizedUsers;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets CriticalProduct
        /// </summary>
        [DataMember(Name="critical_product", EmitDefaultValue=false)]
        public bool? CriticalProduct { get; set; }

        /// <summary>
        /// Gets or Sets KeyProduct
        /// </summary>
        [DataMember(Name="key_product", EmitDefaultValue=false)]
        public bool? KeyProduct { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public DateTime? Updated { get; private set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; private set; }

        /// <summary>
        /// Gets or Sets AuthorizedUsers
        /// </summary>
        [DataMember(Name="authorized_users", EmitDefaultValue=false)]
        public List<int?> AuthorizedUsers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CriticalProduct: ").Append(CriticalProduct).Append("\n");
            sb.Append("  KeyProduct: ").Append(KeyProduct).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  AuthorizedUsers: ").Append(AuthorizedUsers).Append("\n");
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
            return this.Equals(input as ProductType);
        }

        /// <summary>
        /// Returns true if ProductType instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductType input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CriticalProduct == input.CriticalProduct ||
                    (this.CriticalProduct != null &&
                    this.CriticalProduct.Equals(input.CriticalProduct))
                ) && 
                (
                    this.KeyProduct == input.KeyProduct ||
                    (this.KeyProduct != null &&
                    this.KeyProduct.Equals(input.KeyProduct))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.AuthorizedUsers == input.AuthorizedUsers ||
                    this.AuthorizedUsers != null &&
                    this.AuthorizedUsers.SequenceEqual(input.AuthorizedUsers)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CriticalProduct != null)
                    hashCode = hashCode * 59 + this.CriticalProduct.GetHashCode();
                if (this.KeyProduct != null)
                    hashCode = hashCode * 59 + this.KeyProduct.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.AuthorizedUsers != null)
                    hashCode = hashCode * 59 + this.AuthorizedUsers.GetHashCode();
                return hashCode;
            }
        }
    }

}
