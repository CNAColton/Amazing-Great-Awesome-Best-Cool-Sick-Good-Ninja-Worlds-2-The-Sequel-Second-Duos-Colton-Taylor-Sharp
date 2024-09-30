using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hello : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(true);
    }
}
