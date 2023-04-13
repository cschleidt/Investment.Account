using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Investment.Account.Models
{
    /// <summary>
    /// Fulfill any scheduled and ad-hoc obligations under a service arrangement, most typically for a financial product or facility within Investment Account. 
    /// </summary>
    [Table("InvestmentaccountEntry")]
    [DataContract]
    public partial class InvestmentAccountEntry : IEquatable<InvestmentAccountEntry>
    {

        /// <summary>
        /// Unique entry id for investment transation
        /// </summary>
        /// <value>Unique entry id for investment transation</value>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        /// Value of the date type
        /// </summary>
        /// <value>Value of the date type</value>

        [DataMember(Name = "TradingDate")]
        public DateTime TradingDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvestmentAccountFacility {\n");
            sb.Append("  InvestmentAccountNumber: ").Append(InvestmentAccountNumber).Append("\n");
            sb.Append("  CustomerReference: ").Append(CustomerReference).Append("\n");
            sb.Append("  InstrumentType: ").Append(InstrumentType).Append("\n");
            sb.Append("  InstrumentReference: ").Append(InstrumentReference).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  PricePrShare: ").Append(PricePrShare).Append("\n");
            sb.Append("  TradingDate: ").Append(TradingDate).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InvestmentAccountEntry)obj);
        }

        /// <summary>
        /// Returns true if InvestmentAccountFacility instances are equal
        /// </summary>
        /// <param name="other">Instance of InvestmentAccountFacility to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvestmentAccountEntry other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
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
                    InstrumentType == other.InstrumentType ||
                    InstrumentType != null &&
                    InstrumentType.Equals(other.InstrumentType)
                ) &&
                (
                    InstrumentReference == other.InstrumentReference ||
                    InstrumentReference != null &&
                    InstrumentReference.Equals(other.InstrumentReference)
                ) &&
                (
                    Quantity == other.Quantity ||
                    Quantity.Equals(other.Quantity)
                ) &&
                (
                    PricePrShare == other.PricePrShare ||
                    PricePrShare.Equals(other.PricePrShare)
                ) &&
                (
                    TradingDate == other.TradingDate ||
                    TradingDate.Equals(other.TradingDate)
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
                if (InvestmentAccountNumber != null)
                    hashCode = hashCode * 59 + InvestmentAccountNumber.GetHashCode();
                if (CustomerReference != null)
                    hashCode = hashCode * 59 + CustomerReference.GetHashCode();
                if (InstrumentType != null)
                    hashCode = hashCode * 59 + InstrumentType.GetHashCode();
                if (InstrumentReference != null)
                    hashCode = hashCode * 59 + InstrumentReference.GetHashCode();
                if (Quantity.ToString() != null)
                    hashCode = hashCode * 59 + Quantity.GetHashCode();
                if (PricePrShare.ToString() != null)
                    hashCode = hashCode * 59 + PricePrShare.GetHashCode();
                if (TradingDate.ToString() != null)
                    hashCode = hashCode * 59 + TradingDate.GetHashCode();
                return hashCode;
            }
        }


        #region Operators
#pragma warning disable 1591

        public static bool operator ==(InvestmentAccountEntry left, InvestmentAccountEntry right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InvestmentAccountEntry left, InvestmentAccountEntry right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
