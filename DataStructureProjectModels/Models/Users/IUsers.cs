namespace DataStructureProjectModels.Models.Users
{
    public interface IUsers
    {

        void UserLogin(string userName, string password);
        void ChangePassword(string newPassword);
        bool UserRole();
        string UpdateToString();

    }
}
