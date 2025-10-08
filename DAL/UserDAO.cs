using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAO : PostContext
    {
        public UserDTO GetUserWithUsernameAndPassword(UserDTO model)
        {
            UserDTO userDto = new UserDTO();

            T_User userEntity = db.T_User.FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password);    

            if(userEntity != null && userEntity.ID != 0)
            {
                userDto.ID = userEntity.ID;
                userDto.Username = userEntity.Username;
                userDto.Password = userEntity.Password;
                userDto.Name = userEntity.NameSurname;
                userDto.ImagePath = userEntity.ImagePath;
                userDto.isAdmin = userEntity.isAdmin;
            }
            return userDto;
        }
    }
}
