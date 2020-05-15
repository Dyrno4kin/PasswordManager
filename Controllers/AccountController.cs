using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class AccountController
    {
        private PIDbContext context;

        private readonly EncryptionController encryptionService;

        public AccountController(PIDbContext context, EncryptionController encryptionService)
        {
            this.context = context;
            this.encryptionService = encryptionService;
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
                    NameAccount = encryptionService.Decrypt(element.NameAccount, "Login"),
                    LoginAccount = encryptionService.Decrypt(element.LoginAccount, "Login"),
                    PasswordAccount = encryptionService.Decrypt(element.PasswordAccount, "Login"),
                    URL = encryptionService.Decrypt(element.URL, "Login"),
                    Comment = encryptionService.Decrypt(element.Comment, "Login"),
                    PasswordGroupId = element.PasswordGroupId
                };
            }
            throw new Exception("Элемент не найден");
        }

        public void AddElement(Account model)
        {
            string nameAccount = encryptionService.Encrypt(model.NameAccount, "Login");
            Account element = context.Accounts.FirstOrDefault(rec => rec.NameAccount == nameAccount);
            if (element != null)
            {
                throw new Exception("Уже есть такая учетная запись");
            }
            element = new Account
            {
                NameAccount = encryptionService.Encrypt(model.NameAccount, "Login"),
                LoginAccount = encryptionService.Encrypt(model.LoginAccount, "Login"),
                PasswordAccount = encryptionService.Encrypt(model.PasswordAccount, "Login"),
                URL = encryptionService.Encrypt(model.URL, "Login"),
                Comment = encryptionService.Encrypt(model.Comment, "Login"),
                PasswordGroupId = model.PasswordGroupId
            };
            context.Accounts.Add(element);
            context.SaveChanges();
        }

        public void UpdElement(Account model)
        {
            string nameAccount = encryptionService.Encrypt(model.NameAccount, "Login");
            Account element = context.Accounts.FirstOrDefault(rec => rec.NameAccount ==
            nameAccount && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть такая учетная запись");
            }
            element = context.Accounts.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.NameAccount = encryptionService.Encrypt(model.NameAccount, "Login");
            element.LoginAccount = encryptionService.Encrypt(model.LoginAccount, "Login");
            element.PasswordAccount = encryptionService.Encrypt(model.PasswordAccount, "Login");
            element.URL = encryptionService.Encrypt(model.URL, "Login");
            element.Comment = encryptionService.Encrypt(model.Comment, "Login");
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
