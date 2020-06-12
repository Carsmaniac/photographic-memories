using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearOnEnter : MonoBehaviour
{
    public GameObject appearingObject;

    // Start is called before the first frame update
    void Start()
    {
        appearingObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.name == "VR Rig")
        {
            appearingObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider trigger)
    {
        if (trigger.name == "VR Rig")
        {
            appearingObject.SetActive(false);
        }
    }
}
