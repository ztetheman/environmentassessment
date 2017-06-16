namespace EnvironmentAssessment.Common.VISoap
{
    public class VmDasBeingResetWithScreenshotEvent : VmDasBeingResetEvent
	{
		protected string _screenshotFilePath;
		public string ScreenshotFilePath
		{
			get
			{
				return this._screenshotFilePath;
			}
			set
			{
				this._screenshotFilePath = value;
			}
		}
	}
}
