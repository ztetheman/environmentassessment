namespace EnvironmentAssessment.Common.VISoap
{
    public class NoLicenseEvent : LicenseEvent
	{
		protected LicenseFeatureInfo _feature;
		public LicenseFeatureInfo Feature
		{
			get
			{
				return this._feature;
			}
			set
			{
				this._feature = value;
			}
		}
	}
}
