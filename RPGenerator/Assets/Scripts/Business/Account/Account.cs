using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Business.Account
{
    public class Account
    {
        private readonly List<Profile> _profiles;
        public Account(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            _profiles = new List<Profile>();
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<Profile> GetProfiles()
        {
            return new List<Profile>(_profiles);
        }
        public void AddProfile(Profile profile)
        {
            _profiles.Add(profile);
        }
        public void RemoveProfile(Profile profile)
        {
            if (_profiles.Contains(profile)) _profiles.Remove(profile);
        }
    }
}