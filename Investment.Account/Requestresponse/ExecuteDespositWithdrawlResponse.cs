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
    /// Input: InCR Initiate a new securities investment account
    /// </summary>
    [DataContract]
    public partial class ExecuteDespositWithdrawlResponse : IEquatable<ExecuteDespositWithdrawlResponse>
    {
        /// <summary>
        /// Unique entry id for investment transation
        /// </summary>
        /// <value>Unique entry id for investment transation</value>
        [DataMember(Name = "InvestmentEntryId")]
        public string InvestmentEntryId { get; set; }

        /// <summary>
        /// The investment account number in any suitable format
        /// </summary>
        /// <value>The investment account number in any suitable format</value>
        [DataMember(Name = "InvestmentAccountNumber")]
        public string InvestmentAccountNumber { get; set; }

        /// <summary>
        /// Reference to the account primary party/owner
        /// </summary>
        /// <value>Reference to the account primary party/owner</value>

        [DataMember(Name = "CustomerReference")]
        public string CustomerReference { get; set; }


        /// <summary>
        /// Reference to the type of investment instrument being tracked (e.g. equity, commodity, FX/MM, derivative)
        /// </summary>
        /// <value>Reference to the type of investment instrument being tracked (e.g. equity, commodity, FX/MM, derivative)</value>

        [DataMember(Name = "InstrumentType")]
        public string InstrumentType { get; set; }

        /// <summary>
        /// The specific instrument trading identifier (e.g. NASDAQ Id)
        /// </summary>
        /// <value>The specific instrument trading identifier (e.g. NASDAQ Id)</value>

        [DataMember(Name = "InstrumentReference")]
        public string InstrumentReference { get; set; }


        /// <summary>
        /// Quantity traded
        /// </summary>
        /// <value>Quantity traded</value>

        [DataMember(Name = "Quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Price pr share traded
        /// </summary>
        /// <value>Price pr share traded</value>

        [DataMember(Name = "PricePrShare")]
        public double PricePrShare { get; set; }


        /// <summary>
        /// Traded data
        /// </summary>
        /// <value>Traded data</value>

        [DataMember(Name = "TradingDate")]
        public DateTime TradingDate { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteDespositWithdrawlResponse {\n");
            sb.Append("  InvestmentEntryId: ").Append(InvestmentEntryId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InitiateInvestmentAccountFacilityRequest)obj);
        }

        /// <summary>
        /// Returns true if InitiateInvestmentAccountFacilityRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of InitiateInvestmentAccountFacilityRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExecuteDespositWithdrawlResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    InvestmentEntryId == other.InvestmentEntryId ||
                    InvestmentEntryId != null &&
                    InvestmentEntryId.Equals(other.InvestmentEntryId)
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
                    if (InvestmentEntryId != null)
                    hashCode = hashCode * 59 + InvestmentEntryId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ExecuteDespositWithdrawlResponse left, ExecuteDespositWithdrawlResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ExecuteDespositWithdrawlResponse left, ExecuteDespositWithdrawlResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
