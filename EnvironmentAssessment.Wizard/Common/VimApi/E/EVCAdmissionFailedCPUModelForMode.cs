namespace EnvironmentAssessment.Common.VimApi
{
	public class EVCAdmissionFailedCPUModelForMode : EVCAdmissionFailed
	{
		protected string _currentEVCModeKey;
		public string CurrentEVCModeKey
		{
			get
			{
				return this._currentEVCModeKey;
			}
			set
			{
				this._currentEVCModeKey = value;
			}
		}
	}
}
