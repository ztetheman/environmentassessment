namespace EnvironmentAssessment.Common.VISoap
{
    public class IscsiFaultVnicHasMultipleUplinks : IscsiFault
	{
		protected string _vnicDevice;
		public string VnicDevice
		{
			get
			{
				return this._vnicDevice;
			}
			set
			{
				this._vnicDevice = value;
			}
		}
	}
}
