using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class UserDAO : PostContext
    {
       public UserDTO GetUserWithUsernameAndPassword(UserDTO userModel)
        {
            UserDTO dto = new UserDTO();
            T_User user = db.T_User.FirstOrDefault(x => x.Username == userModel.Username && x.Password == userModel.Password);
            if(user!=null && user.ID!=0)
            {
                dto.ID = user.ID;
                dto.Username = user.Username;
                dto.Name = user.NameSurname;
                dto.ImagePath = user.ImagePath;
                dto.isAdmin = user.isAdmin;
            }

            return dto;
        }
    }
}
