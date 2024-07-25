namespace DataStructureProjectModels.Models.Users
{
    public class Tourist : IUsers
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserFullName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string UserAddress { get; set; }
        public string UserGender { get; set; }

        public Tourist()
        {
        }

        public Tourist(int userId, string userName, string userPassword, string userFullName, string userEmail, string userPhone, string userAddress, string userGender)
        {
            UserId = userId;
            UserName = userName;
            UserPassword = userPassword;
            UserFullName = userFullName;
            UserEmail = userEmail;
            UserPhone = userPhone;
            UserAddress = userAddress;
            UserGender = userGender;
        }

        public void ChangePassword(string newPassword)
        {
            this.UserPassword = newPassword;
        }

        public string UpdateToString()
        {
            return $"User ({UserFullName} / {UserGender} /{UserEmail} / {UserAddress} / {UserPhone})";
        }

        public void UserLogin(string userName, string password)
        {
            throw new NotImplementedException();
        }

        bool IUsers.UserRole()
        {
            return false;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return this.UpdateToString();
        }

    }
}
