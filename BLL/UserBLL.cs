using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL
    {
        UserDAO userDao = new UserDAO();

        public UserDTO GetUserWithUsernameAndPassword(UserDTO model)
        {
            UserDTO userDto = userDao.GetUserWithUsernameAndPassword(model);
            return userDto;
        }
    }
}
