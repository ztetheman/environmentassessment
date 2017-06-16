namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsHostJoinedEvent : DvsEvent
	{
		protected HostEventArgument _hostJoined;
		public HostEventArgument HostJoined
		{
			get
			{
				return this._hostJoined;
			}
			set
			{
				this._hostJoined = value;
			}
		}
	}
}
