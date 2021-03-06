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
    /// Note
    /// </summary>
    [DataContract]
    public partial class Note :  IEquatable<Note>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Note" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Note() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Note" /> class.
        /// </summary>
        /// <param name="author">author.</param>
        /// <param name="editor">editor.</param>
        /// <param name="entry">entry (required).</param>
        /// <param name="_private">_private.</param>
        /// <param name="edited">edited.</param>
        /// <param name="noteType">noteType.</param>
        public Note(UserStub author = default(UserStub), UserStub editor = default(UserStub), string entry = default(string), bool? _private = default(bool?), bool? edited = default(bool?), int? noteType = default(int?))
        {
            // to ensure "entry" is required (not null)
            if (entry == null)
            {
                throw new InvalidDataException("entry is a required property for Note and cannot be null");
            }
            else
            {
                this.Entry = entry;
            }
            this.Author = author;
            this.Editor = editor;
            this.Private = _private;
            this.Edited = edited;
            this.NoteType = noteType;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public UserStub Author { get; set; }

        /// <summary>
        /// Gets or Sets Editor
        /// </summary>
        [DataMember(Name="editor", EmitDefaultValue=false)]
        public UserStub Editor { get; set; }

        /// <summary>
        /// Gets or Sets History
        /// </summary>
        [DataMember(Name="history", EmitDefaultValue=false)]
        public List<NoteHistory> History { get; private set; }

        /// <summary>
        /// Gets or Sets Entry
        /// </summary>
        [DataMember(Name="entry", EmitDefaultValue=false)]
        public string Entry { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; private set; }

        /// <summary>
        /// Gets or Sets Private
        /// </summary>
        [DataMember(Name="private", EmitDefaultValue=false)]
        public bool? Private { get; set; }

        /// <summary>
        /// Gets or Sets Edited
        /// </summary>
        [DataMember(Name="edited", EmitDefaultValue=false)]
        public bool? Edited { get; set; }

        /// <summary>
        /// Gets or Sets EditTime
        /// </summary>
        [DataMember(Name="edit_time", EmitDefaultValue=false)]
        public DateTime? EditTime { get; private set; }

        /// <summary>
        /// Gets or Sets NoteType
        /// </summary>
        [DataMember(Name="note_type", EmitDefaultValue=false)]
        public int? NoteType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Note {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Editor: ").Append(Editor).Append("\n");
            sb.Append("  History: ").Append(History).Append("\n");
            sb.Append("  Entry: ").Append(Entry).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Private: ").Append(Private).Append("\n");
            sb.Append("  Edited: ").Append(Edited).Append("\n");
            sb.Append("  EditTime: ").Append(EditTime).Append("\n");
            sb.Append("  NoteType: ").Append(NoteType).Append("\n");
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
            return this.Equals(input as Note);
        }

        /// <summary>
        /// Returns true if Note instances are equal
        /// </summary>
        /// <param name="input">Instance of Note to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Note input)
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
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.Editor == input.Editor ||
                    (this.Editor != null &&
                    this.Editor.Equals(input.Editor))
                ) && 
                (
                    this.History == input.History ||
                    this.History != null &&
                    this.History.SequenceEqual(input.History)
                ) && 
                (
                    this.Entry == input.Entry ||
                    (this.Entry != null &&
                    this.Entry.Equals(input.Entry))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Private == input.Private ||
                    (this.Private != null &&
                    this.Private.Equals(input.Private))
                ) && 
                (
                    this.Edited == input.Edited ||
                    (this.Edited != null &&
                    this.Edited.Equals(input.Edited))
                ) && 
                (
                    this.EditTime == input.EditTime ||
                    (this.EditTime != null &&
                    this.EditTime.Equals(input.EditTime))
                ) && 
                (
                    this.NoteType == input.NoteType ||
                    (this.NoteType != null &&
                    this.NoteType.Equals(input.NoteType))
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
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Editor != null)
                    hashCode = hashCode * 59 + this.Editor.GetHashCode();
                if (this.History != null)
                    hashCode = hashCode * 59 + this.History.GetHashCode();
                if (this.Entry != null)
                    hashCode = hashCode * 59 + this.Entry.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Private != null)
                    hashCode = hashCode * 59 + this.Private.GetHashCode();
                if (this.Edited != null)
                    hashCode = hashCode * 59 + this.Edited.GetHashCode();
                if (this.EditTime != null)
                    hashCode = hashCode * 59 + this.EditTime.GetHashCode();
                if (this.NoteType != null)
                    hashCode = hashCode * 59 + this.NoteType.GetHashCode();
                return hashCode;
            }
        }
    }

}
