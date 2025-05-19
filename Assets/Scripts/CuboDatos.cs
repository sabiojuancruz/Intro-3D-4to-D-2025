using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboDatos : MonoBehaviour
{
    public GameObject cubo;
    public Transform mano;

    private bool activo;

    // Update is called once per frame
    void Update()
    {
        if (activo == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                transform.SetParent(mano);
                cubo.transform.position = mano.position;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "FirstPersonCharacter")
        {
            activo = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "FirstPersonCharacter")
        {
            activo = false;
        }
    }
}
