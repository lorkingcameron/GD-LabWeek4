using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i;
    private int randInt;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        randInt  = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(this.gameObject.name + ":" + i);
        if (this.gameObject.tag == "Red" && i == 100) {
            this.gameObject.SetActive(false);
        }
        if (this.gameObject.tag == "Blue" && i == randInt) {
            rend.enabled = false;
        }
    }
}
