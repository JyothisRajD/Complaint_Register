using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace application_nest.BAL
{
    public class reg_BAL
    {
        DAL.reg_DAL objone = new DAL.reg_DAL();

        private int _user_id;
        private string _user_email;
        private string _user_phone;
        private string _name;
        private int _login_id;
        private string _login_password;
        private string _login_username;

        public int Userid
        {
            get
            {
                return _user_id;
            }
            set
            { _user_id = value; }
        }
        public string usrname
        {
            get
            {
                return _login_username;
            }
            set
            {
                _login_username = value;
            }
        }
        public string phone
        {
            get
            {
                return _user_phone;
            }
            set
            {
                _user_phone = value;
            }
        }
        public string Email
        {
            get
            {
                return _user_email;
            }
            set
            {
                _user_email = value;
            }
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
        public int LoginId
        {
            get
            { 
                return _login_id;
            }
            set
            {
                _login_id = value; 
            }
        }
        public string Password
        {
            get
            {
                return _login_password;
            }
            set
            {
                _login_password = value;
            }
        }

        public object Insert()
        {
            return objone.Insert(this);
        }

        public int Insertlogin()
        {
            return objone.loginInsert(this);
        }
        public DataTable login()
        {
            return objone.checklog(this);
        }
        public DataTable viewRegisteration()
        {
            return objone.registerationView();
        }
        public int Confirmation()
        {
            return objone.UserConfirm(this);
        }
    }
}