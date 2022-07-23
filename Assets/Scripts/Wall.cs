using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    [SerializeField] private float powerX;
    [SerializeField] private float powerY;
    [SerializeField] private float powerZ;

    [SerializeField] private bool randomGo = false;

    [SerializeField] private float powerMin = -7;
    [SerializeField] private float powerMax = 7;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody != null)
        {
            if (randomGo == false)
            {
                collision.rigidbody.AddForce(powerX, powerY, powerZ, ForceMode.Impulse);
            } else
            {
                collision.rigidbody.AddForce(powerMin, 0, powerMax, ForceMode.Impulse);
            }
        }
    }


}
