namespace EnvironmentAssessment.Common.VimApi
{
	public class SsdDiskNotAvailable : VimFault
	{
		protected string _devicePath;
		public string DevicePath
		{
			get
			{
				return this._devicePath;
			}
			set
			{
				this._devicePath = value;
			}
		}
	}
}
