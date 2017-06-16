namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsUpgradeInProgressEvent : DvsEvent
	{
		protected DistributedVirtualSwitchProductSpec _productInfo;
		public DistributedVirtualSwitchProductSpec ProductInfo
		{
			get
			{
				return this._productInfo;
			}
			set
			{
				this._productInfo = value;
			}
		}
	}
}