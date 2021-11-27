using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knopka : MonoBehaviour
{
    bool Player_in_trigger = false;
    // Start is called before the first frame update
    void Update()

    {
        if (Input.GetKeyDown(KeyCode.E) && Player_in_trigger)
        { 
            print("Все ок")

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Player_in_trigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Player_in_trigger = false;
    }





}
