using UnityEngine;

namespace PathCreation.Examples
{
    // Moves along a path at constant speed.
    // Depending on the end of path instruction, will either loop, reverse, or stop at the end of the path.
    public class PathFollower : MonoBehaviour
    {
        

        public PathCreator pathCreator;
        public EndOfPathInstruction endOfPathInstruction;
        public float speed = 5;
        public float currspeed;
        float distanceTravelled;
        public bool Playerdied = false;
        public GameObject GameOverUI;
        void Start() {
            if (pathCreator != null)
            {
                // Subscribed to the pathUpdated event so that we're notified if the path changes during the game
                pathCreator.pathUpdated += OnPathChanged;

                GameOverUI.SetActive(false);

            }
            currspeed = speed;
        }

        void Update()
        {

            if (Input.GetMouseButton(1)||Playerdied)
            {
                currspeed = 0;

                if (Playerdied) {

                    GameOverUI.SetActive(true);
                }
            }
            else
            {
                currspeed = speed;

            }

            if (pathCreator != null)
            {
                distanceTravelled += currspeed * Time.deltaTime;

                //calculates the position along the path using GetPointAtDistance and
                //then updates the object's position to move it along the path.

                Vector3 pathPos = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);
                transform.position = new Vector3(transform.position.x, pathPos.y, pathPos.z);
                
                transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled, endOfPathInstruction);
                transform.eulerAngles += new Vector3(0, 0, 90);
            }
        }

        // If the path changes during the game, update the distance travelled so that the follower's position on the new path
        // is as close as possible to its position on the old path
        void OnPathChanged() {
            distanceTravelled = pathCreator.path.GetClosestDistanceAlongPath(transform.position);
        }

    }
}