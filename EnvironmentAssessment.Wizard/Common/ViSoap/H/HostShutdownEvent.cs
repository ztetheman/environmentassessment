namespace EnvironmentAssessment.Common.VISoap
{
    public class HostShutdownEvent : HostEvent
	{
		protected string _reason;
		public string Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
	}
}