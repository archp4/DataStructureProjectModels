namespace DataStructureProjectModels.Models.Users
{
    public class TouristFactory : IUserFactory
    {
        public IUsers createUser()
        {
            return new Tourist();
        }
    }
}
