﻿using JabbR.Client.Models;
using System;

namespace NabbR.ViewModels.Chat
{
    public class UserViewModel : ViewModelBase
    {
        private String name;
        private String hash;
        private String note;
        private Boolean isTyping;
        private UserStatus userStatus;

        public String Name
        {
            get { return this.name; }
            set { this.Set(ref this.name, value); }
        }

        public String Hash
        {
            get { return this.hash; }
            set { this.Set(ref this.hash, value); }
        }
        public UserStatus Status
        {
            get { return this.userStatus; }
            set { this.Set(ref this.userStatus, value); }
        }

        public Boolean IsTyping
        {
            get { return this.isTyping; }
            set { this.Set(ref this.isTyping, value); }
        }

        public String Note
        {
            get { return this.note; }
            set { this.Set(ref this.note, value); }
        }
    }
}
