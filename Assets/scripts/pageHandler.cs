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
    }

    public void nextPage()
    {
        pages.GetChild(currentPage).gameObject.SetActive(false);
        pages.GetChild(currentPage+1).gameObject.SetActive(false);
        currentPage++;
        if(currentPage <= pages.childCount - 1)
        {
            pages.GetChild(currentPage+2).gameObject.SetActive(true);
            pages.GetChild(currentPage + 3).gameObject.SetActive(true);
        }
        else
        {
            return;
        }
        
    }
}
