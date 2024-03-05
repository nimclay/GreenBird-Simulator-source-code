using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour,  IPointerEnterHandler
{
    bool hovering;
    public int sceneNumber;
    float x;
    Color boxColor;


    // Start is called before the first frame update
    void Awake()
    {
        boxColor = GetComponent<Image>().color;
    }

    // Update is called once per frame
    void Update()
    {
        if(hovering){
          
            GetComponent<Image>().color = Color.gray;
            if((Input.GetKeyDown(KeyCode.Mouse0)||Input.GetKeyDown(KeyCode.JoystickButton1))){
                loadscene.scene  = sceneNumber;
                SceneManager.LoadScene(0);
            }
        }
        else{
            GetComponent<Image>().color = boxColor;
        }
    }
     public void OnPointerOver(PointerEventData eventData)
     {
         
     }
    
     public void OnPointerEnter(PointerEventData eventData){
;
        hovering = true;
     }
     public void OnPointerExit(PointerEventData pointerEventData){
         hovering=false;
       
     }

     void OnTriggerEnter2D(Collider2D other){
         hovering = true;
     }
     void OnTriggerExit2D(Collider2D other){
         hovering = false;
     }
}
