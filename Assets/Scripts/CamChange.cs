using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamChange : MonoBehaviour
{

    public GameObject camoid, camnew;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            camoid.SetActive(false);
            camnew.SetActive(true);
        }
    }
}
