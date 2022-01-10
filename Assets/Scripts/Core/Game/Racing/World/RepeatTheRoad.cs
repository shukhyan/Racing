using System;
using Core.Game.Racing.World;
using UnityEngine;

namespace Core.Game.Racing.Level.World {
    public class RepeatTheRoad : MonoBehaviour {
        [SerializeField] private Rigidbody2D[] rigidbodys;
        [SerializeField] private UnitConfig config;
        [SerializeField] private Transform[] roadList;
        [SerializeField] private int numberOfRoads;
        
        private float unitHeight;
        private ScrollingObject scrollingObject = new ScrollingObject();

        private void Start() {
            unitHeight = config.UnitSprite.texture.height / config.UnitSprite.pixelsPerUnit;
            scrollingObject.Setup(config, rigidbodys);
        }

        private void Update() {
            foreach (var road in roadList) {
                if (road.position.y < -numberOfRoads * unitHeight) {
                    UpdatePosition(road);
                }
            }
        }

        private void FixedUpdate() {
            scrollingObject.Move();
        }

        private void UpdatePosition(Transform road) {
            Vector2 nextPosition = new Vector2(0, 2 * numberOfRoads * unitHeight);
            road.position += (Vector3)nextPosition;
        }
    }
}