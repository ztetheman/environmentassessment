namespace EnvironmentAssessment.Common.VimApi
{
	public class LicenseServerUnavailableEvent : LicenseEvent
	{
		protected string _licenseServer;
		public string LicenseServer
		{
			get
			{
				return this._licenseServer;
			}
			set
			{
				this._licenseServer = value;
			}
		}
	}
}
