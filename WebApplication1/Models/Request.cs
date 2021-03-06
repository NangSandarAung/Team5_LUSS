﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static LUSS_API.Models.RequestType;
using static LUSS_API.Models.Status;

namespace LUSS_API.Models
{
    public class Request
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RequestID   { get; set; }
        [Required]
        public EOrderStatus RequestStatus { get; set; }
        [Required]
        public DateTime RequestDate { get; set; }
       
        [Required]
        public int? RequestBy { get; set; }
      
        public int? ModifiedBy   { get; set; }
        [MaxLength(50)]
        public string Comment   { get; set; }
        [MaxLength(50)]
        public ERequestType RequestType { get; set; }
        public int? ParentRequestID { get; set; }
        public DateTime CollectionTime { get; set; }
        public int? RetrievalID { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual User RequestByUser { get; set; }
        public virtual ICollection<RequestDetails> RequestDetails { get; set; }
        public virtual Retrieval Retrieval { get; set; }
    }
}
