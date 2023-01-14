using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Assets.Scripts.Business.Utils
{
    public class DicoMapAssets : MonoBehaviour
    {
        private static DicoMapAssets instance;
        private Dictionary<Theme, List<ScriptableObject>> _allAssets;
        // Start is called before the first frame update
        void Start()
        {
            if (instance != null)
            {
                Destroy(instance);
            }
            else
            {
                instance = this;
            }
            _allAssets = retrieveAssets();
            DontDestroyOnLoad(gameObject);
        }

        private Dictionary<Theme, List<ScriptableObject>> retrieveAssets()
        {
            Dictionary<Theme, List<ScriptableObject>> assets = new Dictionary<Theme, List<ScriptableObject>>();
            return assets;
        }

        public static List<ScriptableObject> FromTheme(Theme theme)
        {
            return instance._allAssets[theme];
        }
    }
}