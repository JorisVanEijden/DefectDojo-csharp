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
    /// ReportGenerateOption
    /// </summary>
    [DataContract]
    public partial class ReportGenerateOption :  IEquatable<ReportGenerateOption>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportGenerateOption" /> class.
        /// </summary>
        /// <param name="includeFindingNotes">includeFindingNotes (default to false).</param>
        /// <param name="includeFindingImages">includeFindingImages (default to false).</param>
        /// <param name="includeExecutiveSummary">includeExecutiveSummary (default to false).</param>
        /// <param name="includeTableOfContents">includeTableOfContents (default to false).</param>
        public ReportGenerateOption(bool? includeFindingNotes = false, bool? includeFindingImages = false, bool? includeExecutiveSummary = false, bool? includeTableOfContents = false)
        {
            // use default value if no "includeFindingNotes" provided
            if (includeFindingNotes == null)
            {
                this.IncludeFindingNotes = false;
            }
            else
            {
                this.IncludeFindingNotes = includeFindingNotes;
            }
            // use default value if no "includeFindingImages" provided
            if (includeFindingImages == null)
            {
                this.IncludeFindingImages = false;
            }
            else
            {
                this.IncludeFindingImages = includeFindingImages;
            }
            // use default value if no "includeExecutiveSummary" provided
            if (includeExecutiveSummary == null)
            {
                this.IncludeExecutiveSummary = false;
            }
            else
            {
                this.IncludeExecutiveSummary = includeExecutiveSummary;
            }
            // use default value if no "includeTableOfContents" provided
            if (includeTableOfContents == null)
            {
                this.IncludeTableOfContents = false;
            }
            else
            {
                this.IncludeTableOfContents = includeTableOfContents;
            }
        }
        
        /// <summary>
        /// Gets or Sets IncludeFindingNotes
        /// </summary>
        [DataMember(Name="include_finding_notes", EmitDefaultValue=false)]
        public bool? IncludeFindingNotes { get; set; }

        /// <summary>
        /// Gets or Sets IncludeFindingImages
        /// </summary>
        [DataMember(Name="include_finding_images", EmitDefaultValue=false)]
        public bool? IncludeFindingImages { get; set; }

        /// <summary>
        /// Gets or Sets IncludeExecutiveSummary
        /// </summary>
        [DataMember(Name="include_executive_summary", EmitDefaultValue=false)]
        public bool? IncludeExecutiveSummary { get; set; }

        /// <summary>
        /// Gets or Sets IncludeTableOfContents
        /// </summary>
        [DataMember(Name="include_table_of_contents", EmitDefaultValue=false)]
        public bool? IncludeTableOfContents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportGenerateOption {\n");
            sb.Append("  IncludeFindingNotes: ").Append(IncludeFindingNotes).Append("\n");
            sb.Append("  IncludeFindingImages: ").Append(IncludeFindingImages).Append("\n");
            sb.Append("  IncludeExecutiveSummary: ").Append(IncludeExecutiveSummary).Append("\n");
            sb.Append("  IncludeTableOfContents: ").Append(IncludeTableOfContents).Append("\n");
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
            return this.Equals(input as ReportGenerateOption);
        }

        /// <summary>
        /// Returns true if ReportGenerateOption instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportGenerateOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportGenerateOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IncludeFindingNotes == input.IncludeFindingNotes ||
                    (this.IncludeFindingNotes != null &&
                    this.IncludeFindingNotes.Equals(input.IncludeFindingNotes))
                ) && 
                (
                    this.IncludeFindingImages == input.IncludeFindingImages ||
                    (this.IncludeFindingImages != null &&
                    this.IncludeFindingImages.Equals(input.IncludeFindingImages))
                ) && 
                (
                    this.IncludeExecutiveSummary == input.IncludeExecutiveSummary ||
                    (this.IncludeExecutiveSummary != null &&
                    this.IncludeExecutiveSummary.Equals(input.IncludeExecutiveSummary))
                ) && 
                (
                    this.IncludeTableOfContents == input.IncludeTableOfContents ||
                    (this.IncludeTableOfContents != null &&
                    this.IncludeTableOfContents.Equals(input.IncludeTableOfContents))
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
                if (this.IncludeFindingNotes != null)
                    hashCode = hashCode * 59 + this.IncludeFindingNotes.GetHashCode();
                if (this.IncludeFindingImages != null)
                    hashCode = hashCode * 59 + this.IncludeFindingImages.GetHashCode();
                if (this.IncludeExecutiveSummary != null)
                    hashCode = hashCode * 59 + this.IncludeExecutiveSummary.GetHashCode();
                if (this.IncludeTableOfContents != null)
                    hashCode = hashCode * 59 + this.IncludeTableOfContents.GetHashCode();
                return hashCode;
            }
        }
    }

}
