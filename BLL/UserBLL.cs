using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL
    {
        UserDAO userDAO = new UserDAO();

        public UserDTO GetUserWithUsernameAndPassword(UserDTO userModel)
        {
            UserDTO userDTO = new UserDTO();
            userDTO = userDAO.GetUserWithUsernameAndPassword(userModel);

            return userDTO;
        }
    }
}
