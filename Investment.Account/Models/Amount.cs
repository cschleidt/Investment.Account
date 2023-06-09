/*
 * Investment Account
 *
 * This service domain handles the non-cash holdings positions for a customer, covering multiple instruments as necessary
 *
 * OpenAPI spec version: 11.0.0
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
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Investment.Account.Models
{ 
    /// <summary>
    /// Tracking of accumulated fees and penalties
    /// </summary>
    [DataContract]
    public partial class Amount : IEquatable<Amount>
    { 
        /// <summary>
        /// Gets or Sets AmountValue
        /// </summary>

        [DataMember(Name="AmountValue")]
        public string? AmountValue { get; set; }

        /// <summary>
        /// Gets or Sets AmountCurrency
        /// </summary>

        [DataMember(Name="AmountCurrency")]
        public Currencycode AmountCurrency { get; set; }

        /// <summary>
        /// Decimal point position starts calulating from the right 
        /// </summary>
        /// <value>Decimal point position starts calulating from the right </value>

        [DataMember(Name="DecimalPointPosition")]
        public string? DecimalPointPosition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Amount {\n");
            sb.Append("  AmountValue: ").Append(AmountValue).Append("\n");
            sb.Append("  AmountCurrency: ").Append(AmountCurrency).Append("\n");
            sb.Append("  DecimalPointPosition: ").Append(DecimalPointPosition).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return "";
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Amount)obj);
        }

        /// <summary>
        /// Returns true if Amount instances are equal
        /// </summary>
        /// <param name="other">Instance of Amount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Amount other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AmountValue == other.AmountValue ||
                    AmountValue != null &&
                    AmountValue.Equals(other.AmountValue)
                ) && 
                (
                    AmountCurrency == other.AmountCurrency || AmountCurrency != null && AmountCurrency.Equals(other.AmountCurrency)
                ) && 
                (
                    DecimalPointPosition == other.DecimalPointPosition ||
                    DecimalPointPosition != null &&
                    DecimalPointPosition.Equals(other.DecimalPointPosition)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (AmountValue != null)
                    hashCode = hashCode * 59 + AmountValue.GetHashCode();
                    if (AmountCurrency != null)
                    hashCode = hashCode * 59 + AmountCurrency.GetHashCode();
                    if (DecimalPointPosition != null)
                    hashCode = hashCode * 59 + DecimalPointPosition.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Amount left, Amount right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Amount left, Amount right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
