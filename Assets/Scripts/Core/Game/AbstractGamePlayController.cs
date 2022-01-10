using System;
using Services.SaveSystem.Games;
using UnityEngine;

namespace Core.Game {
    public abstract class AbstractGamePlayController : MonoBehaviour {
        public abstract event Action OnGameStarted;
        public abstract event Action<GameEndReason, int> OnGameEnd;
        public abstract event Action OnGameLeft;


        public bool IsGameReady { get; protected set; }
        public bool IsGameStarted { get; protected set; }

        public abstract void Setup(IGameData gameData);
        public abstract void CreateGame();
        public abstract void StartGame();
        public abstract void EndGame(GameEndReason reason);
    }
}