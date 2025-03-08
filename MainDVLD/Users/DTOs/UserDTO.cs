using MainDVLD.People.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDVLD.Users.DTOs
{
    public class UsersDTO
    {
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public UsersDTO()
        {

        }
        public UsersDTO(int userId, int PersonId, string userName, string password, bool isActive)
        {
            this.UserID = userId;
            this.PersonID = PersonId;
            this.UserName = userName;
            this.Password = password;
            this.IsActive = isActive;

        }

    }

    public class AllUsersInfoDTO
    {
        public UsersDTO UsersDTOInfo =new UsersDTO();
        public PersonsDTO PersonUserInfo =new PersonsDTO();

      
        public AllUsersInfoDTO(UsersDTO usersDTO,PersonsDTO personsDTO)
        {
            //this.UsersDTOInfo = usersDTO;
            this.UsersDTOInfo.UserID = usersDTO.UserID;
            this.UsersDTOInfo.PersonID = usersDTO.PersonID;
            this.UsersDTOInfo.UserName = usersDTO.UserName;
            this.UsersDTOInfo.Password = usersDTO.Password;
            this.UsersDTOInfo.IsActive = usersDTO.IsActive;


            //this.PersonUserInfo = personsDTO;
            this.PersonUserInfo.PersonID = personsDTO.PersonID;
            this.PersonUserInfo.NationalNo = personsDTO.NationalNo;
            this.PersonUserInfo.FirstName = personsDTO.FirstName;
            this.PersonUserInfo.SecondName = personsDTO.SecondName;
            this.PersonUserInfo.ThirdName = personsDTO.ThirdName;
            this.PersonUserInfo.LastName = personsDTO.LastName;
            this.PersonUserInfo.Gendor = personsDTO.Gendor;
            this.PersonUserInfo.Address = personsDTO.Address;
            this.PersonUserInfo.Email = personsDTO.Email;
            this.PersonUserInfo.Phone = personsDTO.Phone;
            this.PersonUserInfo.ImagePath = personsDTO.ImagePath;
            this.PersonUserInfo.DateOfBirth = personsDTO.DateOfBirth;
            this.PersonUserInfo.NationalityCountryID = personsDTO.NationalityCountryID;





        }

    }


}
