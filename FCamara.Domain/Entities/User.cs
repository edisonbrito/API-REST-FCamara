using System.Text;
using FCamara.Shared.Entities;

namespace FCamara.Domain.Entities
{
    public class User : Entity
    {
        protected User() { }

        public User(string userName, string password)
        {
            Username = userName;
            Password = EncryptPassword(password);
        }
        
        public string Username { get; private set; }
        public string Password { get; private set; }

        public bool Authenticate(string username, string password)
        {
            if (Username == username && Password == EncryptPassword(password))
                return true;

            AddNotification("User", "Usuário ou senha inválidos");
            return false;
        }

        private string EncryptPassword(string pass)
        {
            if (string.IsNullOrEmpty(pass)) return "";
            var password = (pass += "|2BC0E82C-F70C-4AED-A5D2-4779B2938F41");
            var md5 = System.Security.Cryptography.MD5.Create();
            var data = md5.ComputeHash(Encoding.Default.GetBytes(password));
            var sbString = new StringBuilder();
            foreach (var t in data)
                sbString.Append(t.ToString("x2"));

            return sbString.ToString();
        }
    }
}
