namespace EnvironmentAssessment.Common.VimApi
{
	public class DVSConfigInfo_LinkedView
	{
		protected DistributedVirtualPortgroup[] _uplinkPortgroup;
		public DistributedVirtualPortgroup[] UplinkPortgroup
		{
			get
			{
				return this._uplinkPortgroup;
			}
			set
			{
				this._uplinkPortgroup = value;
			}
		}
	}
}
