using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSetController : MonoBehaviour
{
    public GameObject[] weaponSet;
    // Start is called before the first frame update
    void Start()
    {
        deaactiveAllWeapons();
        activeWeaponSet(0);
        weapongUpgradeCheck();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activeWeaponSet(int upgradeLevel)
    {
        for (int i = 0; i<weaponSet.Length;i++)
        {
            if(i == upgradeLevel)
            {
                weaponSet[i].SetActive(true);
            }
            else
            {
                weaponSet[i].SetActive(false);
            }
        }
    }

    private void deaactiveAllWeapons()
    {
        foreach(GameObject go in weaponSet)
        {
            go.SetActive(false);
        }
    }

    public void weapongUpgradeCheck()
    {
        int upgradeLevel = GetComponents<WeaponUpgrade>().Length;
        if (upgradeLevel >= weaponSet.Length)
        {
            upgradeLevel = weaponSet.Length - 1;
        }
        activeWeaponSet(upgradeLevel);
        fireRateUpdate();
        //Debug.Log(upgradeLevel);
    }

    private void fireRateUpdate()
    {
        foreach(Weapon w in GetComponentsInChildren<Weapon>())
        {
            w.clearModifier();
            foreach(FireRateModifier f in GetComponents<FireRateModifier>())
            {
                w.addFireRateModifier(f.modifier);
            }
        }
    }
}
