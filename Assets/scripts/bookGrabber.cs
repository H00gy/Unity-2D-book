using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class bookGrabber : MonoBehaviour
{
    public GameObject closedBook;
    public GameObject openBook;
    

    private void Start()
    {
        openBook.SetActive(false);
        closedBook.SetActive(true);
    }
    private void OnTriggerStay2D(Collider2D other) // puts away the book
    {
        if (other.CompareTag("openBook"))
        {
            Vector2 resetPos = new Vector2(-2.23744011f, -2.19800019f);
            //Debug.Log("collided");
            other.gameObject.SetActive(false);
            closedBook.SetActive(true);
            closedBook.transform.position = resetPos;
        }
    }
    private void OnTriggerExit2D(Collider2D other) // opens the book
    {
        if (other.CompareTag("closedBook"))
        {
            other.gameObject.SetActive(false);
            openBook.transform.position = other.transform.position + new Vector3(0f, 1f);
            openBook.SetActive(true);
        
        }
    }
}
