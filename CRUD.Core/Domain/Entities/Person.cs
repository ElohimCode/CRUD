using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Core.Domain.Entities
{
    public class Person
    {
        [Key]
        public Guid PersonID { get; set; }

        [StringLength(32)] 
        public string? PersonName { get; set; }

        [StringLength(32)] 
        public string? Email { get; set; }
        public DateTime? DateOfBirth { get; set; }

        [StringLength(8)]
        public string? Gender { get; set; }

        //uniqueidentifier
        public Guid? CountryID { get; set; }

        [StringLength(128)] 
        public string? Address { get; set; }

        //bit
        public bool ReceiveNewsLetters { get; set; }


        [ForeignKey("CountryID")]
        public virtual Country? Country { get; set; }

        public override string ToString()
        {
            return $"Person ID: {PersonID}, Person Name: {PersonName}, Email: {Email}, Date of Birth: {DateOfBirth?.ToString("MM/dd/yyyy")}, Gender: {Gender}, Country ID: {CountryID}, Country: {Country?.CountryName}, Address: {Address}, Receive News Letters: {ReceiveNewsLetters}";
        }
    }
}
