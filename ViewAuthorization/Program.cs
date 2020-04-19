using Controllers;
using Models;
using System;
using System.Data.Entity;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace ViewAuthorization
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormLogin>());
        }

        public static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<DbContext, PIDbContext>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<PasswordGeneratorController>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<UserController>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<SendEmailController>(new
           HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
