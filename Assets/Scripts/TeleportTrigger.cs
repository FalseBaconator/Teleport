using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    //public string PlayerTag;
    public Transform target;
    public GameObject player;

    private int timesPorted = 0;

    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.CompareTag(player.tag))
        {
            //Debug.Log("Before|| Target: " + target.position + " Player: " + other.transform.position);
            //other.GetComponent<CharacterController>().enabled = false;
            //other.transform.position = target.position;
            //other.GetComponent<CharacterController>().enabled = true; 

            //Vector3 toMove = target.position - other.transform.position;
            Vector3 toMove = target.position - player.transform.position;
            Debug.Log(toMove.magnitude + "||" + Time.time);
            player.GetComponent<CharacterController>().Move(toMove);

            //Debug.Log("After|| Target: " + target.position + " Player: " + other.transform.position);
        }
    }

}
