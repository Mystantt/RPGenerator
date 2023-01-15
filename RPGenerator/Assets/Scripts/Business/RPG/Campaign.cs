using Assets.Scripts.Business.Account;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

namespace Assets.Scripts.Business.RPG
{
    public class Campaign
    {
        private string _name;
        private string _description;
        private readonly List<Profile> _profiles;
        private readonly GameRules _rules;
        private Profile _adminProfile = null;

        public Campaign(string name, string description,GameRules rules,Profile profile)
        {
            _name = name;
            _description = description;
            _rules = rules;
            if(profile == null)
            {
                _profiles = new List<Profile>();
            }
            else
            {
                _profiles = new List<Profile>
                {
                    profile
                };

                //Important note, only GameMasters have admin access to modify a campaign
                if (profile.HasAdminAccess())
                {
                    _adminProfile = profile;
                }
            }
            
        }

        public void ChangeName(Profile p,string newName)
        {
            if(CanAccess(p)) { 
                _name = newName;
            }
        }

        private bool CanAccess(Profile p)
        {
            return p != null && _adminProfile != null && p.Equals(_adminProfile);
        }

        public void ChangeDescription(Profile p, string desc)
        {
            if (CanAccess(p))
            {
                _description= desc;
            }
        }

        public List<Character> GetCharacters(Profile p)
        {
            List<Character> list = new List<Character>();
            if (CanAccess(p))
            {
                foreach (Profile profile in _profiles)
                {
                    list.AddRange(profile.GetCharacters());
                }
            }
            
            return list;
        }

        public List<Profile> GetProfiles(Profile p)
        {
            List<Profile> list = new List<Profile>();
            if (CanAccess(p))
            {
                return new List<Profile>(_profiles);
            }
            return list; 
        }

        public void AddProfile(Profile p)
        {
            if((_adminProfile != null && !p.HasAdminAccess())  || _adminProfile == null)
            {
                if(p.HasAdminAccess())
                {
                    _adminProfile = p;
                }
                _profiles.Add(p);
            }
        }
        public void RemoveProfile(Profile p)
        {
            if (_profiles.Contains(p)) _profiles.Remove(p);
        }



        public string Name { get => _name;}
        public string Description { get => _description; }

        public GameRules Rules => _rules;
    }
}