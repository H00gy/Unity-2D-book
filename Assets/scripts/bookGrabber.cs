using UnityEngine;

public class bookGrabber : MonoBehaviour
{
    public GameObject closedBook;
    public GameObject openBook;

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
            other.transform.position = resetPos;

        }
    }
}
