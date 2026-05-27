using UnityEngine;

public class RevisedPageHandler : MonoBehaviour
{
    // structure
    // root base with base sr
    // - left with left sr
    // - right with right sr
    // - 2 button children
    public Sprite[] pages; // list of pages
    public GameObject LeftPageHandlerObj; // left page
    public GameObject RightPageHandlerObj;  // right page
    SpriteRenderer LeftPageSR; // left sr
    SpriteRenderer RightPageSR; // right sr
    static int currentPage = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LeftPageSR = LeftPageHandlerObj.GetComponent<SpriteRenderer>(); // gets sr for both
        RightPageSR = RightPageHandlerObj.GetComponent<SpriteRenderer>();
        OpenBook();



    }
    public void OpenBook() // opens to first page
    {
        LeftPageSR.sprite = pages[0];
        RightPageSR.sprite = pages[1];
    }
    public void goToPage(int index)
    {
        currentPage = index; // Very Important, keeps the currentPage consistent 
        // show new pair
        LeftPageSR.sprite = pages[index];
        RightPageSR.sprite = pages[index + 1];

    }
    public void nextPage() // next page
    {

        int maxStart = pages.Length - 2; // last valid pair start

        if (currentPage >= maxStart)
        {
            return;
        }
        currentPage += 2;
        goToPage(currentPage);
    }

    public void previousPage() // previous page
    {

        if (currentPage == 0)
        {
            return;
        }


        currentPage -= 2;

        goToPage(currentPage);
    }
}
