using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FireRateModifier : MonoBehaviour
{
    public float modifier = 0.2f;
    private List<Weapon> weapons;

    private void Awake()
    {
        weapons = GetComponentsInChildren<Weapon>().ToList<Weapon>();
    }
    // Start is called before the first frame update
    void Start()
    {
        // foreach(Weapon w in weapons)
        // {
        //     w.addFireRateModifier(modifier);
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        foreach(Weapon w in weapons)
        {
            w.removeFireRateModifier(modifier);
        }
    }

    public void addComponentToObject(GameObject go)
    {
        go.AddComponent<FireRateModifier>();
        go.GetComponent<WeaponSetController>().weapongUpgradeCheck();
    }
}
