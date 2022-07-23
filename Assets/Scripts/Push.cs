using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    [SerializeField] private float power;
    [SerializeField] private float pauseTime;
    [SerializeField] private Rigidbody rigidbody;

    private bool boom = false;
    private float currentTime;
    private void Start()
    {
        currentTime = pauseTime;

        rigidbody.GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        if (boom)
        {
            transform.position = new Vector3(4.697f, 0.5181859f, -8.3f);
            currentTime -= Time.deltaTime;

            if (currentTime <= 0)
            {
                transform.position = new Vector3(4.697f, 0.5181859f, -7.5f);
                boom = false;
                currentTime = pauseTime;
               

            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.rigidbody != null && currentTime <= 0)
        {
            collision.rigidbody.AddForce(0, 0, power, ForceMode.Impulse);
        }
    }

    public void StartBoom()
    {
        boom = true;
    }
}
