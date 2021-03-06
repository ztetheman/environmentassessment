namespace EnvironmentAssessment.Common.VimApi
{
	public class HostSpecificationOperationFailed : VimFault
	{
		protected ManagedObjectReference _host;
		protected HostSpecificationOperationFailed_LinkedView _linkedView;
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public HostSpecificationOperationFailed_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
