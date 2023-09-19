using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField]
    Color32 hasPackageColor = new Color32(1, 1, 1, 1);

    [SerializeField]
    Color32 noPackageColor = new Color32(1, 1, 1, 1);

    [SerializeField] 
    float destroyDelay = 1;

    SpriteRenderer spriteRenderer;

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = noPackageColor;
    }

    private bool hasPackage = false;

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("crashed!");    
    }    

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && hasPackage == false){
            Debug.Log("Package secured.");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay); 
        }
        else if(other.tag == "Customer" && hasPackage == true){
            Debug.Log("Delivered package.");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
