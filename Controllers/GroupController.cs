using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Controllers
{
    public class GroupController
    {
        private PIDbContext context;

        public GroupController(PIDbContext context)
        {
            this.context = context;
        }

        /* public List<PasswordGroup> GetListGroup(int UserId)
         {
             List<PasswordGroup> result = context.PasswordGroups.Where(rec => rec.UserId == UserId).Select(rec => new PasswordGroup
             {
                 Id = rec.Id,
                 UserId = rec.UserId,
                 GroupName = rec.GroupName
             })
             .ToList();
             return result;
         }*/

       /* public List<PasswordGroup> GetListCustomer(int UserId)
        {
            List<PasswordGroup> result = context.PasswordGroups.Where(rec => rec.UserId == UserId).Select(rec => new PasswordGroup
            {
                Id = rec.Id,
                GroupName = rec.GroupName
            })
            .ToList();
            return result;
        } */


        public List<PasswordGroup> GetListGroup(int UserId)
        {
            var dt = context.Database.SqlQuery<PasswordGroup>("select Id, UserId, GroupName from PasswordGroups where UserId =" + UserId);
            List<PasswordGroup> result = dt.ToList();
            return result;
        }

        public PasswordGroup GetElement(int id)
        {
            PasswordGroup element = context.PasswordGroups.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new PasswordGroup
                {
                    Id = element.Id,
                    UserId = element.Id,
                    GroupName = element.GroupName
                };
            }
            throw new Exception("Элемент не найден");
        }

        public void AddElement(PasswordGroup model)
        {
            PasswordGroup element = context.PasswordGroups.FirstOrDefault(rec => rec.GroupName == model.GroupName);
            if (element != null)
            {
                throw new Exception("Уже есть такая группа");
            }
            element = new PasswordGroup
            {
                UserId = model.UserId,
                GroupName = model.GroupName
            };
            context.PasswordGroups.Add(element);
            context.SaveChanges();
        }

        public void UpdElement(PasswordGroup model)
        {
            PasswordGroup element = context.PasswordGroups.FirstOrDefault(rec => rec.GroupName ==
          model.GroupName && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть такая группа");
            }
            element = context.PasswordGroups.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.GroupName = model.GroupName;
            element.UserId = model.UserId;
            context.SaveChanges();
        }

        public void DelElement(int id)
        {
            PasswordGroup element = context.PasswordGroups.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.PasswordGroups.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

    }
}
