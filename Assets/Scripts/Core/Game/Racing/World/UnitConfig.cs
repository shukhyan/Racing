using UnityEngine;

namespace Core.Game.Racing.World {
    [CreateAssetMenu(fileName = "UnitConfig", menuName = "Configs/Game/Racing/UnitConfig", order = 0)]
    public class UnitConfig : ScriptableObject {
        [SerializeField] private float unitSpeed;
        [SerializeField] private Sprite unitSprite;

        public float UnitSpeed => unitSpeed;
        public Sprite UnitSprite => unitSprite;
    }
}