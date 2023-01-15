using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.Business.RPG
{
    public abstract class GameRules 
    {
        protected readonly string _gameRulesName;
        protected readonly int _gameRulesVersion;
        protected readonly string url = null;

        public string GameRulesName { get => _gameRulesName; }
        public int GameRulesVersion { get => _gameRulesVersion; }

        public string URL { get => url; }

        protected GameRules(string name,int version) { 
            _gameRulesName= name;
            _gameRulesVersion= version;
        }

        protected GameRules(string gameRulesName, int gameRulesVersion, string url) : this(gameRulesName, gameRulesVersion)
        {
            this.url = url;
        }
    }
}