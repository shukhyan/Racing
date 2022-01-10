using UnityEngine;

namespace Core.Game {
    [CreateAssetMenu(fileName = "GameConfig", menuName = "Configs/Game/GameConfig", order = 0)]
    public class GameConfig : ScriptableObject {
        [SerializeField] private AbstractGamePlayController gamePlayController;
        [SerializeField] private GameType gameType;

        public AbstractGamePlayController GamePlayController => gamePlayController;
        public GameType GameType => gameType;
    }
}