namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterDasVmConfigSpec : ArrayUpdateSpec
	{
		protected ClusterDasVmConfigInfo _info;
		public ClusterDasVmConfigInfo Info
		{
			get
			{
				return this._info;
			}
			set
			{
				this._info = value;
			}
		}
	}
}
