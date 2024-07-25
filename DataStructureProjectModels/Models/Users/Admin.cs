namespace DataStructureProjectModels.Models.Users
{
    internal class Admin : IUsers
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserFullName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string UserAddress { get; set; }
        public string UserGender { get; set; }

        public string UserRole { get; set; }

        public void ChangePassword(string newPassword)
        {
            throw new NotImplementedException();
        }

        public string UpdateToString()
        {
            throw new NotImplementedException();
        }

        public void UserLogin(string userName, string password)
        {
            throw new NotImplementedException();
        }

        bool IUsers.UserRole()
        {
            return true;
        }
    }
}
