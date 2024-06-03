using TMPro;
using UnityEngine;

public class HomeSceneButton : MonoBehaviour
{
    [SerializeField] RectTransform shopPanel;
    [SerializeField] TextMeshProUGUI ticketNumberText;
    int ticketNumber;
    Vector2 firstPos;

    void Start()
    {
        firstPos = shopPanel.transform.position;
        ticketNumber = PlayerPrefs.GetInt("TicketNumber");
        ticketNumberText.text = ticketNumber.ToString();
    }

    public void ShowObject(RectTransform rectTransform)
    {
        rectTransform.position = new Vector2(0, 0);
    }

    public void HideObject(RectTransform rectTransform)
    {
        rectTransform.position = firstPos;
    }

    public void BuyTicket(int number)
    {
        ticketNumber += number;
        PlayerPrefs.SetInt("TicketNumber", ticketNumber);
        ticketNumberText.text = ticketNumber.ToString();
    }
}