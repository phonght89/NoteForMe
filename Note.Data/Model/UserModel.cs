﻿namespace Note.Data.Model
{
    public class UserModel
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public byte State { get; set; }
        public byte Type { get; set; }
    }
}
