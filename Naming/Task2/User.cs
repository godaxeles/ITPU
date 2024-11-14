using System;

namespace Naming.Task2
{
    public class User
    {
        private DateTime _birth;

        private string _name;

        private bool _isAdmin;

        private User[] _subordinateArray;

        private int _rating;

        public User(string name)
        {
            this._name = name;
        }

        public override string ToString()
        {
            return "User [Birth=" + _birth + ", Name=" + _name + ", IsAdmin=" + _isAdmin + ", SubordinateArray="
                   + string.Join<User>(", ", _subordinateArray) + ", Rating=" + _rating + "]";
        }
    }
}
