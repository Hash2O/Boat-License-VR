using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoutBoatManager : MonoBehaviour
{
    private float boatSpeed;
    // Start is called before the first frame update
    void Start()
    {
        boatSpeed = 2.0f * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(- boatSpeed, 0, 0);
        if(transform.position.x < -24)
        {
            gameObject.SetActive(false);
        }
    }
}
