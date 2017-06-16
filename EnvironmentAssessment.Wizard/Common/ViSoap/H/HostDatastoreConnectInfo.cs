namespace EnvironmentAssessment.Common.VISoap
{
    public class HostDatastoreConnectInfo : DynamicData
	{
		protected DatastoreSummary _summary;
		public DatastoreSummary Summary
		{
			get
			{
				return this._summary;
			}
			set
			{
				this._summary = value;
			}
		}
	}
}
