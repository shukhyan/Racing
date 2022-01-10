using System;
using UnityEngine;

namespace Core.Game.Racing.Level.Control {
    public class Control : MonoBehaviour {
        //[SerializeField] private Transform transform;
        private RoadLine currentLine = RoadLine.Second;
        private float lineDistance = 1.10f;

        
        public void TurnRight() {
            if (currentLine != RoadLine.Fourth) {
                //animator.SetTrigger("isTurningRight");
                transform.position = new Vector2(transform.position.x + lineDistance, transform.position.y);
                currentLine++;
            }
        }

        public void TurnLeft() {
            if (currentLine != RoadLine.First) {
                //animator.SetTrigger("isTurningLeft");
                transform.position = new Vector2(transform.position.x - lineDistance, transform.position.y);
                currentLine--;
            }
        }

        public void Move() {
            if (Input.GetKeyDown(KeyCode.LeftArrow)) {
                TurnLeft();
            }

            if (Input.GetKeyDown(KeyCode.RightArrow)) {
                TurnRight();
            }

        }
    }
}