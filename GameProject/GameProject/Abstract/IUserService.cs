using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
   public interface IUserService
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);

    }
}
