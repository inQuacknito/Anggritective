using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pintu : MonoBehaviour
{
    public bool adaOrang;
    public GameObject catatan;
    public GameObject pintu1, pintu2, pintu3,bukti1,bukti2,bukti3;
    public GameObject darah1, darah2, surat1, surat2;

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
            if(darah1.activeInHierarchy || surat1.activeInHierarchy)
            {
                if(darah2.activeInHierarchy || surat2.activeInHierarchy)
                {
                    if(!pintu3.activeInHierarchy && !bukti3.activeInHierarchy){
                        pintu3.SetActive(true);
                        bukti3.SetActive(true);
                    }
                }
                else
                {
                    if(!pintu2.activeInHierarchy && !bukti2.activeInHierarchy){
                        pintu2.SetActive(true);
                        bukti2.SetActive(true);
                    }
                }
            }
            else
            {
                if(!pintu1.activeInHierarchy && !bukti1.activeInHierarchy){
                        pintu1.SetActive(true);
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
