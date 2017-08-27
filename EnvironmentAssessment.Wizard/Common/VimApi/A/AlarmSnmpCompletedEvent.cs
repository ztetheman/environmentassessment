namespace EnvironmentAssessment.Common.VimApi
{
	public class AlarmSnmpCompletedEvent : AlarmEvent
	{
		protected ManagedEntityEventArgument _entity;
		public ManagedEntityEventArgument Entity
		{
			get
			{
				return this._entity;
			}
			set
			{
				this._entity = value;
			}
		}
	}
}
