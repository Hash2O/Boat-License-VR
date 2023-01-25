using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Angle = Random.Range(-5f, 5f);
        //SeaEffect(Angle);
    }

    void SeaEffect(float Angle)
    {
        transform.Rotate(Vector3.right, Angle * Time.deltaTime);
        transform.Rotate(Vector3.up, Angle * Time.deltaTime);
    }
}
