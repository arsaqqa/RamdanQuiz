using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace RamadanQuiz.RamadanQuiz.Business
{


        public class ApplicationUser : IdentityUser
        {
            [StringLength(10)]
            public string EmployeeNo { get; set; }

            [StringLength(300)]
            public string FullName { get; set; }

            public int RelatedEntityID { get; set; }

        }
    }
