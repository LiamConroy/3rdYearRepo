using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blink : MonoBehaviour
{


    public GameObject eye;
    public GameObject red;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Blink());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Blink(){
         yield return new WaitForSeconds(0.7f);

        eye.SetActive(false);

        yield return new WaitForSeconds(0.3f);

        eye.SetActive(true);

        yield return new WaitForSeconds(0.4f);

        eye.SetActive(false);

        yield return new WaitForSeconds(0.5f);

        eye.SetActive(true);

        yield return new WaitForSeconds(2f);

        eye.SetActive(false);

        yield return new WaitForSeconds(2.5f);

        red.SetActive(false);
    }
}
