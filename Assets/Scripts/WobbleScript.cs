using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WobbleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(Mathf.Sin(42* Time.time), Mathf.Sin(56.9f * Time.time), Mathf.Sin(3 * Time.time));
        transform.localScale = new Vector3(Mathf.Sin(10 * Time.time), Mathf.Sin(79 * Time.time), Mathf.Sin(0.3f * Time.time));
        transform.Rotate(Mathf.Sin(20 * Time.time), Mathf.Sin(25.5f * Time.time), Mathf.Sin(420 * Time.time));
        GetComponent<Rigidbody>().mass = Mathf.Sin(15 * Time.time);
    }
}
