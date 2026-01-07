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

   // static int pageNum = 1;
    static int currentPage = 0;

    void Start()
    {
        
        for (int i = 2;i< pages.childCount; i++)
        {
            pages.GetChild(i).gameObject.SetActive(false);
        }  
        leftPageNum.text = (currentPage+1).ToString();   
        rightPageNum.text = (currentPage+2).ToString();
    }

    public void nextPage()
    {

        int maxStart = pages.childCount - 2; // last valid pair start

        if (currentPage >= maxStart)
        {
            return;
        }
            

        // hide previous pair
        pages.GetChild(currentPage).gameObject.SetActive(false);
        pages.GetChild(currentPage + 1).gameObject.SetActive(false);

        currentPage+=2;

        // show new pair
        pages.GetChild(currentPage).gameObject.SetActive(true);
        pages.GetChild(currentPage +1 ).gameObject.SetActive(true);
        leftPageNum.text = (currentPage + 1).ToString();
        rightPageNum.text = (currentPage + 2).ToString();


    }

    public void previousPage()
    {
        

        if (currentPage == 0)
        {
            return;
        }


        // hide previous pair
        pages.GetChild(currentPage).gameObject.SetActive(false);
        pages.GetChild(currentPage + 1).gameObject.SetActive(false);

        currentPage -= 2;

        // show new pair
        pages.GetChild(currentPage).gameObject.SetActive(true);
        pages.GetChild(currentPage + 1).gameObject.SetActive(true);
        leftPageNum.text = (currentPage + 1).ToString();
        rightPageNum.text = (currentPage + 2).ToString();
    }
}
