using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign : MonoBehaviour
{
    public  GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public bool playerInRange;

    public void Update(){
        if(Input.GetKeyDown(KeyCode.E) && playerInRange){
            if(dialogBox.activeInHierarchy){
               dialogBox.SetActive(false); 
            }else{
                dialogBox.SetActive(true);
                dialogText.text = dialog;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            playerInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other){
        if(other.CompareTag("Player")){
            playerInRange = false;
            dialogBox.SetActive(false);
        }
    }
}
