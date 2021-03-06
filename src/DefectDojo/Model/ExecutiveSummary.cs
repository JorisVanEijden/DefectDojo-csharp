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
    /// ExecutiveSummary
    /// </summary>
    [DataContract]
    public partial class ExecutiveSummary :  IEquatable<ExecutiveSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutiveSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExecutiveSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutiveSummary" /> class.
        /// </summary>
        /// <param name="engagementName">engagementName (required).</param>
        /// <param name="engagementTargetStart">engagementTargetStart (required).</param>
        /// <param name="engagementTargetEnd">engagementTargetEnd (required).</param>
        /// <param name="testTypeName">testTypeName (required).</param>
        /// <param name="testTargetStart">testTargetStart (required).</param>
        /// <param name="testTargetEnd">testTargetEnd (required).</param>
        /// <param name="testEnvironmentName">testEnvironmentName (required).</param>
        /// <param name="testStrategyRef">testStrategyRef (required).</param>
        /// <param name="totalFindings">totalFindings (required).</param>
        public ExecutiveSummary(string engagementName = default(string), DateTime? engagementTargetStart = default(DateTime?), DateTime? engagementTargetEnd = default(DateTime?), string testTypeName = default(string), DateTime? testTargetStart = default(DateTime?), DateTime? testTargetEnd = default(DateTime?), string testEnvironmentName = default(string), string testStrategyRef = default(string), int? totalFindings = default(int?))
        {
            // to ensure "engagementName" is required (not null)
            if (engagementName == null)
            {
                throw new InvalidDataException("engagementName is a required property for ExecutiveSummary and cannot be null");
            }
            else
            {
                this.EngagementName = engagementName;
            }
            // to ensure "engagementTargetStart" is required (not null)
            if (engagementTargetStart == null)
            {
                throw new InvalidDataException("engagementTargetStart is a required property for ExecutiveSummary and cannot be null");
            }
            else
            {
                this.EngagementTargetStart = engagementTargetStart;
            }
            // to ensure "engagementTargetEnd" is required (not null)
            if (engagementTargetEnd == null)
            {
                throw new InvalidDataException("engagementTargetEnd is a required property for ExecutiveSummary and cannot be null");
            }
            else
            {
                this.EngagementTargetEnd = engagementTargetEnd;
            }
            // to ensure "testTypeName" is required (not null)
            if (testTypeName == null)
            {
                throw new InvalidDataException("testTypeName is a required property for ExecutiveSummary and cannot be null");
            }
            else
            {
                this.TestTypeName = testTypeName;
            }
            // to ensure "testTargetStart" is required (not null)
            if (testTargetStart == null)
            {
                throw new InvalidDataException("testTargetStart is a required property for ExecutiveSummary and cannot be null");
            }
            else
            {
                this.TestTargetStart = testTargetStart;
            }
            // to ensure "testTargetEnd" is required (not null)
            if (testTargetEnd == null)
            {
                throw new InvalidDataException("testTargetEnd is a required property for ExecutiveSummary and cannot be null");
            }
            else
            {
                this.TestTargetEnd = testTargetEnd;
            }
            // to ensure "testEnvironmentName" is required (not null)
            if (testEnvironmentName == null)
            {
                throw new InvalidDataException("testEnvironmentName is a required property for ExecutiveSummary and cannot be null");
            }
            else
            {
                this.TestEnvironmentName = testEnvironmentName;
            }
            // to ensure "testStrategyRef" is required (not null)
            if (testStrategyRef == null)
            {
                throw new InvalidDataException("testStrategyRef is a required property for ExecutiveSummary and cannot be null");
            }
            else
            {
                this.TestStrategyRef = testStrategyRef;
            }
            // to ensure "totalFindings" is required (not null)
            if (totalFindings == null)
            {
                throw new InvalidDataException("totalFindings is a required property for ExecutiveSummary and cannot be null");
            }
            else
            {
                this.TotalFindings = totalFindings;
            }
        }
        
        /// <summary>
        /// Gets or Sets EngagementName
        /// </summary>
        [DataMember(Name="engagement_name", EmitDefaultValue=false)]
        public string EngagementName { get; set; }

        /// <summary>
        /// Gets or Sets EngagementTargetStart
        /// </summary>
        [DataMember(Name="engagement_target_start", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EngagementTargetStart { get; set; }

        /// <summary>
        /// Gets or Sets EngagementTargetEnd
        /// </summary>
        [DataMember(Name="engagement_target_end", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EngagementTargetEnd { get; set; }

        /// <summary>
        /// Gets or Sets TestTypeName
        /// </summary>
        [DataMember(Name="test_type_name", EmitDefaultValue=false)]
        public string TestTypeName { get; set; }

        /// <summary>
        /// Gets or Sets TestTargetStart
        /// </summary>
        [DataMember(Name="test_target_start", EmitDefaultValue=false)]
        public DateTime? TestTargetStart { get; set; }

        /// <summary>
        /// Gets or Sets TestTargetEnd
        /// </summary>
        [DataMember(Name="test_target_end", EmitDefaultValue=false)]
        public DateTime? TestTargetEnd { get; set; }

        /// <summary>
        /// Gets or Sets TestEnvironmentName
        /// </summary>
        [DataMember(Name="test_environment_name", EmitDefaultValue=false)]
        public string TestEnvironmentName { get; set; }

        /// <summary>
        /// Gets or Sets TestStrategyRef
        /// </summary>
        [DataMember(Name="test_strategy_ref", EmitDefaultValue=false)]
        public string TestStrategyRef { get; set; }

        /// <summary>
        /// Gets or Sets TotalFindings
        /// </summary>
        [DataMember(Name="total_findings", EmitDefaultValue=false)]
        public int? TotalFindings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecutiveSummary {\n");
            sb.Append("  EngagementName: ").Append(EngagementName).Append("\n");
            sb.Append("  EngagementTargetStart: ").Append(EngagementTargetStart).Append("\n");
            sb.Append("  EngagementTargetEnd: ").Append(EngagementTargetEnd).Append("\n");
            sb.Append("  TestTypeName: ").Append(TestTypeName).Append("\n");
            sb.Append("  TestTargetStart: ").Append(TestTargetStart).Append("\n");
            sb.Append("  TestTargetEnd: ").Append(TestTargetEnd).Append("\n");
            sb.Append("  TestEnvironmentName: ").Append(TestEnvironmentName).Append("\n");
            sb.Append("  TestStrategyRef: ").Append(TestStrategyRef).Append("\n");
            sb.Append("  TotalFindings: ").Append(TotalFindings).Append("\n");
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
            return this.Equals(input as ExecutiveSummary);
        }

        /// <summary>
        /// Returns true if ExecutiveSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ExecutiveSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExecutiveSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EngagementName == input.EngagementName ||
                    (this.EngagementName != null &&
                    this.EngagementName.Equals(input.EngagementName))
                ) && 
                (
                    this.EngagementTargetStart == input.EngagementTargetStart ||
                    (this.EngagementTargetStart != null &&
                    this.EngagementTargetStart.Equals(input.EngagementTargetStart))
                ) && 
                (
                    this.EngagementTargetEnd == input.EngagementTargetEnd ||
                    (this.EngagementTargetEnd != null &&
                    this.EngagementTargetEnd.Equals(input.EngagementTargetEnd))
                ) && 
                (
                    this.TestTypeName == input.TestTypeName ||
                    (this.TestTypeName != null &&
                    this.TestTypeName.Equals(input.TestTypeName))
                ) && 
                (
                    this.TestTargetStart == input.TestTargetStart ||
                    (this.TestTargetStart != null &&
                    this.TestTargetStart.Equals(input.TestTargetStart))
                ) && 
                (
                    this.TestTargetEnd == input.TestTargetEnd ||
                    (this.TestTargetEnd != null &&
                    this.TestTargetEnd.Equals(input.TestTargetEnd))
                ) && 
                (
                    this.TestEnvironmentName == input.TestEnvironmentName ||
                    (this.TestEnvironmentName != null &&
                    this.TestEnvironmentName.Equals(input.TestEnvironmentName))
                ) && 
                (
                    this.TestStrategyRef == input.TestStrategyRef ||
                    (this.TestStrategyRef != null &&
                    this.TestStrategyRef.Equals(input.TestStrategyRef))
                ) && 
                (
                    this.TotalFindings == input.TotalFindings ||
                    (this.TotalFindings != null &&
                    this.TotalFindings.Equals(input.TotalFindings))
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
                if (this.EngagementName != null)
                    hashCode = hashCode * 59 + this.EngagementName.GetHashCode();
                if (this.EngagementTargetStart != null)
                    hashCode = hashCode * 59 + this.EngagementTargetStart.GetHashCode();
                if (this.EngagementTargetEnd != null)
                    hashCode = hashCode * 59 + this.EngagementTargetEnd.GetHashCode();
                if (this.TestTypeName != null)
                    hashCode = hashCode * 59 + this.TestTypeName.GetHashCode();
                if (this.TestTargetStart != null)
                    hashCode = hashCode * 59 + this.TestTargetStart.GetHashCode();
                if (this.TestTargetEnd != null)
                    hashCode = hashCode * 59 + this.TestTargetEnd.GetHashCode();
                if (this.TestEnvironmentName != null)
                    hashCode = hashCode * 59 + this.TestEnvironmentName.GetHashCode();
                if (this.TestStrategyRef != null)
                    hashCode = hashCode * 59 + this.TestStrategyRef.GetHashCode();
                if (this.TotalFindings != null)
                    hashCode = hashCode * 59 + this.TotalFindings.GetHashCode();
                return hashCode;
            }
        }
    }

}
