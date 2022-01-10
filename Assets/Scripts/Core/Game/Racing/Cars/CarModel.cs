using System;
using Core.Game.Racing.Level.Control;
using Core.Game.Racing.Level.World;
using Core.Game.Racing.World;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Core.Game.Racing.Cars {
    public class CarModel : MonoBehaviour {
        [SerializeField] private Rigidbody2D rb;
        [SerializeField] private SpriteRenderer spriteRenderer;
        [SerializeField] private Collider2D carCollider;
        
        private RoadLine roadline;
        private UnitConfig config;
        private ScrollingObject scrollingObject = new ScrollingObject();

        public UnitConfig Config {
            get { return config; }
            set { config = value; }
        }

        public Collider2D CarCollider => carCollider;
        
        private Vector2 moveDirection;

        public void Setup() {
            Relocate();
            spriteRenderer.sprite = config.UnitSprite;
            scrollingObject.Setup(config, rb);
        }

        public void Move() {
            scrollingObject.Move();
        }

        public void Relocate() {
            int random = Random.Range(0, 4);
            roadline = (RoadLine) random;
            RoadSelector.Relocate(roadline, transform);
        }
        
        // private void Respawn() {
        //     int randomType = Random.Range(0, CarPool.CarTypes.Length);
        //     config = CarPool.CarTypes[randomType];
        //     Relocate();
        // }
        
        // private void OnTriggerEnter(Collider other) {
        //     if (other == poolingBorder) {
        //         //Respawn();
        //     }
        // }
    }
}