using Sandbox;

public sealed class teleporting : Component
{
	[Property] public Vector3 door { get; set; }

	protected override void OnUpdate()
	{

		if ( Input.Pressed( "use" ) )
		{
			WorldPosition = door;

			Sound.Play( "teleport_sound", GameObject.Transform.Position );
		}
	}
}
