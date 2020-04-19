using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class AccountController
    {
        private PIDbContext context;

        public AccountController(PIDbContext context)
        {
            this.context = context;
        }

        public List<Account> GetListAccount(int GroupId)
        {
            var dt = context.Database.SqlQuery<Account>("select Id, NameAccount, URL, LoginAccount, PasswordAccount, Comment, PasswordGroupId from Accounts where PasswordGroupId =" + GroupId);
            List<Account> result = dt.ToList();
            return result;
        }

        public Account GetElement(int id)
        {
            Account element = context.Accounts.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new Account
                {
                    Id = element.Id,
                    NameAccount = element.NameAccount,
                    LoginAccount = element.LoginAccount,
                    PasswordAccount = element.PasswordAccount,
                    URL = element.URL,
                    Comment = element.Comment,
                    PasswordGroupId = element.PasswordGroupId
                };
            }
            throw new Exception("Элемент не найден");
        }

        public void AddElement(Account model)
        {
            Account element = context.Accounts.FirstOrDefault(rec => rec.NameAccount == model.NameAccount);
            if (element != null)
            {
                throw new Exception("Уже есть такая учетная запись");
            }
            element = new Account
            {
                NameAccount = model.NameAccount,
                LoginAccount = model.LoginAccount,
                PasswordAccount = model.PasswordAccount,
                URL = model.URL,
                Comment = model.Comment,
                PasswordGroupId = model.PasswordGroupId
            };
            context.Accounts.Add(element);
            context.SaveChanges();
        }

        public void UpdElement(Account model)
        {
            Account element = context.Accounts.FirstOrDefault(rec => rec.NameAccount ==
          model.NameAccount && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть такая учетная запись");
            }
            element = context.Accounts.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.NameAccount = model.NameAccount;
            element.LoginAccount = model.LoginAccount;
            element.PasswordAccount = model.PasswordAccount;
            element.URL = model.URL;
            element.Comment = model.Comment;
            element.PasswordGroupId = model.PasswordGroupId;
            context.SaveChanges();
        }

        public void DelElement(int id)
        {
            Account element = context.Accounts.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Accounts.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}
