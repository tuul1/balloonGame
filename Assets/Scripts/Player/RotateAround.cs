using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Place this script on a game object to make it rotate around a target object
public class RotateAround : MonoBehaviour
{
    public GameObject target;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the target's position
        Vector3 targetPosition = target.transform.position;
		
		// Calculate rotation amount
		float rotation = Time.deltaTime * speed;
		
		// Apply rotation on the game object
        transform.RotateAround(targetPosition, Vector3.forward, rotation);
    }
}
