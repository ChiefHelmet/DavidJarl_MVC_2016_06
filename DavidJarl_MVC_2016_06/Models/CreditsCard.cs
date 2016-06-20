using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity.Migrations.Model;
using System.Runtime.CompilerServices;
using System.Web.Mvc;

namespace DavidJarl_MVC_2016_06.Models
{
    public class CreditsCard
    {

        [Required]
        [KeyAttribute]
        public int CreditCardId { get; set; }

        [Required]
        [MaxLength(32)]
        public string Name { get; set; }

        [Required]
        public int CardNumber { get; set; }

        [Required]
        public DateTime ExpireDate { get; set; }

        [MaxLength(3)]
        public string CsvNumber { get; set; }

        [CreditLimitValidator]
        public decimal CreditLimit { get; set; }

        [Range(0, 100000)]
        public decimal Balance { get; set; }

        
    }
}