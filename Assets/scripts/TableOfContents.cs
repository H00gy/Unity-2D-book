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
        pageHandler.hidePage();
        pageHandler.goToPage(index);

    }
}
