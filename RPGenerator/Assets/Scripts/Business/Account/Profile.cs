using Assets.Scripts.Business.RPG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

namespace Assets.Scripts.Business.Account
{
    public enum GameRole
    {
        None, Player, GameMaster
    }

    public class Profile 
    {
        private readonly GameRole _role;
        private Campaign _campaign;
        private readonly List<Character> _characters;

        public string Name { get; set; }

        public GameRole Role => _role;

        public Campaign Campaign => _campaign;

        public Profile(string name, GameRole role, Campaign campaign)
        {
            Name = name;
            _role = role;
            _campaign = campaign;
            _characters = new List<Character>();
        }

        public List<Character> GetCharacters()
        {
            return new List<Character>(_characters);
        }
        public void AddCharacter(Character character)
        {
            _characters.Add(character);
        }
        public void RemoveCharacter(Character character)
        {
            if (_characters.Contains(character)) _characters.Remove(character);
        }

        public bool HasAdminAccess()
        {
            return _role.Equals(GameRole.GameMaster);
        }

        public void QuitCampaign()
        {
            if (_campaign!= null)
            {
                _campaign.RemoveProfile(this);
                _campaign = null;
            }
        }
    }
}