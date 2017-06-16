namespace EnvironmentAssessment.Common.VISoap
{
    public class SecondaryVmAlreadyRegistered : VmFaultToleranceIssue
	{
		protected string _instanceUuid;
		public string InstanceUuid
		{
			get
			{
				return this._instanceUuid;
			}
			set
			{
				this._instanceUuid = value;
			}
		}
	}
}
