using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Moveable))]
public class TravelDistanceLimit : MonoBehaviour
{
    public float maxTravelDistance;
    private float travelDistance;
    private Moveable moveable;
    private PoolObject poolObject;

    private void Awake()
    {
        moveable = GetComponent<Moveable>();
        poolObject = GetComponent<PoolObject>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(travelDistance >= maxTravelDistance)
        {
            if (poolObject != null)
            {
                poolObject.deactivate();
            }
            else
            {
                Destroy(gameObject);
            }
        }
        travelDistance += moveable.newPosition().magnitude;
    }

    private void OnEnable()
    {
        travelDistance = 0;
    }
}
