using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    [SerializeField] private float power;
    [SerializeField] private float pauseTime;
    [SerializeField] private float freeTime;
  //  [SerializeField] private Rigidbody rigidbody;
   // [SerializeField] private ConfigurableJoint configurableJoint;

  //  private bool boom = false;
    private float currentTimePaused;
    private float currentTimeFree;
    private Rigidbody rigidbody;
    private void Start()
    {
        currentTimePaused = pauseTime;
        currentTimeFree = freeTime;

        rigidbody = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {

        currentTimeFree -= Time.deltaTime;
       
        if (currentTimeFree <= 0 && currentTimePaused > 0)
        {

            rigidbody.AddForce(0, 0, -power, ForceMode.Acceleration);

            currentTimePaused -= Time.deltaTime;

            

        } else if (currentTimePaused <= 0)
        {
            currentTimeFree = freeTime;
            currentTimePaused = pauseTime;
        }
    }       



    /*
    public void StartBoom()
    {
        boom = true;
    }
    */
}
