using System;
using Core.Game.Racing.World;
using UnityEngine;

namespace Core.Game.Racing.Level.World {
    public class ScrollingObject{
        private Rigidbody2D[] rigidbodys;
        private Rigidbody2D rigidbody;
        private UnitConfig config;
        private float scrollingSpeed;

        public void Setup(UnitConfig config, Rigidbody2D[] rigidbodys) {
            this.config = config;
            this.rigidbodys = rigidbodys;
            scrollingSpeed = -config.UnitSpeed;
        }

        public void Setup(UnitConfig config, Rigidbody2D rigidbody) {
            this.config = config;
            this.rigidbody = rigidbody;
            scrollingSpeed = -config.UnitSpeed;
        }

        public void Move() {
            if (rigidbody != null) {
                rigidbody.velocity = new Vector2(0, scrollingSpeed * Time.fixedDeltaTime);
            }
            else {
                foreach (var rb in rigidbodys) {
                    rb.velocity = new Vector2(0, scrollingSpeed * Time.fixedDeltaTime);
                }
            }
        }
    }
}