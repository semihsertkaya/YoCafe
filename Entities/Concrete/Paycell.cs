using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Paycell : IEntity
    {
        [Key]
        public string paymentType { get; set; }
        public string transactionType { get; set; }
        public int merchantCode { get; set; }
        public decimal amount { get; set; }
        public int installmentCount { get; set; }
        public string is3dsRequest { get; set; }
        public int qrToken { get; set; }
        public string transactionId { get; set; }
        public string transactionDateTime { get; set; }
        public string clientIPAddress { get; set; }
        public string applicationName { get; set; }
        public string applicationPwd { get; set; }
    }
}
