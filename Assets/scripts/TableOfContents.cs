using UnityEngine;

public class TableOfContents : MonoBehaviour
{
    [Header("The Specific page to link to")]
    public Transform SpecificPage;
    [Header("Page Transform")]
    //public Transform pages;
    [Header("PageHandler")]
    pageHandler pageHandler;


    public void onClick()
    {
        pageHandler = GetComponentInParent<pageHandler>();

        int index = SpecificPage.GetSiblingIndex();
        if (index % 2 == 1)
        {
            index--;
        }
        pageHandler.pages.GetChild(0).gameObject.SetActive(false);
        pageHandler.pages.GetChild(1).gameObject.SetActive(false);
        pageHandler.pages.GetChild(index).gameObject.SetActive(true);
        pageHandler.pages.GetChild(index + 1).gameObject.SetActive(true);
        pageHandler.leftPageNum.text = (index + 1).ToString();
        pageHandler.rightPageNum.text = (index + 2).ToString();

    }
}
