using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Adapters;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface IUserValidationService 
    {
        bool Validate(User user);

    }
}
