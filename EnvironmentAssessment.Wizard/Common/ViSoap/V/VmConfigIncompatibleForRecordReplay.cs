namespace EnvironmentAssessment.Common.VISoap
{
    public class VmConfigIncompatibleForRecordReplay : VmConfigFault
	{
		protected LocalizedMethodFault _fault;
		public LocalizedMethodFault Fault
		{
			get
			{
				return this._fault;
			}
			set
			{
				this._fault = value;
			}
		}
	}
}
