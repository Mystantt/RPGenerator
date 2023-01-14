using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Business.Map
{
    [CreateAssetMenu(menuName = "Decor/Decor", fileName = "New Decor")]
    public class Decor : ScriptableObject
    {
        [SerializeField] private readonly List<DecorPart> _decorParts;

        public Decor(List<DecorPart> parts) { _decorParts = parts; }

        public List<DecorPart> GetDecorParts()
        {
            return new List<DecorPart>(_decorParts);
        }
    }
}