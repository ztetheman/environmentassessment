namespace EnvironmentAssessment.Common.VISoap
{
    public class HostUnresolvedVmfsResignatureSpec : DynamicData
	{
		protected string[] _extentDevicePath;
		public string[] ExtentDevicePath
		{
			get
			{
				return this._extentDevicePath;
			}
			set
			{
				this._extentDevicePath = value;
			}
		}
	}
}
