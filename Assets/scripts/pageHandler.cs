using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class pageHandler : MonoBehaviour
{
    [Header("Page Transform")]
    public Transform pages;
    [Header("Page Numbers")]
    public TMP_Text leftPageNum;
    public TMP_Text rightPageNum;

    static int currentPage = 0;

    void Start() // makes sure the first time the book is open it opens on the first page
    {
        
        for (int i = 2;i< pages.childCount; i++)
        {
            pages.GetChild(i).gameObject.SetActive(false);
        }  
        leftPageNum.text = (currentPage+1).ToString();   
        rightPageNum.text = (currentPage+2).ToString();
    }
    public void goToPage(int index)
    {
        currentPage = index; // Very Important, keeps the currentPage consistent 
        // show new pair
        pages.GetChild(index).gameObject.SetActive(true);
        pages.GetChild(index + 1).gameObject.SetActive(true);
        leftPageNum.text = (index + 1).ToString();
        rightPageNum.text = (index + 2).ToString();

    }
    public void hidePage()
    {
        // hide previous pair
        pages.GetChild(currentPage).gameObject.SetActive(false);
        pages.GetChild(currentPage + 1).gameObject.SetActive(false);
    }
    public void nextPage() // next page
    {

        int maxStart = pages.childCount - 2; // last valid pair start

        if (currentPage >= maxStart)
        {
            return;
        }
        hidePage();
        currentPage+=2;
        goToPage(currentPage);
    }

    public void previousPage() // previous page
    {

        if (currentPage == 0)
        {
            return;
        }

        hidePage();

        currentPage -= 2;

        goToPage(currentPage);
    }
    
}
