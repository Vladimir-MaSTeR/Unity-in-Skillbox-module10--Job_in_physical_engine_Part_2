using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    [SerializeField] private float power;
    [SerializeField] private float pauseTime;
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private ConfigurableJoint configurableJoint;

    private bool boom = false;
    private float currentTime;
    //private Rigidbody rigidbody;
    private void Start()
    {
        currentTime = pauseTime;

        //rigidbody.GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        Vector3 position = configurableJoint.targetPosition;
        if (boom)
        {
            //transform.position = new Vector3(4.697f, 0.5181859f, -8.3f);

           
            configurableJoint.targetPosition = new Vector3(0, 0, -3f);
            currentTime -= Time.deltaTime;

            if (currentTime <= 0)
            {
                // transform.position = new Vector3(4.697f, 0.5181859f, -7.5f);
                configurableJoint.targetPosition = new Vector3(0, 0, 0);
                rigidbody.AddForce(0, 0, power, ForceMode.Impulse);
                boom = false;
                currentTime = pauseTime;
               

            }
        }
    }       

    public void StartBoom()
    {
        boom = true;
    }
}
