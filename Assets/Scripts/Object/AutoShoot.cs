using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoShoot : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //GetComponentsInChildren<Weapon>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Weapon w in GetComponentsInChildren<Weapon>())
        {
            w.shoot();
        }
    }
}
