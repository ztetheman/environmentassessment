namespace EnvironmentAssessment.Common.VISoap
{
    public class AffinityConfigured : MigrationFault
	{
		protected string[] _configuredAffinity;
		public string[] ConfiguredAffinity
		{
			get
			{
				return this._configuredAffinity;
			}
			set
			{
				this._configuredAffinity = value;
			}
		}
	}
}
