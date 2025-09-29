using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class FollowPlayer : MonoBehaviour
{
    public GameObject capsule;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = capsule.transform.position + new Vector3(0,2,-15);
    }
}
