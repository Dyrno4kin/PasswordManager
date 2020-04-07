using Models;
using System;
using System.Linq;

namespace Controllers
{
    public class UserController
    {
        private PIDbContext context;
        // private readonly EncryptionController encryptionService;
        private readonly SendEmailController sendEmailController;
        private readonly PasswordGeneratorController passwordGeneratorController;

        public UserController(PIDbContext context, SendEmailController sendEmailController, PasswordGeneratorController passwordGeneratorController /*, EncryptionController encryptionService*/)
        {
            this.context = context;
            this.sendEmailController = sendEmailController;
            this.passwordGeneratorController = passwordGeneratorController;
          //  this.encryptionService = encryptionService;
        }

        /*public List<User> GetList()
        {
            List<User> result = context.Users.Select(rec => new User
            {
                Id = rec.Id,
                FIO = rec.FIO,
                Login = rec.Login,
                Password = rec.Password,
                Email = rec.Email,
                Status = rec.Status
            })
            .ToList();
            return result;
        } */
       /* public User GetElement(int id)
        {
            User element = context.Users.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new User
                {
                    Id = element.Id,
                    FIO = element.FIO,
                    Login = element.Login,
                    Password = element.Password,
                    Email = element.Email,
                    Status = element.Status,
                    PasswordGroups = context.PasswordGroups
                 .Where(recPG => recPG.UserId == element.Id)
                 .Select(recPG => new PasswordGroup
                 {
                     Id = recPG.Id,
                     GroupName = recPG.GroupName
                 })
                 .ToList(),
                };
            }
            throw new Exception("Элемент не найден");
        } */

        public User GetElement(string login, string password)
        {
           // string pass = encryptionService.Encrypt("Login", password);
            User element = context.Users.FirstOrDefault(rec => rec.Login == login && rec.Password == password);
            if (element != null)
            {
                return new User
                {
                    Id = element.Id,
                    FIO = element.FIO,
                    Login = element.Login,
                    Password = element.Password,
                    Email = element.Email,
                    Status = element.Status
                };
            }
            throw new Exception("Неверный логин или пароль");
        }

        //Сделать шифрование всех элементов при записи в бд
        public void AddElement(User model)
        {
            User element = context.Users.FirstOrDefault(rec => rec.FIO == model.FIO || rec.Login == model.Login);
            if (element != null)
            {
                throw new Exception("Уже есть пользователь с таким ФИО или логином");
            }
            element = new User
            {
                FIO = model.FIO,
                Login = model.Login,
                Password = model.Password,
                Email = model.Email,
                Status = model.Status
            };
            context.Users.Add(element);
            context.SaveChanges();
        }

        public void UpdElement(User model)
        {
            User element = context.Users.FirstOrDefault(rec => rec.FIO == model.FIO || rec.Login == model.Login && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть пользователь с таким логином или ФИО");
            }
            element = context.Users.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.FIO = model.FIO;
            element.Login = model.Login;
            element.Password = model.Password;
            element.Email = model.Email;
            element.Status = model.Status;
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
            string pass = passwordGeneratorController.generatePassword(true, true, true, false, rand.Next(8, 25));
            User element = context.Users.FirstOrDefault(rec => rec.Login == login && rec.Email == email);
            if (element != null)
            {
                sendEmailController.SendEmail(element.Email, "Восстановление пароля", "Ваш новый пароль: " + pass);
                element.Password = pass;
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Неверный логин или почта");
            }
        }
    }
}
