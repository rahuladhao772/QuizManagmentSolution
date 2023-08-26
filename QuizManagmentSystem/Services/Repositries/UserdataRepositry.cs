using QuizManagmentSystem.DataContext;
using QuizManagmentSystem.Models;

namespace QuizManagmentSystem.Services.Repositries
{
    public class UserdataRepositry : Repositry<UserData>, IUserEntitiesRepositry
    {
        private ApplicationDbContext _db;
        public UserdataRepositry(ApplicationDbContext db):base(db)
        {
                _db = db;
        }
        public void sava()
        {
            _db.SaveChanges();
        }

        public void Update(UserData data)
        {
            _db.userEntities.Update(data);
        }
    }
}
