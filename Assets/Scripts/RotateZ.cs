using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateZ : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(0f, 0f, 45f * Time.deltaTime, Space.Self);
    }
}
