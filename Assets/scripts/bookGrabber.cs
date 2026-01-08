using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class bookGrabber : MonoBehaviour
{
    public GameObject closedBook;
    public GameObject openBook;
    // A dictionary to store the last known position for each collider we touch.
    private Dictionary<Collider, Vector3> lastContactPositions = new Dictionary<Collider, Vector3>();

    private void Start()
    {
        closedBook.SetActive(false);
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("openBook"))
        {
            //Debug.Log("collided");
            other.gameObject.SetActive(false);
            closedBook.SetActive(true);

        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Vector2 resetPos = new Vector2(-2.23744011f, -2.19800019f);
        if (other.CompareTag("closedBook"))
        {
            other.gameObject.SetActive(false);
            openBook.transform.position = other.transform.position + new Vector3(0f, 1f);
            other.transform.position = resetPos;
            openBook.SetActive(true);
            
            

        }
    }
}
