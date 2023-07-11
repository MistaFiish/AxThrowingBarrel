using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
   public float speed = 4.0f;
   
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);

    }
}
