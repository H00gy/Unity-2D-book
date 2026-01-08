using UnityEngine;

public class TableOfContents : MonoBehaviour
{
    [Header("The Specific page to link to")]
    public Transform SpecificPage;

    [Header("PageHandler")]
    pageHandler pageHandler;


    public void onClick() // table of contents, onClick is a button that takes to the page 
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
