using UnityEngine;

public class BarracksScrollView : MonoBehaviour {

	public GameObject Button_Template;
    public Player player;

	// Use this for initialization
	void Start () {
	
        foreach (Employee emp in player.Staff)
		{
			GameObject go = Instantiate(Button_Template) as GameObject;
			go.SetActive(true);
			BarracksScrollButton TB = go.GetComponent<BarracksScrollButton>();
			TB.SetName(emp);
			go.transform.SetParent(Button_Template.transform.parent);
		}
	}
	
	public void ButtonClicked(Employee emp)
	{
		Debug.Log(emp.Name + " button clicked.");
        BarracksPanel bp = BarracksPanel.Instance();
        bp.CharacterSheet(emp);
    }
}
