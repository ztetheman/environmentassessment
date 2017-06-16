namespace EnvironmentAssessment.Common.VISoap
{
    public class PerfEntityMetricBase : DynamicData
	{
		protected ManagedObjectReference _entity;
		public ManagedObjectReference Entity
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
