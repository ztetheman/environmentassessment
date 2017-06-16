namespace EnvironmentAssessment.Common.VISoap
{
    public class GuestAuthentication : DynamicData
	{
		protected bool _interactiveSession;
		public bool InteractiveSession
		{
			get
			{
				return this._interactiveSession;
			}
			set
			{
				this._interactiveSession = value;
			}
		}
	}
}
