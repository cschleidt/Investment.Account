using System.Text;
using System.Runtime.Serialization;

namespace Investment.Account.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Currencycode : IEquatable<Currencycode>
    { 
        /// <summary>
        /// A code identifying a currency according to ISO-4217. A currency is a system of money in general use in a particular country.  Code allocated to a currency, by a maintenance agency, under an international identification scheme as described in the latest edition of the international standard ISO 4217 \&quot;Codes for the representation of currencies and funds\&quot;. Valid currency codes are registered with the ISO 4217 Maintenance Agency, and consist of three contiguous letters. (ISO20022)  
        /// </summary>
        /// <value>A code identifying a currency according to ISO-4217. A currency is a system of money in general use in a particular country.  Code allocated to a currency, by a maintenance agency, under an international identification scheme as described in the latest edition of the international standard ISO 4217 \&quot;Codes for the representation of currencies and funds\&quot;. Valid currency codes are registered with the ISO 4217 Maintenance Agency, and consist of three contiguous letters. (ISO20022)  </value>

        [DataMember(Name="Currencycode")]
        public string? _Currencycode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Currencycode {\n");
            sb.Append("  _Currencycode: ").Append(_Currencycode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Currencycode)obj);
        }

        /// <summary>
        /// Returns true if Currencycode instances are equal
        /// </summary>
        /// <param name="other">Instance of Currencycode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Currencycode other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    _Currencycode == other._Currencycode ||
                    _Currencycode != null &&
                    _Currencycode.Equals(other._Currencycode)
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
                    if (_Currencycode != null)
                    hashCode = hashCode * 59 + _Currencycode.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Currencycode left, Currencycode right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Currencycode left, Currencycode right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
