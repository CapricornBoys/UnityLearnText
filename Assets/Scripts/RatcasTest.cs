using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatcasTest : MonoBehaviour
{
    private bool isNextMove = false;
    private Vector3 point;
    private GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Sphere").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hitInfo))
            {
                Debug.Log("hitInfo = " + hitInfo);
                if (hitInfo.collider.gameObject.name == "Plane")
                {
                    Debug.Log("111111111");
                    isNextMove = true;
                    point = hitInfo.point;
                }
            }            
        }

        if (isNextMove)
        {
            Move(point);
        }
    }

    void Move(Vector3 point)
    {
        ball.transform.position = Vector3.MoveTowards(ball.transform.position,point,Time.deltaTime * 3.0f);

        if (ball.transform.position == point)
            isNextMove = false;
    }
}
