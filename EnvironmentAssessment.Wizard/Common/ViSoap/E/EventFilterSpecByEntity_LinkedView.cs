namespace EnvironmentAssessment.Common.VISoap
{
    public class EventFilterSpecByEntity_LinkedView
	{
		protected ManagedEntity _entity;
		public ManagedEntity Entity
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
