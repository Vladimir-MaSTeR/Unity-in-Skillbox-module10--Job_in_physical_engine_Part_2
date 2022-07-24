using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomWall : MonoBehaviour
{
    [SerializeField] private HingeJoint hingeJoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            hingeJoint.breakForce = 0f;
        }
        
    }       
}
