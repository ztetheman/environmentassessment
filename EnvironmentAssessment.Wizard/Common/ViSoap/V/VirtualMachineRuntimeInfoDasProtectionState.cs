namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineRuntimeInfoDasProtectionState : DynamicData
	{
		protected bool _dasProtected;
		public bool DasProtected
		{
			get
			{
				return this._dasProtected;
			}
			set
			{
				this._dasProtected = value;
			}
		}
	}
}
