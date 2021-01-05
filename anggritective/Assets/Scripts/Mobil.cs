using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mobil : MonoBehaviour
{
    public bool adaOrang;
    public GameObject buku;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && adaOrang)
        {
            if(buku.activeInHierarchy)
            {
                buku.SetActive(false);
            }else{
                buku.SetActive(true);
            }
        }

        if(adaOrang == false){
            buku.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D obj)
    {
        if(obj.CompareTag("Player"))
        {
            adaOrang = true;
        }
    }

    private void OnTriggerExit2D(Collider2D obj)
    {
        if(obj.CompareTag("Player"))
        {
            adaOrang = false;
        }
    }
}
