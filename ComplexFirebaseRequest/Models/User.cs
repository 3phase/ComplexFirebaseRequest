using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexFirebaseRequest.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Uid { get; set; }
        public int Domain { get; set; }
        // roles are going to be 0 - admin, 1 - user, 2 - limited
        public int Role { get; set; }
    }
}
