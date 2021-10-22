using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nucleus_rotator : MonoBehaviour
{
    public GameObject nucleus;
    private int rotateSpeed;

    private void Start()
    {
        rotateSpeed = Random.Range(-70, 70);
    }

    void Update()
    {
        transform.RotateAround(nucleus.transform.position, Vector3.back, rotateSpeed * Time.deltaTime);
    }
}
