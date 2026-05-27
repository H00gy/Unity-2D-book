using UnityEngine;

public class RevisedTOC : MonoBehaviour
{
    [Header("The Specific page to link to")]
    public int PageIndex;

    [Header("PageHandler")]
    pageHandler pageHandler;


    public void onClick() // table of contents, onClick is a button that takes to the page 
    {
        pageHandler = GetComponentInParent<pageHandler>();

        if (PageIndex % 2 == 1)
        {
            PageIndex--;
        }
        pageHandler.hidePage();
        pageHandler.goToPage(PageIndex);

    }
}
