using FCamara.Domain.ValueObjects;
using FCamara.Shared.Entities;

namespace FCamara.Domain.Entities
{
    public class Customer :  Entity
    {
        protected Customer(){ }

        public Customer(string name, Email email, User user)
        {
            Name = name;
            Email = email;
            Active = true;
            User = user;

            AddNotifications(email.Notifications);
        }

        public string Name { get; private set; }
        public Email Email { get; private set; }
        public bool Active { get; private set; }

        public User User { get; private set; }
    }
}
