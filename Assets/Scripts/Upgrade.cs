using UnityEngine;

[CreateAssetMenu(fileName = "New Upgrade", menuName = "Custom/Upgrade")]
public class Upgrade : ScriptableObject {

	public new string name;
	public string slug;
	public int id;
	public int cost;

}
