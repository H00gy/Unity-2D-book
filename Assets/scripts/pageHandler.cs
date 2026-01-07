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

    static int pageNum = 1;
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
        for (int i = 0; i<pages.childCount; i++)
        {
            if (pages.GetChild(i).gameObject.activeSelf)
            {
                pages.GetChild(i).gameObject.SetActive(false);
                pages.GetChild(i+1).gameObject.SetActive(true);


            }
            else
            {
                return;
            }
        }
    }
}
