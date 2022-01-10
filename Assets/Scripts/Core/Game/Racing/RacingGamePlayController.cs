using System;
using Services.SaveSystem.Games;

namespace Core.Game.Racing.Level {
    public class RacingGamePlayController : AbstractGamePlayController {
        public override event Action OnGameStarted;
        public override event Action<GameEndReason, int> OnGameEnd;
        public override event Action OnGameLeft;
        
        public override void Setup(IGameData gameData) {
            Inject();
        }

        public override void CreateGame() {
            
        }

        public override void StartGame() {
            
        }

        public override void EndGame(GameEndReason reason) {
            
        }

        public void Inject() {
            
        }
    }
}