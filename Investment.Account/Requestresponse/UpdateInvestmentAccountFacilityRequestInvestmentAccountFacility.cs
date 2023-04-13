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
using Newtonsoft.Json;

namespace Investment.Account.Requestresponse
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class UpdateInvestmentAccountFacilityRequestInvestmentAccountFacility : IEquatable<UpdateInvestmentAccountFacilityRequestInvestmentAccountFacility>
    {
        /// <summary>
        ///  
        /// </summary>
        /// <value> </value>

        [DataMember(Name = "ProductInstanceReference")]
        public string? ProductInstanceReference { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <value> </value>

        [DataMember(Name = "InvestmentAccountNumber")]
        public string? InvestmentAccountNumber { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <value> </value>

        [DataMember(Name = "CustomerReference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <value> </value>

        [DataMember(Name = "InvestmentAccountType")]
        public string? InvestmentAccountType { get; set; }


        /// <summary>
        ///  
        /// </summary>
        /// <value> </value>

        [DataMember(Name = "InstrumentPositionHolding")]
        public string? InstrumentPositionHolding { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <value> </value>

        [DataMember(Name = "DateType")]
        public string? DateType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInvestmentAccountFacilityRequestInvestmentAccountFacility {\n");
            sb.Append("  ProductInstanceReference: ").Append(ProductInstanceReference).Append("\n");
            sb.Append("  InvestmentAccountNumber: ").Append(InvestmentAccountNumber).Append("\n");
            sb.Append("  CustomerReference: ").Append(CustomerReference).Append("\n");
            sb.Append("  InvestmentAccountType: ").Append(InvestmentAccountType).Append("\n");
            sb.Append("  InstrumentPositionHolding: ").Append(InstrumentPositionHolding).Append("\n");
            sb.Append("  DateType: ").Append(DateType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
            return obj.GetType() == GetType() && Equals((UpdateInvestmentAccountFacilityRequestInvestmentAccountFacility)obj);
        }

        /// <summary>
        /// Returns true if UpdateInvestmentAccountFacilityRequestInvestmentAccountFacility instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateInvestmentAccountFacilityRequestInvestmentAccountFacility to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateInvestmentAccountFacilityRequestInvestmentAccountFacility other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    ProductInstanceReference == other.ProductInstanceReference ||
                    ProductInstanceReference != null &&
                    ProductInstanceReference.Equals(other.ProductInstanceReference)
                ) &&
                (
                    InvestmentAccountNumber == other.InvestmentAccountNumber ||
                    InvestmentAccountNumber != null &&
                    InvestmentAccountNumber.Equals(other.InvestmentAccountNumber)
                ) &&
                (
                    CustomerReference == other.CustomerReference ||
                    CustomerReference != null &&
                    CustomerReference.Equals(other.CustomerReference)
                ) &&
                (
                    InvestmentAccountType == other.InvestmentAccountType ||
                    InvestmentAccountType != null &&
                    InvestmentAccountType.Equals(other.InvestmentAccountType)
                ) &&
                (
                    InstrumentPositionHolding == other.InstrumentPositionHolding ||
                    InstrumentPositionHolding != null &&
                    InstrumentPositionHolding.Equals(other.InstrumentPositionHolding)
                ) &&
                (
                    DateType == other.DateType ||
                    DateType != null &&
                    DateType.Equals(other.DateType)
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
                if (ProductInstanceReference != null)
                    hashCode = hashCode * 59 + ProductInstanceReference.GetHashCode();
                if (InvestmentAccountNumber != null)
                    hashCode = hashCode * 59 + InvestmentAccountNumber.GetHashCode();
                if (CustomerReference != null)
                    hashCode = hashCode * 59 + CustomerReference.GetHashCode();
                if (InvestmentAccountType != null)
                    hashCode = hashCode * 59 + InvestmentAccountType.GetHashCode();
                if (InstrumentPositionHolding != null)
                    hashCode = hashCode * 59 + InstrumentPositionHolding.GetHashCode();
                if (DateType != null)
                    hashCode = hashCode * 59 + DateType.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(UpdateInvestmentAccountFacilityRequestInvestmentAccountFacility left, UpdateInvestmentAccountFacilityRequestInvestmentAccountFacility right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UpdateInvestmentAccountFacilityRequestInvestmentAccountFacility left, UpdateInvestmentAccountFacilityRequestInvestmentAccountFacility right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
