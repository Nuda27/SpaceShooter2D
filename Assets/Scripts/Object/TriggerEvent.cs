using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CircleCollider2D))]
public class TriggerEvent : MonoBehaviour
{
    public string targetTag;
    public UnityEvent OnTrigger;
    public UnityEvent<GameObject> OnTriggerWithGameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col) 
    {
        //Debug.Log("target tag : " + targetTag + "coll tag :" +col.tag);
        if(col.tag == targetTag)
        {
            OnTrigger?.Invoke();
            OnTriggerWithGameObject?.Invoke(col.gameObject);
        }
    }
}
