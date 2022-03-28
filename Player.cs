using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Movespeed = 7.0f;
    public float Turnspeed = 120f;

    private void Update()
    {
        float vert = Input.GetAxis("Vertical");     //arrows, WASD keys
        float horz = Input.GetAxis("Horizontal");

        this.transform.Translate(Vector3.forward * vert * Movespeed * Time.deltaTime);
        this.transform.Rotate(Vector3.up, horz * Turnspeed * Time.deltaTime);
    }
}
