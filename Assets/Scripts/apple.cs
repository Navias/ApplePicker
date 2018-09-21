using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{

    public static float bottomY = -14f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
     public void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);

            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            apScript.AppleDestroyed();
        }
    }

    public void AppleDestroyed()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject tGo in tAppleArray)
        {
            Destroy(tGo);
        }
    }




}