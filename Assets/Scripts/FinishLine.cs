using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.gameObject.GetComponent<Enemy>();
        if (enemy)
        {
            GameManager.Instance.TakeDamage(enemy.Damage);
            Destroy(enemy.gameObject);
        }
    }
}
