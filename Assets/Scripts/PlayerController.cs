using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;

    public void Awake()
    {
        if (Instance)
            Destroy(gameObject);
        else
            Instance = this;
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if (Physics.Raycast(ray, out hit)) 
            {
                TurretBase TurretBaseHitted = hit.transform.GetComponent<TurretBase>();
                if (TurretBaseHitted)
                {
                    Destroy (TurretBaseHitted.gameObject);
                }
            }
        }
    }
}
