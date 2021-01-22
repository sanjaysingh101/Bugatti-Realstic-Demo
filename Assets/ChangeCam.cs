using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCam : MonoBehaviour
{
    public GameObject sideCam;
    public GameObject ThirdCam;
    public GameObject UpCam;
    public GameObject Dolly;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("1"))
        {
            ThirdCam.SetActive(true);
            sideCam.SetActive(false);

        }
        if (other.CompareTag("2"))
        {
            ThirdCam.SetActive(false);
            sideCam.SetActive(false);
            Dolly.SetActive(true);

        }
    }


}
