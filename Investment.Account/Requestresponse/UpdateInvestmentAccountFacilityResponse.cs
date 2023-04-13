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
    /// Output: UpCR Update details of an investment account
    /// </summary>
    [DataContract]
    public partial class UpdateInvestmentAccountFacilityResponse : IEquatable<UpdateInvestmentAccountFacilityResponse>
    {
        /// <summary>
        /// Gets or Sets InvestmentAccountFacility
        /// </summary>

        [DataMember(Name = "InvestmentAccountFacility")]
        public UpdateInvestmentAccountFacilityRequestInvestmentAccountFacility? InvestmentAccountFacility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInvestmentAccountFacilityResponse {\n");
            sb.Append("  InvestmentAccountFacility: ").Append(InvestmentAccountFacility).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UpdateInvestmentAccountFacilityResponse)obj);
        }

        /// <summary>
        /// Returns true if UpdateInvestmentAccountFacilityResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateInvestmentAccountFacilityResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateInvestmentAccountFacilityResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                
                    InvestmentAccountFacility == other.InvestmentAccountFacility ||
                    InvestmentAccountFacility != null &&
                    InvestmentAccountFacility.Equals(other.InvestmentAccountFacility)
                ;
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
                if (InvestmentAccountFacility != null)
                    hashCode = hashCode * 59 + InvestmentAccountFacility.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(UpdateInvestmentAccountFacilityResponse left, UpdateInvestmentAccountFacilityResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UpdateInvestmentAccountFacilityResponse left, UpdateInvestmentAccountFacilityResponse right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
