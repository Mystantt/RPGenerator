using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Business.Map
{
    [CreateAssetMenu(menuName = "Decor/DecorPart", fileName = "New Decor Part")]
    public class DecorPart : ScriptableObject
    {
        [SerializeField] private double _obstructionLevel;

        public DecorPart(double obstructionLevel) { _obstructionLevel = obstructionLevel; }

        public double ObstructionLevel { get => _obstructionLevel; set => _obstructionLevel = value; }
    }
}