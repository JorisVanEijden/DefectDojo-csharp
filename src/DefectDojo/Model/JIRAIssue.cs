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
    /// JIRAIssue
    /// </summary>
    [DataContract]
    public partial class JIRAIssue :  IEquatable<JIRAIssue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JIRAIssue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JIRAIssue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JIRAIssue" /> class.
        /// </summary>
        /// <param name="jiraId">jiraId (required).</param>
        /// <param name="jiraKey">jiraKey (required).</param>
        /// <param name="jiraCreation">The date a Jira issue was created from this finding..</param>
        /// <param name="jiraChange">The date the linked Jira issue was last modified..</param>
        /// <param name="jiraProject">jiraProject.</param>
        /// <param name="finding">finding.</param>
        /// <param name="engagement">engagement.</param>
        /// <param name="findingGroup">findingGroup.</param>
        public JIRAIssue(string jiraId = default(string), string jiraKey = default(string), DateTime? jiraCreation = default(DateTime?), DateTime? jiraChange = default(DateTime?), int? jiraProject = default(int?), int? finding = default(int?), int? engagement = default(int?), int? findingGroup = default(int?))
        {
            // to ensure "jiraId" is required (not null)
            if (jiraId == null)
            {
                throw new InvalidDataException("jiraId is a required property for JIRAIssue and cannot be null");
            }
            else
            {
                this.JiraId = jiraId;
            }
            // to ensure "jiraKey" is required (not null)
            if (jiraKey == null)
            {
                throw new InvalidDataException("jiraKey is a required property for JIRAIssue and cannot be null");
            }
            else
            {
                this.JiraKey = jiraKey;
            }
            this.JiraCreation = jiraCreation;
            this.JiraChange = jiraChange;
            this.JiraProject = jiraProject;
            this.Finding = finding;
            this.Engagement = engagement;
            this.FindingGroup = findingGroup;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; private set; }

        /// <summary>
        /// Gets or Sets JiraId
        /// </summary>
        [DataMember(Name="jira_id", EmitDefaultValue=false)]
        public string JiraId { get; set; }

        /// <summary>
        /// Gets or Sets JiraKey
        /// </summary>
        [DataMember(Name="jira_key", EmitDefaultValue=false)]
        public string JiraKey { get; set; }

        /// <summary>
        /// The date a Jira issue was created from this finding.
        /// </summary>
        /// <value>The date a Jira issue was created from this finding.</value>
        [DataMember(Name="jira_creation", EmitDefaultValue=false)]
        public DateTime? JiraCreation { get; set; }

        /// <summary>
        /// The date the linked Jira issue was last modified.
        /// </summary>
        /// <value>The date the linked Jira issue was last modified.</value>
        [DataMember(Name="jira_change", EmitDefaultValue=false)]
        public DateTime? JiraChange { get; set; }

        /// <summary>
        /// Gets or Sets JiraProject
        /// </summary>
        [DataMember(Name="jira_project", EmitDefaultValue=false)]
        public int? JiraProject { get; set; }

        /// <summary>
        /// Gets or Sets Finding
        /// </summary>
        [DataMember(Name="finding", EmitDefaultValue=false)]
        public int? Finding { get; set; }

        /// <summary>
        /// Gets or Sets Engagement
        /// </summary>
        [DataMember(Name="engagement", EmitDefaultValue=false)]
        public int? Engagement { get; set; }

        /// <summary>
        /// Gets or Sets FindingGroup
        /// </summary>
        [DataMember(Name="finding_group", EmitDefaultValue=false)]
        public int? FindingGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JIRAIssue {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  JiraId: ").Append(JiraId).Append("\n");
            sb.Append("  JiraKey: ").Append(JiraKey).Append("\n");
            sb.Append("  JiraCreation: ").Append(JiraCreation).Append("\n");
            sb.Append("  JiraChange: ").Append(JiraChange).Append("\n");
            sb.Append("  JiraProject: ").Append(JiraProject).Append("\n");
            sb.Append("  Finding: ").Append(Finding).Append("\n");
            sb.Append("  Engagement: ").Append(Engagement).Append("\n");
            sb.Append("  FindingGroup: ").Append(FindingGroup).Append("\n");
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
            return this.Equals(input as JIRAIssue);
        }

        /// <summary>
        /// Returns true if JIRAIssue instances are equal
        /// </summary>
        /// <param name="input">Instance of JIRAIssue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JIRAIssue input)
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
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.JiraId == input.JiraId ||
                    (this.JiraId != null &&
                    this.JiraId.Equals(input.JiraId))
                ) && 
                (
                    this.JiraKey == input.JiraKey ||
                    (this.JiraKey != null &&
                    this.JiraKey.Equals(input.JiraKey))
                ) && 
                (
                    this.JiraCreation == input.JiraCreation ||
                    (this.JiraCreation != null &&
                    this.JiraCreation.Equals(input.JiraCreation))
                ) && 
                (
                    this.JiraChange == input.JiraChange ||
                    (this.JiraChange != null &&
                    this.JiraChange.Equals(input.JiraChange))
                ) && 
                (
                    this.JiraProject == input.JiraProject ||
                    (this.JiraProject != null &&
                    this.JiraProject.Equals(input.JiraProject))
                ) && 
                (
                    this.Finding == input.Finding ||
                    (this.Finding != null &&
                    this.Finding.Equals(input.Finding))
                ) && 
                (
                    this.Engagement == input.Engagement ||
                    (this.Engagement != null &&
                    this.Engagement.Equals(input.Engagement))
                ) && 
                (
                    this.FindingGroup == input.FindingGroup ||
                    (this.FindingGroup != null &&
                    this.FindingGroup.Equals(input.FindingGroup))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.JiraId != null)
                    hashCode = hashCode * 59 + this.JiraId.GetHashCode();
                if (this.JiraKey != null)
                    hashCode = hashCode * 59 + this.JiraKey.GetHashCode();
                if (this.JiraCreation != null)
                    hashCode = hashCode * 59 + this.JiraCreation.GetHashCode();
                if (this.JiraChange != null)
                    hashCode = hashCode * 59 + this.JiraChange.GetHashCode();
                if (this.JiraProject != null)
                    hashCode = hashCode * 59 + this.JiraProject.GetHashCode();
                if (this.Finding != null)
                    hashCode = hashCode * 59 + this.Finding.GetHashCode();
                if (this.Engagement != null)
                    hashCode = hashCode * 59 + this.Engagement.GetHashCode();
                if (this.FindingGroup != null)
                    hashCode = hashCode * 59 + this.FindingGroup.GetHashCode();
                return hashCode;
            }
        }
    }

}
