using Sandbox;

public sealed class TeleportComponent : Component
{
	[Property] public GameObject TargetObject { get; set; }
	[Property] public float Radius { get; set; } = 100f;

	[Property] public Vector3 TargetPosition { get; set; } = new( 100, 100, 100 );
	[Property] public SoundEvent TeleportSound { get; set; }

	protected override void OnUpdate()
	{
		if ( TargetObject == null )
			return;

		float distance = Vector3.DistanceBetween( Transform.Position, TargetObject.Transform.Position );


		if ( distance <= Radius && Input.Pressed( "use" ) )
		{
			Log.Info( "Teleporting via radius + key" );

			Transform.Position = TargetPosition;

			if ( TeleportSound is not null )
			{
				Sound.Play( TeleportSound, TargetPosition );
			}
		}
	}
}
