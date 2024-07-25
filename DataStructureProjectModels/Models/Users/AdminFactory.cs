namespace DataStructureProjectModels.Models.Users
{
    internal class AdminFactory : IUserFactory
    {
        public IUsers createUser()
        {
            return new Admin();
        }
    }
}
