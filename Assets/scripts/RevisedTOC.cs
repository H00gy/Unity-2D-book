using UnityEngine;

public class RevisedTOC : MonoBehaviour
{
    [Header("The Specific page to link to")]
    public Sprite PageSprite;

    [Header("PageHandler")]
    RevisedPageHandler pageHandler;

    int index;


    public void onClick() // table of contents, onClick is a button that takes to the page 
    {
        pageHandler = GetComponentInParent<RevisedPageHandler>();
        for (int i = 0; i < pageHandler.pages.Length; i++)
        {
            if (PageSprite == pageHandler.pages[i])
            {
                index = i;
                break;
            }
        }
        if (index % 2 == 1)
        {
            index--;
        }
        pageHandler.goToPage(index);

    }
}
