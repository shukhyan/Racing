using System;
using System.Collections;
using Core.Game.Racing.World;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Core.Game.Racing.Cars {
    public class CarPool : MonoBehaviour {
        [SerializeField] private UnitConfig[] carTypes;
        [SerializeField] private CarModel[] cars;
        [SerializeField] private float carDistanceY;

        private float distanceMultiplier = 1f;
        
        private void Start() {
            SetStartingPositions();
        }
        
        private void FixedUpdate() {
            foreach (var car in cars) {
                car.Move();
            }
        }
        
        private void SetStartingPositions() {
            for (int i = 0; i < cars.Length; i++) {
                int randomType = Random.Range(0, carTypes.Length);
                cars[i].Config = carTypes[randomType];
                cars[i].Setup();
                cars[i].transform.position += Vector3.up * carDistanceY * distanceMultiplier;
                distanceMultiplier++;
            }
        }

        private void OnTriggerEnter2D (Collider2D other) {
            for (int i = 0; i < cars.Length; i++) {
                if (other == cars[i].CarCollider) {
                    Respawn(cars[i]);
                    break;
                }
            }
        }

        private void Respawn(CarModel car) {
            int randomType = Random.Range(0, carTypes.Length);
            car.Config = carTypes[randomType];
            car.Setup();
        }
    }
}