namespace EnvironmentAssessment.Common.VISoap
{
    public class TaskReasonAlarm_LinkedView
	{
		protected Alarm _alarm;
		protected ManagedEntity _entity;
		public Alarm Alarm
		{
			get
			{
				return this._alarm;
			}
			set
			{
				this._alarm = value;
			}
		}
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
