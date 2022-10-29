using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trail : MonoBehaviour
{
    private float speedRate = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
		Vector3 speed = new Vector3(hor, 0, ver) * speedRate;
		transform.position += speed * Time.deltaTime;
    }
}
