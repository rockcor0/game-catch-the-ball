using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float waitTime = 1f;
    float nextShot = 0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextShot)
        {
            nextShot = Time.time + waitTime;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
