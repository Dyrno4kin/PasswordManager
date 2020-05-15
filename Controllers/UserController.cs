using Models;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Mail;

namespace Controllers
{
    public class UserController
    {
        private PIDbContext context;

        private readonly EncryptionController encryptionService;

        private readonly SendEmailController sendEmailController;

        private readonly PasswordGeneratorController passwordGeneratorController;

        public UserController(PIDbContext context, SendEmailController sendEmailController, PasswordGeneratorController passwordGeneratorController, EncryptionController encryptionService)
        {
            this.context = context;
            this.sendEmailController = sendEmailController;
            this.passwordGeneratorController = passwordGeneratorController;
            this.encryptionService = encryptionService;
        }

        public User GetElement(int id)
        {
            User element = context.Users.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new User
                {
                    Id = element.Id,
                    FIO = encryptionService.Decrypt(element.FIO, "Login"),
                    Login = encryptionService.Decrypt(element.Login, "Login"),
                    Password = encryptionService.Decrypt(element.Password, "Login"),
                    Email = encryptionService.Decrypt(element.Email, "Login"),
                    Authentication = element.Authentication
                };
            }
            throw new Exception("Элемент не найден");
        }

        public User GetElement(string login, string password)
        {
            string pass = encryptionService.Encrypt(password, "Login");
            string log = encryptionService.Encrypt(login, "Login");
            User element = context.Users.FirstOrDefault(rec => rec.Login == log && rec.Password == pass);
            if (element != null)
            {
                return new User
                {
                    Id =  element.Id,
                    FIO = encryptionService.Decrypt(element.FIO, "Login"),
                    Login = encryptionService.Decrypt(element.Login, "Login"),
                    Password = encryptionService.Decrypt(element.Password, "Login"),
                    Email = encryptionService.Decrypt(element.Email, "Login"),
                    Authentication = element.Authentication,
                    Status = element.Status
                };
            }
            throw new Exception("Неверный логин или пароль");
        }

        public void AddElement(User model)
        {
            string firstName = encryptionService.Encrypt(model.FIO, "Login");
            string login = encryptionService.Encrypt(model.Login, "Login");
            User element = context.Users.FirstOrDefault(rec => rec.FIO == firstName || rec.Login == login);
            if (element != null)
            {
                throw new Exception("Уже есть пользователь с таким ФИО или логином");
            }
            element = new User
            {
                FIO = encryptionService.Encrypt(model.FIO, "Login"),
                Login = encryptionService.Encrypt(model.Login, "Login"),
                Password = encryptionService.Encrypt(model.Password, "Login"),
                Email = encryptionService.Encrypt(model.Email, "Login"),
                Status = model.Status,
                Authentication = true
            };
            context.Users.Add(element);
            context.SaveChanges();
        }

        public void UpdElement(User model)
        {
            string firstName = encryptionService.Encrypt(model.FIO, "Login");
            string login = encryptionService.Encrypt(model.Login, "Login");
            User element = context.Users.FirstOrDefault(rec => (rec.FIO == firstName || rec.Login == login) && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть пользователь с таким логином или ФИО");
            }
            element = context.Users.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.FIO = encryptionService.Encrypt(model.FIO, "Login");
            element.Login = encryptionService.Encrypt(model.Login, "Login");
            element.Password = encryptionService.Encrypt(model.Password, "Login");
            element.Email = encryptionService.Encrypt(model.Email, "Login");
            element.Authentication = model.Authentication;
            context.SaveChanges();
        }

        public void ActivateAccount(User model)
        {
            User element = context.Users.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.Status = model.Status;
            context.SaveChanges();
        }

        public void ResetPassword(string login, string email)
        {
            Random rand = new Random();
            string log = encryptionService.Decrypt(login, "Login");
            string mail = encryptionService.Decrypt(email, "Login");
            string pass = passwordGeneratorController.generatePassword(true, true, true, false, rand.Next(8, 25));
            User element = context.Users.FirstOrDefault(rec => rec.Login == log && rec.Email == mail);
            if (element != null)
            {
                sendEmailController.SendEmail(element.Email, "Восстановление пароля", "Ваш новый пароль: " + pass);
                element.Password = encryptionService.Encrypt(pass, "Login");
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Неверный логин или почта");
            }
        }
    }
}
