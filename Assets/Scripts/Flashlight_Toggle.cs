using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight_Toggle : MonoBehaviour
{

    [SerializeField] GameObject FLASHLIGHT;
    private bool FlashlightActive = false;

    // Start is called before the first frame update
    void Start()
    {
        FLASHLIGHT.gameObject.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (FlashlightActive == false)
            {
                FLASHLIGHT.gameObject.SetActive(true);
                FlashlightActive = true;
            }
            else
            {
                FLASHLIGHT.gameObject.SetActive(false);
                FlashlightActive = false;
            }
        }
    }
}
