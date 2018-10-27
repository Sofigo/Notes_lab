using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Notes
{
    class User
    {

        #region Const
        #endregion
        #region Fields
        private Guid _guid;
        private int _userid;
        private string _name;
        private string _surname;
        private string _userName;
        private string _email;
        private string _password;
        private DateTime _lastLoginDateTime;
        private List<Note> _notes;
        #endregion
        #region Properties 
        public Guid Guid
        {
            get
            {
                return _guid;
            }
            private set
            {
                _guid = value;
            }
        }
        public int UserId
        {
            get { return _userid; }
            private set { _userid = value; }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string SurName
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public DateTime LastLoginDatetime
        {
            get
            {
                return _lastLoginDateTime;
            }
            set
            {
                _lastLoginDateTime = value;
            }
        }
        public string Password
        {
            get { return _password; }
            private set { _password = value; }
        }
        public List<Note> Notes
        {
            get { return _notes; }
            private set { _notes = value; }
        }
        #endregion
        #region Constructor

        public User(int UserId, string Name, string Surname, string userName, string Email, string password) : this()
        {
            _guid = Guid.NewGuid();
            _userid = UserId;
            _name = Name;
            _surname = Surname;
            _userName = UserName;
            _lastLoginDateTime = DateTime.Now;

            // SetPassword(password);
        }

        private User()
        {
            _notes = new List<Note>();
        }

        #endregion

        public override string ToString()
        {
            return UserName;
        }
    }
}
