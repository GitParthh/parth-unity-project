using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovementScript : MonoBehaviour
{
    public float Moving_speed;
    public float deathZone = -25;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * Moving_speed) * Time.deltaTime;
        if (transform.position.x < deathZone)
        {
            Debug.Log("pipe Deleted");
            Destroy(gameObject);
        }
    }

}
