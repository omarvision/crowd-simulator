using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfollow : MonoBehaviour
{
    public GameObject lookat = null;
    public GameObject moveto = null;
    public float lookspeed = 90;
    public float movespeed = 5;

    private void LateUpdate()
    {
        if (lookat != null)
        {
            Quaternion rotTarget = Quaternion.LookRotation(lookat.transform.position - this.transform.position);
            this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, rotTarget, lookspeed * Time.deltaTime);
        }
        
        if (moveto != null)
        {
            this.transform.position = Vector3.Lerp(this.transform.position, moveto.transform.position, movespeed * Time.deltaTime);
        }        
    }
}
