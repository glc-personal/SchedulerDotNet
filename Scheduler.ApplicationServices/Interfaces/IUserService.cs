using System.Collections.Generic;
using Scheduler.Core.Models;

namespace Scheduler.ApplicationServices.Interfaces
{
    public interface IUserService
    {
        List<User> GetAllUsers(); 
    }
}
