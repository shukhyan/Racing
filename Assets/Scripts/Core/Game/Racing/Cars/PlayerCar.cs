using Core.Game.Racing.Level.Control;
using Core.Game.Racing.World;
using Unity.VisualScripting;
using UnityEngine;

namespace Core.Game.Racing.Cars {
    public class PlayerCar : MonoBehaviour {
        [SerializeField] private Control control;
        [SerializeField] private Rigidbody2D rb;
        private float startingPositionX = -0.55f;

        private Vector2 moveDirection;

        protected virtual void Awake() {
            transform.position = new Vector3(startingPositionX, transform.position.y, transform.position.z);
        }
        
        public void Move() {
            //rb.velocity = moveDirection;
        }

        public void Update() {
            control.Move();
        }
        
    }
}