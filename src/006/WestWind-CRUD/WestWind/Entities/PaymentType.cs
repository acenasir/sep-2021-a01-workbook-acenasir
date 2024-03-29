﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WestWind.Entities
{
    public partial class PaymentType
    {
        public PaymentType()
        {
            Payments = new HashSet<Payment>();
        }

        [Key]
        [Column("PaymentTypeID")]
        public byte PaymentTypeId { get; set; }
        [Required]
        [StringLength(40)]
        public string PaymentTypeDescription { get; set; }

        [InverseProperty(nameof(Payment.PaymentType))]
        public virtual ICollection<Payment> Payments { get; set; }
    }
}