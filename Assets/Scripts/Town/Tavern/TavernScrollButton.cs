using UnityEngine;
using UnityEngine.UI;

public class TavernScrollButton : MonoBehaviour {

    private Employee Emp;
    private int PatronId;
    public Text ButtonText;
    public TavernScrollView scrollView;

    public void SetName(Employee emp, int Id)
    {
        Emp = emp;
        PatronId = Id;
        ButtonText.text = emp.Name;
    }
    public void Button_Click()
    {
        scrollView.ButtonClicked(Emp, PatronId);
    }
}
