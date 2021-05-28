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
    /// TestImport
    /// </summary>
    [DataContract]
    public partial class TestImport :  IEquatable<TestImport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestImport" /> class.
        /// </summary>
        /// <param name="importSettings">importSettings.</param>
        /// <param name="type">type.</param>
        /// <param name="version">version.</param>
        /// <param name="buildId">Build ID that was tested, a reimport may update this field..</param>
        /// <param name="commitHash">Commit hash tested, a reimport may update this field..</param>
        /// <param name="branchTag">Tag or branch that was tested, a reimport may update this field..</param>
        public TestImport(string importSettings = default(string), string type = default(string), string version = default(string), string buildId = default(string), string commitHash = default(string), string branchTag = default(string))
        {
            this.ImportSettings = importSettings;
            this.Type = type;
            this.Version = version;
            this.BuildId = buildId;
            this.CommitHash = commitHash;
            this.BranchTag = branchTag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets TestImportFindingActionSet
        /// </summary>
        [DataMember(Name="test_import_finding_action_set", EmitDefaultValue=false)]
        public List<TestImportFindingAction> TestImportFindingActionSet { get; private set; }

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
        /// Gets or Sets ImportSettings
        /// </summary>
        [DataMember(Name="import_settings", EmitDefaultValue=false)]
        public string ImportSettings { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Build ID that was tested, a reimport may update this field.
        /// </summary>
        /// <value>Build ID that was tested, a reimport may update this field.</value>
        [DataMember(Name="build_id", EmitDefaultValue=false)]
        public string BuildId { get; set; }

        /// <summary>
        /// Commit hash tested, a reimport may update this field.
        /// </summary>
        /// <value>Commit hash tested, a reimport may update this field.</value>
        [DataMember(Name="commit_hash", EmitDefaultValue=false)]
        public string CommitHash { get; set; }

        /// <summary>
        /// Tag or branch that was tested, a reimport may update this field.
        /// </summary>
        /// <value>Tag or branch that was tested, a reimport may update this field.</value>
        [DataMember(Name="branch_tag", EmitDefaultValue=false)]
        public string BranchTag { get; set; }

        /// <summary>
        /// Gets or Sets Test
        /// </summary>
        [DataMember(Name="test", EmitDefaultValue=false)]
        public int? Test { get; private set; }

        /// <summary>
        /// Gets or Sets FindingsAffected
        /// </summary>
        [DataMember(Name="findings_affected", EmitDefaultValue=false)]
        public List<int?> FindingsAffected { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestImport {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TestImportFindingActionSet: ").Append(TestImportFindingActionSet).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  ImportSettings: ").Append(ImportSettings).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  BuildId: ").Append(BuildId).Append("\n");
            sb.Append("  CommitHash: ").Append(CommitHash).Append("\n");
            sb.Append("  BranchTag: ").Append(BranchTag).Append("\n");
            sb.Append("  Test: ").Append(Test).Append("\n");
            sb.Append("  FindingsAffected: ").Append(FindingsAffected).Append("\n");
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
            return this.Equals(input as TestImport);
        }

        /// <summary>
        /// Returns true if TestImport instances are equal
        /// </summary>
        /// <param name="input">Instance of TestImport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestImport input)
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
                    this.TestImportFindingActionSet == input.TestImportFindingActionSet ||
                    this.TestImportFindingActionSet != null &&
                    this.TestImportFindingActionSet.SequenceEqual(input.TestImportFindingActionSet)
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
                    this.ImportSettings == input.ImportSettings ||
                    (this.ImportSettings != null &&
                    this.ImportSettings.Equals(input.ImportSettings))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.BuildId == input.BuildId ||
                    (this.BuildId != null &&
                    this.BuildId.Equals(input.BuildId))
                ) && 
                (
                    this.CommitHash == input.CommitHash ||
                    (this.CommitHash != null &&
                    this.CommitHash.Equals(input.CommitHash))
                ) && 
                (
                    this.BranchTag == input.BranchTag ||
                    (this.BranchTag != null &&
                    this.BranchTag.Equals(input.BranchTag))
                ) && 
                (
                    this.Test == input.Test ||
                    (this.Test != null &&
                    this.Test.Equals(input.Test))
                ) && 
                (
                    this.FindingsAffected == input.FindingsAffected ||
                    this.FindingsAffected != null &&
                    this.FindingsAffected.SequenceEqual(input.FindingsAffected)
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
                if (this.TestImportFindingActionSet != null)
                    hashCode = hashCode * 59 + this.TestImportFindingActionSet.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.ImportSettings != null)
                    hashCode = hashCode * 59 + this.ImportSettings.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.BuildId != null)
                    hashCode = hashCode * 59 + this.BuildId.GetHashCode();
                if (this.CommitHash != null)
                    hashCode = hashCode * 59 + this.CommitHash.GetHashCode();
                if (this.BranchTag != null)
                    hashCode = hashCode * 59 + this.BranchTag.GetHashCode();
                if (this.Test != null)
                    hashCode = hashCode * 59 + this.Test.GetHashCode();
                if (this.FindingsAffected != null)
                    hashCode = hashCode * 59 + this.FindingsAffected.GetHashCode();
                return hashCode;
            }
        }
    }

}
