namespace EnvironmentAssessment.Common.VISoap
{
    public class CustomizationFixedIp : CustomizationIpGenerator
	{
		protected string _ipAddress;
		public string IpAddress
		{
			get
			{
				return this._ipAddress;
			}
			set
			{
				this._ipAddress = value;
			}
		}
	}
}