using DataLayer.Context;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEntities.Core.Repository.Interfaces;
using System.Data.Entity;

namespace TestEntities.Core.Repository.Services
{
    public class UserService : IUser
    {

       private DataBaseContext _context=new DataBaseContext();

        public IEnumerable<User> GetAllUser()
        {
           return _context.Users.ToList();
        }   
        

        public User GetUserById(int userid)
        {
            return _context.Users.SingleOrDefault(p=>p.UserId == userid);
        }
        

        public void AddUSer(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }


        public void Delete(User user)
        {
            _context.Entry(user).State = EntityState.Deleted;
            _context.SaveChanges();
        }


        public void UpdateUser(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public string GetParentNameByUser(int userId)
        {
            User user = GetUserById(userId);
            return user.Parent.Name;
        }

        public IEnumerable<User> GetUsersByParent(int parentId)
        {
            Parent parent= _context.Parents.SingleOrDefault(p.ParentId == parentId);
            return parent.Users;
        }
    }
}
