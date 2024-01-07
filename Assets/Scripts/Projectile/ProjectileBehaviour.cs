using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float speed;
    public float destroyAfter = 3f;

    // Start is called before the first frame update
    void Start()
    {
        // Option 1 - Destroy the projectile after some time has passed
        //Destroy(gameObject, destroyAfter);
    }

    // Option 2 - Destroy the projectile if it's outside the camera view
    // (only works if the object has a Sprite renderer (2D) or Mesh renderer (3D) components)
    void OnBecameInvisible()    
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
