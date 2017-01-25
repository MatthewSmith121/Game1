using UnityEngine;
using UnityEngine.UI;

public class BarracksScrollButton : MonoBehaviour {

	private Employee Emp;
	public Text ButtonText;
	public BarracksScrollView scrollView;

	public void SetName(Employee emp)
	{
		Emp = emp;
		ButtonText.text = emp.Name;
	}
	public void Button_Click()
	{
		scrollView.ButtonClicked(Emp);
	}
}
