using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerbound = -10;
    private float sideBound = 30;
    private static int Lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z <lowerbound)
        {
            Lives--;
            Debug.Log("Lives:" + Lives);
            if (Lives <= 0)
            {
                Destroy(gameObject);
                Debug.Log("Game Over!");
            }
        } else if(transform.position.x < -sideBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        else if(transform.position.y < sideBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
