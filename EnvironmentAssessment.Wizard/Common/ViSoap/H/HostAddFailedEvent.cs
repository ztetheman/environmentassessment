namespace EnvironmentAssessment.Common.VISoap
{
    public class HostAddFailedEvent : HostEvent
	{
		protected string _hostname;
		public string Hostname
		{
			get
			{
				return this._hostname;
			}
			set
			{
				this._hostname = value;
			}
		}
	}
}
