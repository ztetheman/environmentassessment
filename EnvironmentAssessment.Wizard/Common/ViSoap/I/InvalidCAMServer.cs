namespace EnvironmentAssessment.Common.VISoap
{
    public class InvalidCAMServer : ActiveDirectoryFault
	{
		protected string _camServer;
		public string CamServer
		{
			get
			{
				return this._camServer;
			}
			set
			{
				this._camServer = value;
			}
		}
	}
}
