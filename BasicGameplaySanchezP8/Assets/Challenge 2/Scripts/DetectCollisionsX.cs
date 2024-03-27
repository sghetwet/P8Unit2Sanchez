using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private static int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        score += 1;
        Debug.Log("Score:" + score);
    }
}
