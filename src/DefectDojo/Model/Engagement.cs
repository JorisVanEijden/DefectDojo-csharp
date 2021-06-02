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
    /// Engagement
    /// </summary>
    [DataContract]
    public partial class Engagement :  IEquatable<Engagement>
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum NotStarted for value: Not Started
            /// </summary>
            [EnumMember(Value = "Not Started")]
            NotStarted = 1,
            
            /// <summary>
            /// Enum Blocked for value: Blocked
            /// </summary>
            [EnumMember(Value = "Blocked")]
            Blocked = 2,
            
            /// <summary>
            /// Enum Cancelled for value: Cancelled
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            Cancelled = 3,
            
            /// <summary>
            /// Enum Completed for value: Completed
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed = 4,
            
            /// <summary>
            /// Enum InProgress for value: In Progress
            /// </summary>
            [EnumMember(Value = "In Progress")]
            InProgress = 5,
            
            /// <summary>
            /// Enum OnHold for value: On Hold
            /// </summary>
            [EnumMember(Value = "On Hold")]
            OnHold = 6,
            
            /// <summary>
            /// Enum WaitingforResource for value: Waiting for Resource
            /// </summary>
            [EnumMember(Value = "Waiting for Resource")]
            WaitingforResource = 7
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Defines EngagementType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EngagementTypeEnum
        {
            
            /// <summary>
            /// Enum Interactive for value: Interactive
            /// </summary>
            [EnumMember(Value = "Interactive")]
            Interactive = 1,
            
            /// <summary>
            /// Enum CICD for value: CI/CD
            /// </summary>
            [EnumMember(Value = "CI/CD")]
            CICD = 2
        }

        /// <summary>
        /// Gets or Sets EngagementType
        /// </summary>
        [DataMember(Name="engagement_type", EmitDefaultValue=false)]
        public EngagementTypeEnum? EngagementType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Engagement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Engagement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Engagement" /> class.
        /// </summary>
        /// <param name="tags">tags.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="version">Version of the product the engagement tested..</param>
        /// <param name="firstContacted">firstContacted.</param>
        /// <param name="targetStart">targetStart (required).</param>
        /// <param name="targetEnd">targetEnd (required).</param>
        /// <param name="reason">reason.</param>
        /// <param name="tracker">Link to epic or ticket system with changes to version..</param>
        /// <param name="testStrategy">testStrategy.</param>
        /// <param name="threatModel">threatModel.</param>
        /// <param name="apiTest">apiTest.</param>
        /// <param name="penTest">penTest.</param>
        /// <param name="checkList">checkList.</param>
        /// <param name="status">status.</param>
        /// <param name="engagementType">engagementType.</param>
        /// <param name="buildId">Build ID of the product the engagement tested..</param>
        /// <param name="commitHash">Commit hash from repo.</param>
        /// <param name="branchTag">Tag or branch of the product the engagement tested..</param>
        /// <param name="sourceCodeManagementUri">Resource link to source code.</param>
        /// <param name="deduplicationOnEngagement">If enabled deduplication will only mark a finding in this engagement as duplicate of another finding if both findings are in this engagement. If disabled, deduplication is on the product level..</param>
        /// <param name="engType">engType.</param>
        /// <param name="lead">lead.</param>
        /// <param name="requester">requester.</param>
        /// <param name="preset">Settings and notes for performing this engagement..</param>
        /// <param name="reportType">reportType.</param>
        /// <param name="product">product (required).</param>
        /// <param name="buildServer">Build server responsible for CI/CD test.</param>
        /// <param name="sourceCodeManagementServer">Source code server for CI/CD test.</param>
        /// <param name="orchestrationEngine">Orchestration service responsible for CI/CD test.</param>
        public Engagement(List<string> tags = default(List<string>), string name = default(string), string description = default(string), string version = default(string), DateTime? firstContacted = default(DateTime?), DateTime? targetStart = default(DateTime?), DateTime? targetEnd = default(DateTime?), string reason = default(string), string tracker = default(string), string testStrategy = default(string), bool? threatModel = default(bool?), bool? apiTest = default(bool?), bool? penTest = default(bool?), bool? checkList = default(bool?), StatusEnum? status = default(StatusEnum?), EngagementTypeEnum? engagementType = default(EngagementTypeEnum?), string buildId = default(string), string commitHash = default(string), string branchTag = default(string), string sourceCodeManagementUri = default(string), bool? deduplicationOnEngagement = default(bool?), int? engType = default(int?), int? lead = default(int?), int? requester = default(int?), int? preset = default(int?), int? reportType = default(int?), int? product = default(int?), int? buildServer = default(int?), int? sourceCodeManagementServer = default(int?), int? orchestrationEngine = default(int?))
        {
            // to ensure "targetStart" is required (not null)
            if (targetStart == null)
            {
                throw new InvalidDataException("targetStart is a required property for Engagement and cannot be null");
            }
            else
            {
                this.TargetStart = targetStart;
            }
            // to ensure "targetEnd" is required (not null)
            if (targetEnd == null)
            {
                throw new InvalidDataException("targetEnd is a required property for Engagement and cannot be null");
            }
            else
            {
                this.TargetEnd = targetEnd;
            }
            // to ensure "product" is required (not null)
            if (product == null)
            {
                throw new InvalidDataException("product is a required property for Engagement and cannot be null");
            }
            else
            {
                this.Product = product;
            }
            this.Tags = tags;
            this.Name = name;
            this.Description = description;
            this.Version = version;
            this.FirstContacted = firstContacted;
            this.Reason = reason;
            this.Tracker = tracker;
            this.TestStrategy = testStrategy;
            this.ThreatModel = threatModel;
            this.ApiTest = apiTest;
            this.PenTest = penTest;
            this.CheckList = checkList;
            this.Status = status;
            this.EngagementType = engagementType;
            this.BuildId = buildId;
            this.CommitHash = commitHash;
            this.BranchTag = branchTag;
            this.SourceCodeManagementUri = sourceCodeManagementUri;
            this.DeduplicationOnEngagement = deduplicationOnEngagement;
            this.EngType = engType;
            this.Lead = lead;
            this.Requester = requester;
            this.Preset = preset;
            this.ReportType = reportType;
            this.BuildServer = buildServer;
            this.SourceCodeManagementServer = sourceCodeManagementServer;
            this.OrchestrationEngine = orchestrationEngine;
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
        /// Version of the product the engagement tested.
        /// </summary>
        /// <value>Version of the product the engagement tested.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets FirstContacted
        /// </summary>
        [DataMember(Name="first_contacted", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? FirstContacted { get; set; }

        /// <summary>
        /// Gets or Sets TargetStart
        /// </summary>
        [DataMember(Name="target_start", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? TargetStart { get; set; }

        /// <summary>
        /// Gets or Sets TargetEnd
        /// </summary>
        [DataMember(Name="target_end", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? TargetEnd { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

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
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; private set; }

        /// <summary>
        /// Link to epic or ticket system with changes to version.
        /// </summary>
        /// <value>Link to epic or ticket system with changes to version.</value>
        [DataMember(Name="tracker", EmitDefaultValue=false)]
        public string Tracker { get; set; }

        /// <summary>
        /// Gets or Sets TestStrategy
        /// </summary>
        [DataMember(Name="test_strategy", EmitDefaultValue=false)]
        public string TestStrategy { get; set; }

        /// <summary>
        /// Gets or Sets ThreatModel
        /// </summary>
        [DataMember(Name="threat_model", EmitDefaultValue=false)]
        public bool? ThreatModel { get; set; }

        /// <summary>
        /// Gets or Sets ApiTest
        /// </summary>
        [DataMember(Name="api_test", EmitDefaultValue=false)]
        public bool? ApiTest { get; set; }

        /// <summary>
        /// Gets or Sets PenTest
        /// </summary>
        [DataMember(Name="pen_test", EmitDefaultValue=false)]
        public bool? PenTest { get; set; }

        /// <summary>
        /// Gets or Sets CheckList
        /// </summary>
        [DataMember(Name="check_list", EmitDefaultValue=false)]
        public bool? CheckList { get; set; }


        /// <summary>
        /// Gets or Sets Progress
        /// </summary>
        [DataMember(Name="progress", EmitDefaultValue=false)]
        public string Progress { get; private set; }

        /// <summary>
        /// Gets or Sets TmodelPath
        /// </summary>
        [DataMember(Name="tmodel_path", EmitDefaultValue=false)]
        public string TmodelPath { get; private set; }

        /// <summary>
        /// Gets or Sets DoneTesting
        /// </summary>
        [DataMember(Name="done_testing", EmitDefaultValue=false)]
        public bool? DoneTesting { get; private set; }


        /// <summary>
        /// Build ID of the product the engagement tested.
        /// </summary>
        /// <value>Build ID of the product the engagement tested.</value>
        [DataMember(Name="build_id", EmitDefaultValue=false)]
        public string BuildId { get; set; }

        /// <summary>
        /// Commit hash from repo
        /// </summary>
        /// <value>Commit hash from repo</value>
        [DataMember(Name="commit_hash", EmitDefaultValue=false)]
        public string CommitHash { get; set; }

        /// <summary>
        /// Tag or branch of the product the engagement tested.
        /// </summary>
        /// <value>Tag or branch of the product the engagement tested.</value>
        [DataMember(Name="branch_tag", EmitDefaultValue=false)]
        public string BranchTag { get; set; }

        /// <summary>
        /// Resource link to source code
        /// </summary>
        /// <value>Resource link to source code</value>
        [DataMember(Name="source_code_management_uri", EmitDefaultValue=false)]
        public string SourceCodeManagementUri { get; set; }

        /// <summary>
        /// If enabled deduplication will only mark a finding in this engagement as duplicate of another finding if both findings are in this engagement. If disabled, deduplication is on the product level.
        /// </summary>
        /// <value>If enabled deduplication will only mark a finding in this engagement as duplicate of another finding if both findings are in this engagement. If disabled, deduplication is on the product level.</value>
        [DataMember(Name="deduplication_on_engagement", EmitDefaultValue=false)]
        public bool? DeduplicationOnEngagement { get; set; }

        /// <summary>
        /// Temporary archive with tags from the previous tagging library we used
        /// </summary>
        /// <value>Temporary archive with tags from the previous tagging library we used</value>
        [DataMember(Name="tags_from_django_tagging", EmitDefaultValue=false)]
        public string TagsFromDjangoTagging { get; private set; }

        /// <summary>
        /// Gets or Sets EngType
        /// </summary>
        [DataMember(Name="eng_type", EmitDefaultValue=false)]
        public int? EngType { get; set; }

        /// <summary>
        /// Gets or Sets Lead
        /// </summary>
        [DataMember(Name="lead", EmitDefaultValue=false)]
        public int? Lead { get; set; }

        /// <summary>
        /// Gets or Sets Requester
        /// </summary>
        [DataMember(Name="requester", EmitDefaultValue=false)]
        public int? Requester { get; set; }

        /// <summary>
        /// Settings and notes for performing this engagement.
        /// </summary>
        /// <value>Settings and notes for performing this engagement.</value>
        [DataMember(Name="preset", EmitDefaultValue=false)]
        public int? Preset { get; set; }

        /// <summary>
        /// Gets or Sets ReportType
        /// </summary>
        [DataMember(Name="report_type", EmitDefaultValue=false)]
        public int? ReportType { get; set; }

        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public int? Product { get; set; }

        /// <summary>
        /// Build server responsible for CI/CD test
        /// </summary>
        /// <value>Build server responsible for CI/CD test</value>
        [DataMember(Name="build_server", EmitDefaultValue=false)]
        public int? BuildServer { get; set; }

        /// <summary>
        /// Source code server for CI/CD test
        /// </summary>
        /// <value>Source code server for CI/CD test</value>
        [DataMember(Name="source_code_management_server", EmitDefaultValue=false)]
        public int? SourceCodeManagementServer { get; set; }

        /// <summary>
        /// Orchestration service responsible for CI/CD test
        /// </summary>
        /// <value>Orchestration service responsible for CI/CD test</value>
        [DataMember(Name="orchestration_engine", EmitDefaultValue=false)]
        public int? OrchestrationEngine { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public List<Note> Notes { get; private set; }

        /// <summary>
        /// Gets or Sets Files
        /// </summary>
        [DataMember(Name="files", EmitDefaultValue=false)]
        public List<System.IO.Stream> Files { get; private set; }

        /// <summary>
        /// Gets or Sets RiskAcceptance
        /// </summary>
        [DataMember(Name="risk_acceptance", EmitDefaultValue=false)]
        public List<int?> RiskAcceptance { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Engagement {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  FirstContacted: ").Append(FirstContacted).Append("\n");
            sb.Append("  TargetStart: ").Append(TargetStart).Append("\n");
            sb.Append("  TargetEnd: ").Append(TargetEnd).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Tracker: ").Append(Tracker).Append("\n");
            sb.Append("  TestStrategy: ").Append(TestStrategy).Append("\n");
            sb.Append("  ThreatModel: ").Append(ThreatModel).Append("\n");
            sb.Append("  ApiTest: ").Append(ApiTest).Append("\n");
            sb.Append("  PenTest: ").Append(PenTest).Append("\n");
            sb.Append("  CheckList: ").Append(CheckList).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  TmodelPath: ").Append(TmodelPath).Append("\n");
            sb.Append("  DoneTesting: ").Append(DoneTesting).Append("\n");
            sb.Append("  EngagementType: ").Append(EngagementType).Append("\n");
            sb.Append("  BuildId: ").Append(BuildId).Append("\n");
            sb.Append("  CommitHash: ").Append(CommitHash).Append("\n");
            sb.Append("  BranchTag: ").Append(BranchTag).Append("\n");
            sb.Append("  SourceCodeManagementUri: ").Append(SourceCodeManagementUri).Append("\n");
            sb.Append("  DeduplicationOnEngagement: ").Append(DeduplicationOnEngagement).Append("\n");
            sb.Append("  TagsFromDjangoTagging: ").Append(TagsFromDjangoTagging).Append("\n");
            sb.Append("  EngType: ").Append(EngType).Append("\n");
            sb.Append("  Lead: ").Append(Lead).Append("\n");
            sb.Append("  Requester: ").Append(Requester).Append("\n");
            sb.Append("  Preset: ").Append(Preset).Append("\n");
            sb.Append("  ReportType: ").Append(ReportType).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  BuildServer: ").Append(BuildServer).Append("\n");
            sb.Append("  SourceCodeManagementServer: ").Append(SourceCodeManagementServer).Append("\n");
            sb.Append("  OrchestrationEngine: ").Append(OrchestrationEngine).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("  RiskAcceptance: ").Append(RiskAcceptance).Append("\n");
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
            return this.Equals(input as Engagement);
        }

        /// <summary>
        /// Returns true if Engagement instances are equal
        /// </summary>
        /// <param name="input">Instance of Engagement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Engagement input)
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
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.FirstContacted == input.FirstContacted ||
                    (this.FirstContacted != null &&
                    this.FirstContacted.Equals(input.FirstContacted))
                ) && 
                (
                    this.TargetStart == input.TargetStart ||
                    (this.TargetStart != null &&
                    this.TargetStart.Equals(input.TargetStart))
                ) && 
                (
                    this.TargetEnd == input.TargetEnd ||
                    (this.TargetEnd != null &&
                    this.TargetEnd.Equals(input.TargetEnd))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
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
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Tracker == input.Tracker ||
                    (this.Tracker != null &&
                    this.Tracker.Equals(input.Tracker))
                ) && 
                (
                    this.TestStrategy == input.TestStrategy ||
                    (this.TestStrategy != null &&
                    this.TestStrategy.Equals(input.TestStrategy))
                ) && 
                (
                    this.ThreatModel == input.ThreatModel ||
                    (this.ThreatModel != null &&
                    this.ThreatModel.Equals(input.ThreatModel))
                ) && 
                (
                    this.ApiTest == input.ApiTest ||
                    (this.ApiTest != null &&
                    this.ApiTest.Equals(input.ApiTest))
                ) && 
                (
                    this.PenTest == input.PenTest ||
                    (this.PenTest != null &&
                    this.PenTest.Equals(input.PenTest))
                ) && 
                (
                    this.CheckList == input.CheckList ||
                    (this.CheckList != null &&
                    this.CheckList.Equals(input.CheckList))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
                ) && 
                (
                    this.TmodelPath == input.TmodelPath ||
                    (this.TmodelPath != null &&
                    this.TmodelPath.Equals(input.TmodelPath))
                ) && 
                (
                    this.DoneTesting == input.DoneTesting ||
                    (this.DoneTesting != null &&
                    this.DoneTesting.Equals(input.DoneTesting))
                ) && 
                (
                    this.EngagementType == input.EngagementType ||
                    (this.EngagementType != null &&
                    this.EngagementType.Equals(input.EngagementType))
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
                    this.SourceCodeManagementUri == input.SourceCodeManagementUri ||
                    (this.SourceCodeManagementUri != null &&
                    this.SourceCodeManagementUri.Equals(input.SourceCodeManagementUri))
                ) && 
                (
                    this.DeduplicationOnEngagement == input.DeduplicationOnEngagement ||
                    (this.DeduplicationOnEngagement != null &&
                    this.DeduplicationOnEngagement.Equals(input.DeduplicationOnEngagement))
                ) && 
                (
                    this.TagsFromDjangoTagging == input.TagsFromDjangoTagging ||
                    (this.TagsFromDjangoTagging != null &&
                    this.TagsFromDjangoTagging.Equals(input.TagsFromDjangoTagging))
                ) && 
                (
                    this.EngType == input.EngType ||
                    (this.EngType != null &&
                    this.EngType.Equals(input.EngType))
                ) && 
                (
                    this.Lead == input.Lead ||
                    (this.Lead != null &&
                    this.Lead.Equals(input.Lead))
                ) && 
                (
                    this.Requester == input.Requester ||
                    (this.Requester != null &&
                    this.Requester.Equals(input.Requester))
                ) && 
                (
                    this.Preset == input.Preset ||
                    (this.Preset != null &&
                    this.Preset.Equals(input.Preset))
                ) && 
                (
                    this.ReportType == input.ReportType ||
                    (this.ReportType != null &&
                    this.ReportType.Equals(input.ReportType))
                ) && 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
                ) && 
                (
                    this.BuildServer == input.BuildServer ||
                    (this.BuildServer != null &&
                    this.BuildServer.Equals(input.BuildServer))
                ) && 
                (
                    this.SourceCodeManagementServer == input.SourceCodeManagementServer ||
                    (this.SourceCodeManagementServer != null &&
                    this.SourceCodeManagementServer.Equals(input.SourceCodeManagementServer))
                ) && 
                (
                    this.OrchestrationEngine == input.OrchestrationEngine ||
                    (this.OrchestrationEngine != null &&
                    this.OrchestrationEngine.Equals(input.OrchestrationEngine))
                ) && 
                (
                    this.Notes == input.Notes ||
                    this.Notes != null &&
                    this.Notes.SequenceEqual(input.Notes)
                ) && 
                (
                    this.Files == input.Files ||
                    this.Files != null &&
                    this.Files.SequenceEqual(input.Files)
                ) && 
                (
                    this.RiskAcceptance == input.RiskAcceptance ||
                    this.RiskAcceptance != null &&
                    this.RiskAcceptance.SequenceEqual(input.RiskAcceptance)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.FirstContacted != null)
                    hashCode = hashCode * 59 + this.FirstContacted.GetHashCode();
                if (this.TargetStart != null)
                    hashCode = hashCode * 59 + this.TargetStart.GetHashCode();
                if (this.TargetEnd != null)
                    hashCode = hashCode * 59 + this.TargetEnd.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Tracker != null)
                    hashCode = hashCode * 59 + this.Tracker.GetHashCode();
                if (this.TestStrategy != null)
                    hashCode = hashCode * 59 + this.TestStrategy.GetHashCode();
                if (this.ThreatModel != null)
                    hashCode = hashCode * 59 + this.ThreatModel.GetHashCode();
                if (this.ApiTest != null)
                    hashCode = hashCode * 59 + this.ApiTest.GetHashCode();
                if (this.PenTest != null)
                    hashCode = hashCode * 59 + this.PenTest.GetHashCode();
                if (this.CheckList != null)
                    hashCode = hashCode * 59 + this.CheckList.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.TmodelPath != null)
                    hashCode = hashCode * 59 + this.TmodelPath.GetHashCode();
                if (this.DoneTesting != null)
                    hashCode = hashCode * 59 + this.DoneTesting.GetHashCode();
                if (this.EngagementType != null)
                    hashCode = hashCode * 59 + this.EngagementType.GetHashCode();
                if (this.BuildId != null)
                    hashCode = hashCode * 59 + this.BuildId.GetHashCode();
                if (this.CommitHash != null)
                    hashCode = hashCode * 59 + this.CommitHash.GetHashCode();
                if (this.BranchTag != null)
                    hashCode = hashCode * 59 + this.BranchTag.GetHashCode();
                if (this.SourceCodeManagementUri != null)
                    hashCode = hashCode * 59 + this.SourceCodeManagementUri.GetHashCode();
                if (this.DeduplicationOnEngagement != null)
                    hashCode = hashCode * 59 + this.DeduplicationOnEngagement.GetHashCode();
                if (this.TagsFromDjangoTagging != null)
                    hashCode = hashCode * 59 + this.TagsFromDjangoTagging.GetHashCode();
                if (this.EngType != null)
                    hashCode = hashCode * 59 + this.EngType.GetHashCode();
                if (this.Lead != null)
                    hashCode = hashCode * 59 + this.Lead.GetHashCode();
                if (this.Requester != null)
                    hashCode = hashCode * 59 + this.Requester.GetHashCode();
                if (this.Preset != null)
                    hashCode = hashCode * 59 + this.Preset.GetHashCode();
                if (this.ReportType != null)
                    hashCode = hashCode * 59 + this.ReportType.GetHashCode();
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.BuildServer != null)
                    hashCode = hashCode * 59 + this.BuildServer.GetHashCode();
                if (this.SourceCodeManagementServer != null)
                    hashCode = hashCode * 59 + this.SourceCodeManagementServer.GetHashCode();
                if (this.OrchestrationEngine != null)
                    hashCode = hashCode * 59 + this.OrchestrationEngine.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.Files != null)
                    hashCode = hashCode * 59 + this.Files.GetHashCode();
                if (this.RiskAcceptance != null)
                    hashCode = hashCode * 59 + this.RiskAcceptance.GetHashCode();
                return hashCode;
            }
        }
    }

}
