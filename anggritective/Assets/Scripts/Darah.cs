using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Darah : MonoBehaviour
{
    public bool adaOrang;
    public GameObject catatan;
    public GameObject darah1, darah2, darah3,bukti1,bukti2,bukti3;
    public GameObject surat1, surat2, pintu1, pintu2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && adaOrang)
        {
            if(catatan.activeInHierarchy)
            {
                catatan.SetActive(false);
            }else{
                catatan.SetActive(true);
            }
        }

        if(Input.GetKey(KeyCode.E) && adaOrang && catatan.activeInHierarchy)
        {
            if(surat1.activeInHierarchy || pintu1.activeInHierarchy)
            {
                if(surat2.activeInHierarchy || pintu2.activeInHierarchy)
                {
                   if(!darah3.activeInHierarchy && !bukti3.activeInHierarchy){
                        darah3.SetActive(true);
                        bukti3.SetActive(true);
                    }
                }
                else
                {
                    if(!darah2.activeInHierarchy && !bukti2.activeInHierarchy){
                        darah2.SetActive(true);
                        bukti2.SetActive(true);
                    }
                }
            }
            else
            {
                if(!darah1.activeInHierarchy && !bukti1.activeInHierarchy){
                        darah1.SetActive(true);
                        bukti1.SetActive(true);
                }
            }
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
