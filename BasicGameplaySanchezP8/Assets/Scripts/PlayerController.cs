using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInputl;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInputl = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInputl * Time.deltaTime * speed);
    }
}
