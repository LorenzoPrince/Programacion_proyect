using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 20f;
    float HorizontalMove;
    
    void Update()
    {
        HorizontalMove = Input.GetAxis("Horizontal");
        transform.position += new Vector3(HorizontalMove * speed * Time.deltaTime, 0, 0);
    }
}
