using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    public string PlayerTag;
    public Transform target;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == PlayerTag)
        {
            //Debug.Log("Before|| Target: " + target.position + " Player: " + other.transform.position);
            other.GetComponent<CharacterController>().enabled = false;
            other.transform.position = target.position;
            other.GetComponent<CharacterController>().enabled = true; 
            //Debug.Log("After|| Target: " + target.position + " Player: " + other.transform.position);
        }
    }

}
