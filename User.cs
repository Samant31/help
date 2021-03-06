// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ForumWebsite.Models
{
    public partial class User
    {
        [Key]
        [Column("emp_id")]
        public int EmpId { get; set; }
        [Column("emp_name")]
        [StringLength(50)]
        [Unicode(false)]
        public string EmpName { get; set; }
        [Column("emp_no")]
        [StringLength(50)]
        [Unicode(false)]
        public string EmpNo { get; set; }
        [Column("email")]
        [StringLength(50)]
        [Unicode(false)]
        public string Email { get; set; }
        [Column("password")]
        [StringLength(50)]
        [Unicode(false)]
        public string Password { get; set; }
        [Column("created_at", TypeName = "date")]
        public DateTime? CreatedAt { get; set; }
    }
}