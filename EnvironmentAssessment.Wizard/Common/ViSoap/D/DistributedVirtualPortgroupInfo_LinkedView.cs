namespace EnvironmentAssessment.Common.VISoap
{
    public class DistributedVirtualPortgroupInfo_LinkedView
	{
		protected DistributedVirtualPortgroup _portgroup;
		public DistributedVirtualPortgroup Portgroup
		{
			get
			{
				return this._portgroup;
			}
			set
			{
				this._portgroup = value;
			}
		}
	}
}