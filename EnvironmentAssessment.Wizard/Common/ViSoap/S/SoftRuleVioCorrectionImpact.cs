namespace EnvironmentAssessment.Common.VISoap
{
    public class SoftRuleVioCorrectionImpact : VmConfigFault
	{
		protected string _vmName;
		public string VmName
		{
			get
			{
				return this._vmName;
			}
			set
			{
				this._vmName = value;
			}
		}
	}
}
