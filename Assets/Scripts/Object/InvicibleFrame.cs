using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvicibleFrame : MonoBehaviour
{
    public float duration;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime < 0 ? 0 : timer - Time.deltaTime;
    }

    public void activate()
    {
        timer = duration;
        deactivateCollider();
        StartCoroutine(blinking());
    }

    private void deactivateCollider()
    {
        GetComponent<CircleCollider2D>().enabled = false;
    }

    private void activateCollider()
    {
        GetComponent<CircleCollider2D>().enabled = true;
    }
    private IEnumerator blinking()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        Color defaultColor = sr.color;
        Color hitColor = defaultColor;
        hitColor.a = 0.2f;
        
        while(timer > 0)
        {
            sr.color = hitColor;
            yield return new WaitForSeconds(0.2f);
            sr.color = default;
            yield return new WaitForSeconds(0.2f);
        }
        sr.color = defaultColor;
        activateCollider();
    }
}
