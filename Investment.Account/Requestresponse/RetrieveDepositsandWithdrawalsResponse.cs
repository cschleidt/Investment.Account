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
using Investment.Account.Models;

namespace Investment.Account.Requestresponse
{
    /// <summary>
    /// Output: ReBQ Retrieve details about a securities deposit or withdrawal action
    /// </summary>
    [DataContract]
    public partial class RetrieveDepositsandWithdrawalsResponse : IEquatable<RetrieveDepositsandWithdrawalsResponse>
    {
        /// <summary>
        /// Gets or Sets DepositsandWithdrawals
        /// </summary>

        [DataMember(Name = "DepositsandWithdrawals")]
        public InvestmentAccountEntry DepositsandWithdrawals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrieveDepositsandWithdrawalsResponse {\n");
            sb.Append("  DepositsandWithdrawals: ").Append(DepositsandWithdrawals).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RetrieveDepositsandWithdrawalsResponse)obj);
        }

        /// <summary>
        /// Returns true if RetrieveDepositsandWithdrawalsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RetrieveDepositsandWithdrawalsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrieveDepositsandWithdrawalsResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return

                    DepositsandWithdrawals == other.DepositsandWithdrawals ||
                    DepositsandWithdrawals != null &&
                    DepositsandWithdrawals.Equals(other.DepositsandWithdrawals)
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
                if (DepositsandWithdrawals != null)
                    hashCode = hashCode * 59 + DepositsandWithdrawals.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(RetrieveDepositsandWithdrawalsResponse left, RetrieveDepositsandWithdrawalsResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RetrieveDepositsandWithdrawalsResponse left, RetrieveDepositsandWithdrawalsResponse right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
