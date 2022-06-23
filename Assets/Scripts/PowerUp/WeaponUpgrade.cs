using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponUpgrade : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addComponentToObject(GameObject go)
    {
        go.AddComponent<WeaponUpgrade>();
        go.GetComponent<WeaponSetController>().weapongUpgradeCheck();
    }
}
