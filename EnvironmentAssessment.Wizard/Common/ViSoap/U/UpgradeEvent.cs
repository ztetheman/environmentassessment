namespace EnvironmentAssessment.Common.VISoap
{
    public class UpgradeEvent : Event
	{
		protected string _message;
		public string Message
		{
			get
			{
				return this._message;
			}
			set
			{
				this._message = value;
			}
		}
	}
}
