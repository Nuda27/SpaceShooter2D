using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float fireRate;
    public List<float> fireRateModifiers;
    private float timer = 0; 
    public PoolObjectType type;
    // Start is called before the first frame update
    private void Awake()
    {
        fireRateModifiers = new List<float>();
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime > 0 ? timer - Time.deltaTime : 0f;
    }

    public void shoot()
    {
        if(timer == 0f)
        {
            //Debug.Log("Tembak");
            ObjectPool.GetInstance().requestObject(type).activate(transform.position, transform.rotation);
            timer = fireRate / getFireRateModifiers();
        }
    }

    internal void addFireRateModifier(float modifier)
    {
        fireRateModifiers.Add(modifier);
    }

    internal void removeFireRateModifier(float modifier)
    {
        fireRateModifiers.Remove(modifier);
    }
    private float getFireRateModifiers()
    {
        float mod = 1;
        foreach(float f in fireRateModifiers)
        {
            mod += f;
        }

        return mod;
    }

    internal void clearModifier()
    {
        fireRateModifiers.Clear();
    }
}
