using UnityEngine;

public class TableOfContents : MonoBehaviour
{
    [Header("The Specific page to link to")]
    public Transform SpecificPage;
    [Header("Page Transform")]
    public Transform pages;
    [Header("PageHandler")]
    public pageHandler pageHandler;
    

    public void onClick()
    {
        int index = SpecificPage.GetSiblingIndex();
        pages.GetChild(0).gameObject.SetActive(false);
        pages.GetChild(1).gameObject.SetActive(false);
        pages.GetChild(index).gameObject.SetActive(true);
        pages.GetChild(index + 1).gameObject.SetActive(true);
        pageHandler.leftPageNum.text = (index + 1).ToString();
        pageHandler.rightPageNum.text = (index + 2).ToString();

    }
}
