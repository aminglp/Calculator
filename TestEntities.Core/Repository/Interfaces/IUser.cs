using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TestEntities.Core.Repository.Interfaces
{
    public interface IUser
    {
        IEnumerable<User> GetAllUser();

        User GetUserById(int userid);



        void AddUSer(User user);

        void Delete(User user);

        void UpdateUser(User user);

        string GetParentNameByUser(int userID);

        IEnumerable<User> GetUsersByParent(int parentId);
    }
}
