using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AirCraft : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;

    [SerializeField] Vector3 direction;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        direction.Normalize();

        // P = P0 + vt

        transform.Translate(direction * speed * Time.deltaTime);

    }
}
