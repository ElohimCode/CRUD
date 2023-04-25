using CRUD.Core.Domain.Entities;
using CRUD.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace CRUD.Core.DTO.Persons
{
    public class PersonUpdateRequest
    {
        [Required(ErrorMessage = "Person ID can't be empty")]
        public Guid PersonID { get; set; }

        [Required(ErrorMessage = "Person Name can't be empty")]
        public string? PersonName { get; set; }

        [Required(ErrorMessage = "Email can't be empty")]
        [EmailAddress(ErrorMessage = "Email value should be a valid email")]
        public string? Email { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public GenderOptions? Gender { get; set; }
        public Guid? CountryID { get; set; }
        public string? Address { get; set; }
        public bool ReceiveNewsLetters { get; set; }

        /// <summary>
        /// Converts the current object of PersonAddRequest into a new object of Person type
        /// </summary>
        /// <returns>Returns Person object</returns>
        public Person ToPerson()
        {
            return new Person() { PersonID = PersonID, PersonName = PersonName, Email = Email, DateOfBirth = DateOfBirth, Gender = Gender.ToString(), Address = Address, CountryID = CountryID, ReceiveNewsLetters = ReceiveNewsLetters };
        }
    }
}
