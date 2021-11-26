using System;

using EAISolutionFrontEnd.SharedKernel;
using EAISolutionFrontEnd.SharedKernel.Interfaces;

namespace EAISolutionFrontEnd.Core.Entities
{
    public class RequestItem : BaseEntity
    {


        public string Description { get; set; } = string.Empty;
        public int Quantiy { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice() { return UnitPrice * Quantiy; }

        /// <summary>
        /// Exigé par EF
        /// </summary>
        public RequestItem()
        {
        }

        public RequestItem(string description, int quantiy, decimal unitPrice)
        {
            Description = description;
            Quantiy = quantiy;
            UnitPrice = unitPrice;
        }
    }
}
