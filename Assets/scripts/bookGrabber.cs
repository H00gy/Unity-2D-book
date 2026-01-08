using UnityEngine;

public class bookGrabber : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("openBook"))
        {
            Debug.Log("collided");
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("closedBook"))
        {
            Debug.Log("left");
        }
    }
}
