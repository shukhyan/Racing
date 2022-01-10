using UnityEngine;

namespace Core.Game.Racing.Level.Control {
    public static class RoadSelector {
        private static float spawnHeight = 8f;
        private static Vector3 firstLine = new Vector3(-1.65f, spawnHeight, 0);
        private static Vector3 secondLine = new Vector3(-0.55f, spawnHeight, 0);
        private static Vector3 thirdLine = new Vector3(0.55f, spawnHeight, 0);
        private static Vector3 fourthLine = new Vector3(1.65f, spawnHeight, 0);

        public static void Relocate (RoadLine currentLine,Transform transform) {
            switch (currentLine) {
                case RoadLine.First:
                    transform.position = firstLine;
                    break;
                case RoadLine.Second:
                    transform.position = secondLine;
                    break;
                case RoadLine.Third:
                    transform.position = thirdLine;
                    break;
                case RoadLine.Fourth:
                    transform.position = fourthLine;
                    break;
                default:
                    transform.position = firstLine;
                    break;
            }
        }
    }
}