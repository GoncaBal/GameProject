using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
   public class UserManager : IUserService
    {
        IUserValidationService _userValidationService;

        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(User user)
        {
            if (_userValidationService.Validate(user)==true)
            {
                Console.WriteLine("Kullanıcı hesabı oluşturuldu.");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız. Geçersiz kullanıcı.");
            }
         
        }

        public void Delete(User user)
        {
            Console.WriteLine("Kullanıcı hesabı silindi.");
        }

        public void Update(User user)
        {
            Console.WriteLine("Kullanıcı hesabı güncellendi");
        }
    }
}
