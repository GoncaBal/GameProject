using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class UserValidationManager : MernisServiceAdapter
    {
        public bool Validate(User user)
        {
            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
