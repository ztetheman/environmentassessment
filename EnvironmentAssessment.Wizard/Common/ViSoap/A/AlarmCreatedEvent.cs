namespace EnvironmentAssessment.Common.VISoap
{
    public class AlarmCreatedEvent : AlarmEvent
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
