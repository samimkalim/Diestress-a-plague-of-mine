using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
    public Text interactionText;
    public string PressButtonText;
    public string SecondText;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            interactionText.text = string.Format("{0}", PressButtonText);
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Player")
        {
            if(Input.GetKey(KeyCode.E))
            {
                interactionText.text = string.Format("{0}", SecondText);
            }
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.tag == "Player")
        {
            interactionText.text = "";
        }
    }
}
