using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 7f;
    public float sprintSpeed = 10f;
    public GameObject projectilePrefab;


    private void Update() {
        Vector2 vectorImput = new Vector2(0, 0);

        if(Input.GetKey(KeyCode.W)){
            vectorImput.y = -1;
        }
        if(Input.GetKey(KeyCode.S)){
            vectorImput.y = +1;
        }
        if(Input.GetKey(KeyCode.A)){
            vectorImput.x = +1;
        }
        if(Input.GetKey(KeyCode.D)){
            vectorImput.x = -1;
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        vectorImput = vectorImput.normalized;

        Vector3 moveDir = new Vector3(vectorImput.x, 0f, vectorImput.y);
        if(Input.GetKey(KeyCode.LeftShift)){
            transform.position += moveDir * moveSpeed * sprintSpeed * Time.deltaTime;
        }else
        {
            transform.position += moveDir * moveSpeed * Time.deltaTime;
        }
        
        Debug.Log(vectorImput);
    }
}
