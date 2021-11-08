using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundary = 50;
    private float bottomBoundary = -5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject);
        }else if (transform.position.z < bottomBoundary)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
