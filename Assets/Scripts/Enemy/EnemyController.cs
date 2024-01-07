using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float minPosX;
    public float maxPosX;
    public float moveDistance;
    public float timeStep;
    public float acceleration;

    private bool isMovingRight = true;

    // Use this for initialization
    void Start()
    {

        // Call the MoveEnemies function every timeStep interval
        InvokeRepeating("MoveEnemies", timeStep, timeStep);
    }

    void MoveEnemies()
    {
        if (isMovingRight)
        {
            // Determine and apply the new position instantly
            float newPositionX = transform.position.x + moveDistance;
            transform.position = new Vector2(newPositionX, transform.position.y);

            // Check if the enemy group has reached the rightmost point
            if (newPositionX >= maxPosX)
            {
                isMovingRight = false;
            }
        }
        else
        {
            float newPositionX = transform.position.x - moveDistance;
            transform.position = new Vector2(newPositionX, transform.position.y);

            // Check if the enemy group has reached the leftmost point
            if (newPositionX <= minPosX)
            {
                isMovingRight = true;
            }
        }
    }

    // Update is called once per frame
   void Update()
    {
        
    }
}
