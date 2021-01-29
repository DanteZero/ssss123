using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.SetParent(this.camera.transform);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
