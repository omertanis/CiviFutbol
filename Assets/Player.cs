using UnityEngine;
using System.Collections;

/// <summary>
/// Flag that indicates the left or right player.
/// </summary>
public enum ePlayer
{
	Left,
	Right
}

public enum paraKonumu
{
	BeforeThrown,
	Thrown
}

/// <summary>
/// This behaviour is attached to a player.
/// It controls the movement of the player with the keyboard.
/// </summary>
public class Player : MonoBehaviour {
	

	/// <summary>
	/// Indicates if this is the left or right player.
	/// </summary>
	public ePlayer player;
	
	/// <summary>
	/// Updates the player position.
	/// We use FixedUpdate() instead of Update(), because the collision of the player is controlled by the physic engine.
	/// </summary>
}
