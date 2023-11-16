﻿namespace BookHaven.UI.Models.ViewModel
{
    public class UserViewModel
    {
        public List<User> Users { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool AdminRoleCheckBox { get; set; }
    }
}
