namespace EnvironmentAssessment.Common.VISoap
{
    public class UncustomizableGuest : CustomizationFault
	{
		protected string _uncustomizableGuestOS;
		public string UncustomizableGuestOS
		{
			get
			{
				return this._uncustomizableGuestOS;
			}
			set
			{
				this._uncustomizableGuestOS = value;
			}
		}
	}
}
