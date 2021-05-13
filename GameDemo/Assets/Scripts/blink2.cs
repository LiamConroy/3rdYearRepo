using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blink2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject redEye;
    public GameObject blueEye;
    public GameObject blueLight;
    public GameObject redLight;
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

        redEye.SetActive(false);

        yield return new WaitForSeconds(0.3f);

        redEye.SetActive(true);

        yield return new WaitForSeconds(0.4f);

        redEye.SetActive(false);

        yield return new WaitForSeconds(0.5f);

        redEye.SetActive(true);

        yield return new WaitForSeconds(1f);

        redEye.SetActive(false);
        redLight.SetActive(false);
        

        yield return new WaitForSeconds(2f);

        blueEye.SetActive(true);
        blueLight.SetActive(true);
        
    }
}
