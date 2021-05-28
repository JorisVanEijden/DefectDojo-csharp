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
    /// FindingTemplate
    /// </summary>
    [DataContract]
    public partial class FindingTemplate :  IEquatable<FindingTemplate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindingTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FindingTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FindingTemplate" /> class.
        /// </summary>
        /// <param name="tags">tags.</param>
        /// <param name="title">title (required).</param>
        /// <param name="cwe">cwe.</param>
        /// <param name="cve">cve.</param>
        /// <param name="cvssv3">cvssv3.</param>
        /// <param name="severity">severity.</param>
        /// <param name="description">description.</param>
        /// <param name="mitigation">mitigation.</param>
        /// <param name="impact">impact.</param>
        /// <param name="references">references.</param>
        /// <param name="templateMatch">Enables this template for matching remediation advice. Match will be applied to all active, verified findings by CWE..</param>
        /// <param name="templateMatchTitle">Matches by title text (contains search) and CWE..</param>
        public FindingTemplate(List<string> tags = default(List<string>), string title = default(string), int? cwe = default(int?), string cve = default(string), string cvssv3 = default(string), string severity = default(string), string description = default(string), string mitigation = default(string), string impact = default(string), string references = default(string), bool? templateMatch = default(bool?), bool? templateMatchTitle = default(bool?))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for FindingTemplate and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            this.Tags = tags;
            this.Cwe = cwe;
            this.Cve = cve;
            this.Cvssv3 = cvssv3;
            this.Severity = severity;
            this.Description = description;
            this.Mitigation = mitigation;
            this.Impact = impact;
            this.References = references;
            this.TemplateMatch = templateMatch;
            this.TemplateMatchTitle = templateMatchTitle;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Cwe
        /// </summary>
        [DataMember(Name="cwe", EmitDefaultValue=false)]
        public int? Cwe { get; set; }

        /// <summary>
        /// Gets or Sets Cve
        /// </summary>
        [DataMember(Name="cve", EmitDefaultValue=false)]
        public string Cve { get; set; }

        /// <summary>
        /// Gets or Sets Cvssv3
        /// </summary>
        [DataMember(Name="cvssv3", EmitDefaultValue=false)]
        public string Cvssv3 { get; set; }

        /// <summary>
        /// Gets or Sets Severity
        /// </summary>
        [DataMember(Name="severity", EmitDefaultValue=false)]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Mitigation
        /// </summary>
        [DataMember(Name="mitigation", EmitDefaultValue=false)]
        public string Mitigation { get; set; }

        /// <summary>
        /// Gets or Sets Impact
        /// </summary>
        [DataMember(Name="impact", EmitDefaultValue=false)]
        public string Impact { get; set; }

        /// <summary>
        /// Gets or Sets References
        /// </summary>
        [DataMember(Name="references", EmitDefaultValue=false)]
        public string References { get; set; }

        /// <summary>
        /// Gets or Sets LastUsed
        /// </summary>
        [DataMember(Name="last_used", EmitDefaultValue=false)]
        public DateTime? LastUsed { get; private set; }

        /// <summary>
        /// Gets or Sets NumericalSeverity
        /// </summary>
        [DataMember(Name="numerical_severity", EmitDefaultValue=false)]
        public string NumericalSeverity { get; private set; }

        /// <summary>
        /// Enables this template for matching remediation advice. Match will be applied to all active, verified findings by CWE.
        /// </summary>
        /// <value>Enables this template for matching remediation advice. Match will be applied to all active, verified findings by CWE.</value>
        [DataMember(Name="template_match", EmitDefaultValue=false)]
        public bool? TemplateMatch { get; set; }

        /// <summary>
        /// Matches by title text (contains search) and CWE.
        /// </summary>
        /// <value>Matches by title text (contains search) and CWE.</value>
        [DataMember(Name="template_match_title", EmitDefaultValue=false)]
        public bool? TemplateMatchTitle { get; set; }

        /// <summary>
        /// Temporary archive with tags from the previous tagging library we used
        /// </summary>
        /// <value>Temporary archive with tags from the previous tagging library we used</value>
        [DataMember(Name="tags_from_django_tagging", EmitDefaultValue=false)]
        public string TagsFromDjangoTagging { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FindingTemplate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Cwe: ").Append(Cwe).Append("\n");
            sb.Append("  Cve: ").Append(Cve).Append("\n");
            sb.Append("  Cvssv3: ").Append(Cvssv3).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Mitigation: ").Append(Mitigation).Append("\n");
            sb.Append("  Impact: ").Append(Impact).Append("\n");
            sb.Append("  References: ").Append(References).Append("\n");
            sb.Append("  LastUsed: ").Append(LastUsed).Append("\n");
            sb.Append("  NumericalSeverity: ").Append(NumericalSeverity).Append("\n");
            sb.Append("  TemplateMatch: ").Append(TemplateMatch).Append("\n");
            sb.Append("  TemplateMatchTitle: ").Append(TemplateMatchTitle).Append("\n");
            sb.Append("  TagsFromDjangoTagging: ").Append(TagsFromDjangoTagging).Append("\n");
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
            return this.Equals(input as FindingTemplate);
        }

        /// <summary>
        /// Returns true if FindingTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of FindingTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FindingTemplate input)
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
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Cwe == input.Cwe ||
                    (this.Cwe != null &&
                    this.Cwe.Equals(input.Cwe))
                ) && 
                (
                    this.Cve == input.Cve ||
                    (this.Cve != null &&
                    this.Cve.Equals(input.Cve))
                ) && 
                (
                    this.Cvssv3 == input.Cvssv3 ||
                    (this.Cvssv3 != null &&
                    this.Cvssv3.Equals(input.Cvssv3))
                ) && 
                (
                    this.Severity == input.Severity ||
                    (this.Severity != null &&
                    this.Severity.Equals(input.Severity))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Mitigation == input.Mitigation ||
                    (this.Mitigation != null &&
                    this.Mitigation.Equals(input.Mitigation))
                ) && 
                (
                    this.Impact == input.Impact ||
                    (this.Impact != null &&
                    this.Impact.Equals(input.Impact))
                ) && 
                (
                    this.References == input.References ||
                    (this.References != null &&
                    this.References.Equals(input.References))
                ) && 
                (
                    this.LastUsed == input.LastUsed ||
                    (this.LastUsed != null &&
                    this.LastUsed.Equals(input.LastUsed))
                ) && 
                (
                    this.NumericalSeverity == input.NumericalSeverity ||
                    (this.NumericalSeverity != null &&
                    this.NumericalSeverity.Equals(input.NumericalSeverity))
                ) && 
                (
                    this.TemplateMatch == input.TemplateMatch ||
                    (this.TemplateMatch != null &&
                    this.TemplateMatch.Equals(input.TemplateMatch))
                ) && 
                (
                    this.TemplateMatchTitle == input.TemplateMatchTitle ||
                    (this.TemplateMatchTitle != null &&
                    this.TemplateMatchTitle.Equals(input.TemplateMatchTitle))
                ) && 
                (
                    this.TagsFromDjangoTagging == input.TagsFromDjangoTagging ||
                    (this.TagsFromDjangoTagging != null &&
                    this.TagsFromDjangoTagging.Equals(input.TagsFromDjangoTagging))
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
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Cwe != null)
                    hashCode = hashCode * 59 + this.Cwe.GetHashCode();
                if (this.Cve != null)
                    hashCode = hashCode * 59 + this.Cve.GetHashCode();
                if (this.Cvssv3 != null)
                    hashCode = hashCode * 59 + this.Cvssv3.GetHashCode();
                if (this.Severity != null)
                    hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Mitigation != null)
                    hashCode = hashCode * 59 + this.Mitigation.GetHashCode();
                if (this.Impact != null)
                    hashCode = hashCode * 59 + this.Impact.GetHashCode();
                if (this.References != null)
                    hashCode = hashCode * 59 + this.References.GetHashCode();
                if (this.LastUsed != null)
                    hashCode = hashCode * 59 + this.LastUsed.GetHashCode();
                if (this.NumericalSeverity != null)
                    hashCode = hashCode * 59 + this.NumericalSeverity.GetHashCode();
                if (this.TemplateMatch != null)
                    hashCode = hashCode * 59 + this.TemplateMatch.GetHashCode();
                if (this.TemplateMatchTitle != null)
                    hashCode = hashCode * 59 + this.TemplateMatchTitle.GetHashCode();
                if (this.TagsFromDjangoTagging != null)
                    hashCode = hashCode * 59 + this.TagsFromDjangoTagging.GetHashCode();
                return hashCode;
            }
        }
    }

}