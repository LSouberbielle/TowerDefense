using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform EndPoint;
    public float Speed = 1f;
    public float Damage = 10f;


    public void Update()
    {
        transform.LookAt(EndPoint);
        transform.position += transform.forward * Speed * Time.deltaTime;
    }
}
