using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    public GameObject unitychan;
    // Use this for initialization
    void Start()
    {
        unitychan = GameObject.Find("unitychan");

    }

    // Update is called once per frame
    void Update()
    {
        if (unitychan.transform.position.z > this.transform.position.z) { Destroy(this.gameObject); }
    }
}
