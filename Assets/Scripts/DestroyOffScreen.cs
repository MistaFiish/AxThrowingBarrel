using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOffScreen : MonoBehaviour
{
    private float topBoundry = -15;
    private float botBoundry = 10;
    private float rightBoundry = -13;
    private float leftBoundry = 16;
    void Update()
    {
        if (transform.position.z < topBoundry) {
            Destroy(gameObject);
        }else if(transform.position.z > botBoundry){
            Destroy(gameObject);
        }else if(transform.position.x < rightBoundry){
            Destroy(gameObject);
        }else if(transform.position.x > leftBoundry){
            Destroy(gameObject);
        }
    }
}
