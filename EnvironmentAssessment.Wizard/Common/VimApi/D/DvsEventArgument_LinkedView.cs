namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsEventArgument_LinkedView
	{
		protected DistributedVirtualSwitch _dvs;
		public DistributedVirtualSwitch Dvs
		{
			get
			{
				return this._dvs;
			}
			set
			{
				this._dvs = value;
			}
		}
	}
}
