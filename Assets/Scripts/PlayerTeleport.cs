using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Vector3 toMove = target.position - transform.position;
            GetComponent<CharacterController>().Move(toMove);
            GetComponent<CharacterController>().SimpleMove(Vector3.zero);
        }
    }
}
