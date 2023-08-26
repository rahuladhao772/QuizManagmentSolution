using QuizManagmentSystem.Models;

namespace QuizManagmentSystem.Services
{
    public interface IUserEntitiesRepositry:IRepositry<UserData>
    {
        void Update(UserData data);
        void sava();
    }
}
